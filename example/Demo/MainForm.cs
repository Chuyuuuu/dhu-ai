using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Models;
using Demo.Services;

namespace Demo
{
    public partial class MainForm : AntdUI.Window
    {
        private readonly Dictionary<DateOnly, DiaryEntry> _entries = new();
        private readonly OpenAiService _service = new();
        private readonly List<ScheduleItem> _schedules = new();

        public MainForm()
        {
            InitializeComponent();
            InitSchedule();
            LoadCurrentSettingsPreview();
            LoadEntry(DateOnly.FromDateTime(DateTime.Now));
        }

        /// <summary>
        /// 初始化右侧课程/Deadline 示例数据。
        /// </summary>
        private void InitSchedule()
        {
            _schedules.Clear();
            _schedules.AddRange(new[]
            {
                new ScheduleItem{ Title = "高数作业", Time = DateTime.Now.AddDays(1).Date.AddHours(20), Type = "作业", Remark = "完成章节习题 5-1"},
                new ScheduleItem{ Title = "计算机网络小测", Time = DateTime.Now.AddDays(2).Date.AddHours(14), Type = "考试", Remark = "复习第三章"},
                new ScheduleItem{ Title = "社团策划会", Time = DateTime.Now.AddDays(3).Date.AddHours(18), Type = "社团", Remark = "准备迎新活动"},
                new ScheduleItem{ Title = "英语演讲", Time = DateTime.Now.AddDays(4).Date.AddHours(10), Type = "课程", Remark = "练习稿件"}
            });
            RefreshSchedule();
        }

        private void LoadEntry(DateOnly date)
        {
            datePicker.Value = date.ToDateTime(TimeOnly.MinValue);
            if (_entries.TryGetValue(date, out var entry))
            {
                moodCombo.Text = entry.Mood;
                foreach (CheckBox cb in stateFlow.Controls.OfType<CheckBox>())
                {
                    cb.Checked = entry.States.Contains(cb.Text);
                }
                diaryText.Text = entry.DiaryText;
                UpdateAnalysis(entry);
            }
            else
            {
                moodCombo.SelectedIndex = -1;
                foreach (CheckBox cb in stateFlow.Controls.OfType<CheckBox>()) cb.Checked = false;
                diaryText.Clear();
                ResetAnalysis();
            }
            RefreshTimeline();
        }

        private DiaryEntry CollectEntry()
        {
            var date = DateOnly.FromDateTime(datePicker.Value.Date);
            if (!_entries.TryGetValue(date, out var entry)) entry = new DiaryEntry { Date = date };
            entry.Mood = moodCombo.Text;
            entry.States = stateFlow.Controls.OfType<CheckBox>().Where(c => c.Checked).Select(c => c.Text).ToList();
            entry.DiaryText = diaryText.Text;
            return entry;
        }

        private async void analyzeButton_Click(object sender, EventArgs e)
        {
            analyzeButton.Loading = true;
            var entry = CollectEntry();
            var result = await _service.AnalyzeAsync(entry, _schedules);
            UpdateAnalysis(entry);
            analyzeButton.Loading = false;
            MessageBox.Show("情绪画像已生成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateAnalysis(DiaryEntry entry)
        {
            anxietyValueLabel.Text = entry.AnxietyScore.ToString();
            depressionValueLabel.Text = entry.DepressionScore.ToString();
            anxietyProgress.Value = entry.AnxietyScore / 100f;
            depressionProgress.Value = entry.DepressionScore / 100f;
            insightText.Text = entry.Insight;
            suggestionList.Items.Clear();
            suggestionList.Items.AddRange(entry.Suggestions.ToArray());
            actionList.Items.Clear();
            foreach (var item in entry.ActionItems)
            {
                var listItem = new ListViewItem(item.Title);
                listItem.SubItems.Add(item.Due);
                actionList.Items.Add(listItem);
            }
        }

        private void ResetAnalysis()
        {
            anxietyValueLabel.Text = depressionValueLabel.Text = "--";
            anxietyProgress.Value = depressionProgress.Value = 0f;
            insightText.Clear();
            suggestionList.Items.Clear();
            actionList.Items.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var entry = CollectEntry();
            _entries[entry.Date] = entry;
            RefreshTimeline();
            MessageBox.Show("已保存到时间线", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            moodCombo.SelectedIndex = -1;
            foreach (CheckBox cb in stateFlow.Controls.OfType<CheckBox>()) cb.Checked = false;
            diaryText.Clear();
            ResetAnalysis();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadEntry(DateOnly.FromDateTime(datePicker.Value.Date));
        }

        private void timelineGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < timelineGrid.Rows.Count)
            {
                var row = timelineGrid.Rows[e.RowIndex];
                var date = DateOnly.Parse(row.Cells["TimelineDate"].Value.ToString()!);
                LoadEntry(date);
            }
        }

        private void RefreshTimeline()
        {
            timelineGrid.Rows.Clear();
            foreach (var kv in _entries.OrderByDescending(x => x.Key))
            {
                timelineGrid.Rows.Add(kv.Key.ToString("yyyy-MM-dd"), kv.Value.Mood, kv.Value.AnxietyScore, kv.Value.DepressionScore);
            }
        }

        private void RefreshSchedule()
        {
            scheduleGrid.Rows.Clear();
            foreach (var s in _schedules.OrderBy(x => x.Time))
            {
                scheduleGrid.Rows.Add(s.Title, s.Time.ToString("yyyy-MM-dd HH:mm"), s.Type, s.Remark);
            }
            forecastList.Items.Clear();
            foreach (var s in _schedules.OrderBy(x => x.Time).Take(5))
            {
                var days = (s.Time.Date - DateTime.Now.Date).TotalDays;
                var pressure = days < 2 ? "压力较高" : days < 5 ? "需要提前准备" : "保持节奏";
                forecastList.Items.Add($"{s.Time:MM-dd} {s.Title} - {pressure}");
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            using var form = new SettingsForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadCurrentSettingsPreview();
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            var entry = CollectEntry();
            var prompt = _service.BuildUserPrompt(entry, _schedules, AppSettings.Instance);
            using var form = new PromptPreviewForm(prompt);
            form.ShowDialog(this);
        }

        private void LoadCurrentSettingsPreview()
        {
            modelLabel.Text = AppSettings.Instance.Model;
            baseUrlLabel.Text = string.IsNullOrWhiteSpace(AppSettings.Instance.BaseUrl) ? "https://api.openai.com/v1" : AppSettings.Instance.BaseUrl;
            tuneLabel.Text = AppSettings.Instance.EnableDeadlineTuning ? "已开启" : "未启用";
            gentleLabel.Text = AppSettings.Instance.EnableGentleTone ? "温柔语气" : "默认";
            systemPromptPreview.Text = TrimText(AppSettings.Instance.SystemPrompt);
            outputPreview.Text = TrimText(AppSettings.Instance.OutputFormat);
        }

        private static string TrimText(string text)
        {
            if (string.IsNullOrEmpty(text)) return string.Empty;
            return text.Length > 120 ? text[..120] + "..." : text;
        }
    }
}
