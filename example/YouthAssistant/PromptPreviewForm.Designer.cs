namespace YouthAssistant
{
    partial class PromptPreviewForm
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
            promptText = new System.Windows.Forms.TextBox();
            copyButton = new AntdUI.Button();
            closeButton = new AntdUI.Button();
            buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // promptText
            // 
            promptText.Dock = System.Windows.Forms.DockStyle.Fill;
            promptText.Multiline = true;
            promptText.ReadOnly = true;
            promptText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            promptText.PlaceholderText = "完整 prompt 预览";
            // 
            // copyButton
            // 
            copyButton.AutoSizeMode = AntdUI.TAutoSize.Auto;
            copyButton.Text = "复制到剪贴板";
            copyButton.Type = AntdUI.TTypeMini.Primary;
            copyButton.Margin = new System.Windows.Forms.Padding(5);
            copyButton.Size = new System.Drawing.Size(120, 32);
            copyButton.Click += copyButton_Click;
            // 
            // closeButton
            // 
            closeButton.AutoSizeMode = AntdUI.TAutoSize.Auto;
            closeButton.Text = "关闭";
            closeButton.Margin = new System.Windows.Forms.Padding(5);
            closeButton.Size = new System.Drawing.Size(90, 32);
            closeButton.Click += closeButton_Click;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(copyButton);
            buttonPanel.Controls.Add(closeButton);
            buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            buttonPanel.Padding = new System.Windows.Forms.Padding(10);
            buttonPanel.Height = 60;
            // 
            // PromptPreviewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(820, 640);
            Controls.Add(promptText);
            Controls.Add(buttonPanel);
            Text = "Prompt 预览";
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox promptText;
        private AntdUI.Button copyButton;
        private AntdUI.Button closeButton;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
    }
}
