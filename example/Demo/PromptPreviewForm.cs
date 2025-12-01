using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class PromptPreviewForm : AntdUI.Window
    {
        public PromptPreviewForm(string prompt)
        {
            InitializeComponent();
            promptText.Text = prompt;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(promptText.Text);
            MessageBox.Show("已复制到剪贴板", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
