using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Demo
{
    /// <summary>
    /// 全局设置单例，负责保存与加载用户配置。
    /// </summary>
    public class AppSettings
    {
        private static readonly Lazy<AppSettings> _instance = new(() => Load());
        public static AppSettings Instance => _instance.Value;

        public string ApiKey { get; set; } = string.Empty;
        public string BaseUrl { get; set; } = string.Empty;
        public string Model { get; set; } = "gpt-4o";
        public string SystemPrompt { get; set; } = "你是\"青春情绪助手\"，以温柔、务实的语气陪伴中国大学生，关注心理健康、作息和课程安排。你不会给出医疗诊断，只提供日常心理调适、学习规划和作息建议。";
        public string OutputFormat { get; set; } = "{\n  \"anxiety\":0,\n  \"depression\":0,\n  \"insight\":\"一句中文总结\",\n  \"suggestions\":[\"建议1\",\"建议2\",\"建议3\"],\n  \"action_items\":[{\n    \"title\":\"待办标题\",\n    \"due\":\"YYYY-MM-DD HH:mm\"\n  }]\n}";
        public bool EnableDeadlineTuning { get; set; }
        public bool EnableGentleTone { get; set; } = true;

        public static string SettingPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "YouthMoodAssistant", "settings.json");

        private static AppSettings Load()
        {
            try
            {
                var path = SettingPath;
                if (File.Exists(path))
                {
                    var json = File.ReadAllText(path);
                    var loaded = JsonSerializer.Deserialize<AppSettings>(json);
                    if (loaded != null) return loaded;
                }
            }
            catch
            {
                // 忽略读取错误，使用默认值
            }
            return new AppSettings();
        }

        public void Save()
        {
            try
            {
                var dir = Path.GetDirectoryName(SettingPath)!;
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(SettingPath, json);
            }
            catch
            {
                // 写入失败时忽略，避免阻塞主流程
            }
        }
    }
}
