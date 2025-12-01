using System;
using System.Windows.Forms;

namespace YouthAssistant
{
    internal static class Program
    {
        /// <summary>
        /// 应用入口
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            AntdUI.Localization.DefaultLanguage = "zh-CN";
            AntdUI.Config.TextRenderingHighQuality = true;
            AntdUI.Config.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            Application.Run(new MainForm());
        }
    }
}
