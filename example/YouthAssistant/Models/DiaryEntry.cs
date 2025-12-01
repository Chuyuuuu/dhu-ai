using System;
using System.Collections.Generic;

namespace YouthAssistant.Models
{
    public class ActionItem
    {
        public string Title { get; set; } = string.Empty;
        public string Due { get; set; } = string.Empty;
    }

    public class AnalysisResult
    {
        public int Anxiety { get; set; }
        public int Depression { get; set; }
        public string Insight { get; set; } = string.Empty;
        public List<string> Suggestions { get; set; } = new();
        public List<ActionItem> ActionItems { get; set; } = new();
    }

    public class DiaryEntry
    {
        public DateOnly Date { get; set; }
        public string Mood { get; set; } = string.Empty;
        public List<string> States { get; set; } = new();
        public string DiaryText { get; set; } = string.Empty;
        public int AnxietyScore { get; set; }
        public int DepressionScore { get; set; }
        public string Insight { get; set; } = string.Empty;
        public List<string> Suggestions { get; set; } = new();
        public List<ActionItem> ActionItems { get; set; } = new();
    }

    public class ScheduleItem
    {
        public string Title { get; set; } = string.Empty;
        public DateTime Time { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Remark { get; set; } = string.Empty;
    }
}
