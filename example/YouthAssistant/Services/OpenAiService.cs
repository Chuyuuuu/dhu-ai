using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using YouthAssistant.Models;

namespace YouthAssistant.Services
{
    /// <summary>
    /// 封装与 OpenAI Chat Completions 的交互。
    /// </summary>
    public class OpenAiService
    {
        private readonly HttpClient _client = new();

        public async Task<AnalysisResult> AnalyzeAsync(DiaryEntry entry, List<ScheduleItem> schedules)
        {
            var settings = AppSettings.Instance;
            if (string.IsNullOrWhiteSpace(settings.ApiKey))
            {
                return LocalHeuristic(entry);
            }

            try
            {
                var prompt = BuildUserPrompt(entry, schedules, settings);
                var request = new
                {
                    model = settings.Model,
                    messages = new List<object>
                    {
                        new { role = "system", content = settings.SystemPrompt },
                        new { role = "user", content = prompt }
                    }
                };

                var baseUrl = string.IsNullOrWhiteSpace(settings.BaseUrl) ? "https://api.openai.com/v1" : settings.BaseUrl.TrimEnd('/') + (settings.BaseUrl.EndsWith("/v1") ? string.Empty : "/v1");
                _client.BaseAddress = new Uri(baseUrl);
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", settings.ApiKey);
                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _client.PostAsync("chat/completions", content);
                response.EnsureSuccessStatusCode();
                var respText = await response.Content.ReadAsStringAsync();
                using var doc = JsonDocument.Parse(respText);
                var message = doc.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
                if (!string.IsNullOrWhiteSpace(message))
                {
                    return ParseResult(message!, entry);
                }
            }
            catch
            {
                // 忽略网络或解析异常，回退本地分析
            }

            return LocalHeuristic(entry);
        }

        /// <summary>
        /// 构造用户 Prompt 片段。
        /// </summary>
        public string BuildUserPrompt(DiaryEntry entry, List<ScheduleItem> schedules, AppSettings settings)
        {
            var sb = new StringBuilder();
            sb.AppendLine("你是青春情绪助手，请根据下面提供的大学生日记与状态，分析 TA 当前的心理状态，并给出结构化的 JSON 输出。");
            sb.AppendLine();
            sb.AppendLine($"日期：{entry.Date:yyyy-MM-dd}");
            sb.AppendLine($"心情：{entry.Mood}");
            sb.AppendLine($"状态标签：{string.Join("、", entry.States)}");
            sb.AppendLine("日记全文：");
            sb.AppendLine(entry.DiaryText);

            if (settings.EnableDeadlineTuning && schedules.Any())
            {
                sb.AppendLine();
                sb.AppendLine("近期课程和重要事件：");
                foreach (var s in schedules.OrderBy(x => x.Time).Take(5))
                {
                    sb.AppendLine($"- {s.Title}（时间：{s.Time:yyyy-MM-dd HH:mm}）：{s.Remark}");
                }
            }

            if (settings.EnableGentleTone)
            {
                sb.AppendLine();
                sb.AppendLine("请使用温柔、尊重、不过度夸大的语气，不要吓唬用户。");
            }

            sb.AppendLine();
            sb.AppendLine("输出要求：");
            sb.AppendLine("1. 识别并打分：焦虑指数、抑郁指数（0-100）。");
            sb.AppendLine("2. 用一句中文总结并鼓励对方。");
            sb.AppendLine("3. 给出 3-5 条学习与生活建议。");
            sb.AppendLine("4. 结合课程/Deadline 生成行动卡片，每条包含 title 与 due。");
            sb.AppendLine();
            sb.AppendLine("请严格按照下面的 JSON 模板输出，不要添加额外说明：");
            sb.AppendLine(settings.OutputFormat);
            return sb.ToString();
        }

        /// <summary>
        /// 解析模型返回 JSON。
        /// </summary>
        private AnalysisResult ParseResult(string json, DiaryEntry entry)
        {
            try
            {
                var result = JsonSerializer.Deserialize<AnalysisResult>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                if (result != null)
                {
                    entry.AnxietyScore = result.Anxiety;
                    entry.DepressionScore = result.Depression;
                    entry.Insight = result.Insight;
                    entry.Suggestions = result.Suggestions ?? new();
                    entry.ActionItems = result.ActionItems ?? new();
                    return result;
                }
            }
            catch
            {
                // 解析异常
            }
            return LocalHeuristic(entry);
        }

        /// <summary>
        /// 本地启发式分析，避免网络失败时界面空白。
        /// </summary>
        private AnalysisResult LocalHeuristic(DiaryEntry entry)
        {
            var text = entry.DiaryText ?? string.Empty;
            int anxiety = 30;
            int depression = 25;
            if (text.Contains("焦虑") || text.Contains("紧张") || text.Contains("考试")) anxiety += 30;
            if (text.Contains("崩溃") || text.Contains("低落") || text.Contains("失眠")) depression += 35;
            anxiety = Math.Clamp(anxiety, 0, 100);
            depression = Math.Clamp(depression, 0, 100);

            var result = new AnalysisResult
            {
                Anxiety = anxiety,
                Depression = depression,
                Insight = string.IsNullOrWhiteSpace(entry.DiaryText)
                    ? "今天的记录还比较简短，保持觉察与自我关照。"
                    : "看得出你在努力平衡学习与生活，保持节奏并适当休息会更好。",
                Suggestions = new List<string>
                {
                    "睡前放松 20 分钟，做几个深呼吸放松训练",
                    "给自己安排一段无干扰的学习时间，完成最重要的任务",
                    "和可信赖的朋友聊聊，分享你的感受"
                },
                ActionItems = new List<ActionItem>
                {
                    new ActionItem{ Title = "整理明日待办清单", Due = DateTime.Now.AddHours(12).ToString("yyyy-MM-dd HH:mm") }
                }
            };

            entry.AnxietyScore = result.Anxiety;
            entry.DepressionScore = result.Depression;
            entry.Insight = result.Insight;
            entry.Suggestions = result.Suggestions;
            entry.ActionItems = result.ActionItems;
            return result;
        }
    }
}
