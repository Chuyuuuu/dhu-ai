using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace YouthAssistant
{
    public partial class SettingsForm : AntdUI.Window
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadCurrent();
        }

        private void LoadCurrent()
        {
            var s = AppSettings.Instance;
            apiKeyBox.Text = s.ApiKey;
            baseUrlBox.Text = s.BaseUrl;
            modelBox.Text = s.Model;
            systemPromptBox.Text = s.SystemPrompt;
            outputFormatBox.Text = s.OutputFormat;
            deadlineCheck.Checked = s.EnableDeadlineTuning;
            gentleCheck.Checked = s.EnableGentleTone;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var s = AppSettings.Instance;
            s.ApiKey = apiKeyBox.Text;
            s.BaseUrl = baseUrlBox.Text;
            s.Model = modelBox.Text;
            s.SystemPrompt = systemPromptBox.Text;
            s.OutputFormat = outputFormatBox.Text;
            s.EnableDeadlineTuning = deadlineCheck.Checked;
            s.EnableGentleTone = gentleCheck.Checked;
            s.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private async void testButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(apiKeyBox.Text))
                {
                    MessageBox.Show("请先填写 API Key", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                using var client = new HttpClient();
                if (!string.IsNullOrWhiteSpace(baseUrlBox.Text)) client.BaseAddress = new Uri(baseUrlBox.Text);
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKeyBox.Text);
                var body = JsonSerializer.Serialize(new
                {
                    model = modelBox.Text,
                    messages = new[]
                    {
                        new { role = "user", content = "ping"}
                    }
                });
                var resp = await client.PostAsync("/v1/chat/completions", new StringContent(body, Encoding.UTF8, "application/json"));
                resp.EnsureSuccessStatusCode();
                MessageBox.Show("连接成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"连接失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
