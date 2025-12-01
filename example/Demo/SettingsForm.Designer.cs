namespace Demo
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            layout = new System.Windows.Forms.TableLayoutPanel();
            titleLabel = new System.Windows.Forms.Label();
            apiKeyLabel = new System.Windows.Forms.Label();
            apiKeyBox = new System.Windows.Forms.TextBox();
            baseUrlLabel = new System.Windows.Forms.Label();
            baseUrlBox = new System.Windows.Forms.TextBox();
            modelLabel = new System.Windows.Forms.Label();
            modelBox = new System.Windows.Forms.TextBox();
            systemPromptLabel = new System.Windows.Forms.Label();
            systemPromptBox = new System.Windows.Forms.TextBox();
            outputFormatLabel = new System.Windows.Forms.Label();
            outputFormatBox = new System.Windows.Forms.TextBox();
            deadlineCheck = new System.Windows.Forms.CheckBox();
            gentleCheck = new System.Windows.Forms.CheckBox();
            buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            testButton = new AntdUI.Button();
            saveButton = new AntdUI.Button();
            cancelButton = new AntdUI.Button();
            layout.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // layout
            // 
            layout.ColumnCount = 2;
            layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            layout.Controls.Add(titleLabel, 0, 0);
            layout.Controls.Add(apiKeyLabel, 0, 1);
            layout.Controls.Add(apiKeyBox, 1, 1);
            layout.Controls.Add(baseUrlLabel, 0, 2);
            layout.Controls.Add(baseUrlBox, 1, 2);
            layout.Controls.Add(modelLabel, 0, 3);
            layout.Controls.Add(modelBox, 1, 3);
            layout.Controls.Add(systemPromptLabel, 0, 4);
            layout.Controls.Add(systemPromptBox, 1, 4);
            layout.Controls.Add(outputFormatLabel, 0, 5);
            layout.Controls.Add(outputFormatBox, 1, 5);
            layout.Controls.Add(deadlineCheck, 1, 6);
            layout.Controls.Add(gentleCheck, 1, 7);
            layout.Controls.Add(buttonPanel, 1, 8);
            layout.Dock = System.Windows.Forms.DockStyle.Fill;
            layout.RowCount = 9;
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            layout.SetColumnSpan(titleLabel, 2);
            titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            titleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            titleLabel.Text = "AI 接口与提示词设置";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // apiKeyLabel
            // 
            apiKeyLabel.AutoSize = true;
            apiKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            apiKeyLabel.Text = "API Key";
            apiKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // apiKeyBox
            // 
            apiKeyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            apiKeyBox.PasswordChar = '*';
            // 
            // baseUrlLabel
            // 
            baseUrlLabel.AutoSize = true;
            baseUrlLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            baseUrlLabel.Text = "BaseUrl";
            baseUrlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baseUrlBox
            // 
            baseUrlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            baseUrlBox.PlaceholderText = "https://api.openai.com/v1";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            modelLabel.Text = "模型";
            modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modelBox
            // 
            modelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            modelBox.Text = "gpt-4o";
            // 
            // systemPromptLabel
            // 
            systemPromptLabel.AutoSize = true;
            systemPromptLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            systemPromptLabel.Text = "系统提示词";
            systemPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // systemPromptBox
            // 
            systemPromptBox.Dock = System.Windows.Forms.DockStyle.Fill;
            systemPromptBox.Multiline = true;
            systemPromptBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // outputFormatLabel
            // 
            outputFormatLabel.AutoSize = true;
            outputFormatLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outputFormatLabel.Text = "输出 JSON 模板";
            outputFormatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputFormatBox
            // 
            outputFormatBox.Dock = System.Windows.Forms.DockStyle.Fill;
            outputFormatBox.Multiline = true;
            outputFormatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // deadlineCheck
            // 
            deadlineCheck.AutoSize = true;
            deadlineCheck.Text = "结合课程/Deadline 调整建议";
            deadlineCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // gentleCheck
            // 
            gentleCheck.AutoSize = true;
            gentleCheck.Text = "使用温柔语气";
            gentleCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(testButton);
            buttonPanel.Controls.Add(saveButton);
            buttonPanel.Controls.Add(cancelButton);
            buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // testButton
            // 
            testButton.AutoSizeMode = AntdUI.TAutoSize.Auto;
            testButton.Text = "测试连接";
            testButton.Margin = new System.Windows.Forms.Padding(5);
            testButton.Size = new System.Drawing.Size(100, 32);
            testButton.Click += testButton_Click;
            // 
            // saveButton
            // 
            saveButton.AutoSizeMode = AntdUI.TAutoSize.Auto;
            saveButton.Text = "保存设置";
            saveButton.Type = AntdUI.TTypeMini.Primary;
            saveButton.Margin = new System.Windows.Forms.Padding(5);
            saveButton.Size = new System.Drawing.Size(100, 32);
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.AutoSizeMode = AntdUI.TAutoSize.Auto;
            cancelButton.Text = "取消";
            cancelButton.Margin = new System.Windows.Forms.Padding(5);
            cancelButton.Size = new System.Drawing.Size(100, 32);
            cancelButton.Click += cancelButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(720, 640);
            Controls.Add(layout);
            Text = "AI 设置";
            layout.ResumeLayout(false);
            layout.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.TextBox apiKeyBox;
        private System.Windows.Forms.Label baseUrlLabel;
        private System.Windows.Forms.TextBox baseUrlBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.Label systemPromptLabel;
        private System.Windows.Forms.TextBox systemPromptBox;
        private System.Windows.Forms.Label outputFormatLabel;
        private System.Windows.Forms.TextBox outputFormatBox;
        private System.Windows.Forms.CheckBox deadlineCheck;
        private System.Windows.Forms.CheckBox gentleCheck;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private AntdUI.Button testButton;
        private AntdUI.Button saveButton;
        private AntdUI.Button cancelButton;
    }
}
