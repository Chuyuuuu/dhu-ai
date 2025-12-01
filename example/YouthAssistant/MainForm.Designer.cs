namespace YouthAssistant
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            mainLayout = new System.Windows.Forms.TableLayoutPanel();
            headerBar = new AntdUI.PageHeader();
            headerButtons = new System.Windows.Forms.FlowLayoutPanel();
            settingsButton = new AntdUI.Button();
            previewButton = new AntdUI.Button();
            contentLayout = new System.Windows.Forms.TableLayoutPanel();
            leftLayout = new System.Windows.Forms.TableLayoutPanel();
            infoPanel = new System.Windows.Forms.Panel();
            stateFlow = new System.Windows.Forms.FlowLayoutPanel();
            chkStudy = new System.Windows.Forms.CheckBox();
            chkClub = new System.Windows.Forms.CheckBox();
            chkWork = new System.Windows.Forms.CheckBox();
            chkNight = new System.Windows.Forms.CheckBox();
            chkLove = new System.Windows.Forms.CheckBox();
            chkExam = new System.Windows.Forms.CheckBox();
            moodCombo = new System.Windows.Forms.ComboBox();
            datePicker = new System.Windows.Forms.DateTimePicker();
            moodLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            diaryPanel = new System.Windows.Forms.Panel();
            diaryText = new System.Windows.Forms.TextBox();
            buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            analyzeButton = new AntdUI.Button();
            saveButton = new AntdUI.Button();
            clearButton = new AntdUI.Button();
            timelinePanel = new System.Windows.Forms.Panel();
            timelineGrid = new System.Windows.Forms.DataGridView();
            TimelineDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TimelineMood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TimelineAnxiety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TimelineDepression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            rightTabs = new System.Windows.Forms.TabControl();
            analysisTab = new System.Windows.Forms.TabPage();
            analysisLayout = new System.Windows.Forms.TableLayoutPanel();
            metricLayout = new System.Windows.Forms.TableLayoutPanel();
            anxietyCard = new AntdUI.Panel();
            anxietyProgress = new AntdUI.Progress();
            anxietyValueLabel = new System.Windows.Forms.Label();
            anxietyTitle = new System.Windows.Forms.Label();
            depressionCard = new AntdUI.Panel();
            depressionProgress = new AntdUI.Progress();
            depressionValueLabel = new System.Windows.Forms.Label();
            depressionTitle = new System.Windows.Forms.Label();
            insightCard = new AntdUI.Panel();
            insightText = new System.Windows.Forms.TextBox();
            insightTitle = new System.Windows.Forms.Label();
            suggestionCard = new AntdUI.Panel();
            suggestionList = new System.Windows.Forms.ListBox();
            suggestionTitle = new System.Windows.Forms.Label();
            actionCard = new AntdUI.Panel();
            actionList = new System.Windows.Forms.ListView();
            actionTitle = new System.Windows.Forms.Label();
            scheduleTab = new System.Windows.Forms.TabPage();
            scheduleLayout = new System.Windows.Forms.TableLayoutPanel();
            scheduleGrid = new System.Windows.Forms.DataGridView();
            ScheduleTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ScheduleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ScheduleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ScheduleRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            forecastPanel = new AntdUI.Panel();
            forecastList = new System.Windows.Forms.ListBox();
            forecastTitle = new System.Windows.Forms.Label();
            settingsTab = new System.Windows.Forms.TabPage();
            settingsLayout = new System.Windows.Forms.TableLayoutPanel();
            modelLabelTitle = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            baseUrlLabelTitle = new System.Windows.Forms.Label();
            baseUrlLabel = new System.Windows.Forms.Label();
            tuneLabelTitle = new System.Windows.Forms.Label();
            tuneLabel = new System.Windows.Forms.Label();
            gentleLabelTitle = new System.Windows.Forms.Label();
            gentleLabel = new System.Windows.Forms.Label();
            promptPreviewPanel = new AntdUI.Panel();
            outputPanel = new AntdUI.Panel();
            systemPromptPreview = new System.Windows.Forms.TextBox();
            outputPreview = new System.Windows.Forms.TextBox();
            promptLabel = new System.Windows.Forms.Label();
            outputLabel = new System.Windows.Forms.Label();
            openSettingsButton = new AntdUI.Button();
            mainLayout.SuspendLayout();
            headerBar.SuspendLayout();
            headerButtons.SuspendLayout();
            contentLayout.SuspendLayout();
            leftLayout.SuspendLayout();
            infoPanel.SuspendLayout();
            stateFlow.SuspendLayout();
            diaryPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            timelinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timelineGrid).BeginInit();
            rightTabs.SuspendLayout();
            analysisTab.SuspendLayout();
            analysisLayout.SuspendLayout();
            metricLayout.SuspendLayout();
            anxietyCard.SuspendLayout();
            depressionCard.SuspendLayout();
            insightCard.SuspendLayout();
            suggestionCard.SuspendLayout();
            actionCard.SuspendLayout();
            scheduleTab.SuspendLayout();
            scheduleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scheduleGrid).BeginInit();
            forecastPanel.SuspendLayout();
            settingsTab.SuspendLayout();
            settingsLayout.SuspendLayout();
            promptPreviewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerBar, 0, 0);
            mainLayout.Controls.Add(contentLayout, 0, 1);
            mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            mainLayout.Size = new System.Drawing.Size(1200, 780);
            // 
            // headerBar
            // 
            headerBar.Controls.Add(headerButtons);
            headerBar.Dock = System.Windows.Forms.DockStyle.Fill;
            headerBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            headerBar.LocalizationText = "青春心绪助理";
            headerBar.Name = "headerBar";
            headerBar.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            headerBar.Size = new System.Drawing.Size(1200, 70);
            headerBar.TabIndex = 0;
            headerBar.Text = "青春心绪助理";
            headerBar.UseTitleFont = true;
            // 
            // headerButtons
            // 
            headerButtons.Anchor = System.Windows.Forms.AnchorStyles.Right;
            headerButtons.AutoSize = true;
            headerButtons.Controls.Add(previewButton);
            headerButtons.Controls.Add(settingsButton);
            headerButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            headerButtons.Location = new System.Drawing.Point(980, 15);
            headerButtons.Name = "headerButtons";
            headerButtons.Size = new System.Drawing.Size(200, 40);
            // 
            // settingsButton
            // 
            settingsButton.AutoSizeMode = AntdUI.TAutoSize.Auto;
            settingsButton.Text = "设置";
            settingsButton.Type = AntdUI.TTypeMini.Primary;
            settingsButton.Margin = new System.Windows.Forms.Padding(5);
            settingsButton.Size = new System.Drawing.Size(90, 32);
            settingsButton.Click += settingsButton_Click;
            // 
            // previewButton
            // 
            previewButton.AutoSizeMode = AntdUI.TAutoSize.Auto;
            previewButton.Text = "预览本次 Prompt";
            previewButton.Margin = new System.Windows.Forms.Padding(5);
            previewButton.Size = new System.Drawing.Size(120, 32);
            previewButton.Click += previewButton_Click;
            // 
            // contentLayout
            // 
            contentLayout.ColumnCount = 2;
            contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            contentLayout.Controls.Add(leftLayout, 0, 0);
            contentLayout.Controls.Add(rightTabs, 1, 0);
            contentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            contentLayout.RowCount = 1;
            contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            contentLayout.Size = new System.Drawing.Size(1200, 710);
            // 
            // leftLayout
            // 
            leftLayout.ColumnCount = 1;
            leftLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            leftLayout.Controls.Add(infoPanel, 0, 0);
            leftLayout.Controls.Add(diaryPanel, 0, 1);
            leftLayout.Controls.Add(buttonPanel, 0, 2);
            leftLayout.Controls.Add(timelinePanel, 0, 3);
            leftLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            leftLayout.RowCount = 4;
            leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            leftLayout.Size = new System.Drawing.Size(474, 704);
            // 
            // infoPanel
            // 
            infoPanel.Controls.Add(stateFlow);
            infoPanel.Controls.Add(moodCombo);
            infoPanel.Controls.Add(datePicker);
            infoPanel.Controls.Add(moodLabel);
            infoPanel.Controls.Add(dateLabel);
            infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            infoPanel.Padding = new System.Windows.Forms.Padding(10);
            infoPanel.Size = new System.Drawing.Size(468, 164);
            // 
            // stateFlow
            // 
            stateFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            stateFlow.Controls.Add(chkStudy);
            stateFlow.Controls.Add(chkClub);
            stateFlow.Controls.Add(chkWork);
            stateFlow.Controls.Add(chkNight);
            stateFlow.Controls.Add(chkLove);
            stateFlow.Controls.Add(chkExam);
            stateFlow.Location = new System.Drawing.Point(14, 92);
            stateFlow.Name = "stateFlow";
            stateFlow.Size = new System.Drawing.Size(440, 60);
            stateFlow.WrapContents = true;
            // 
            // chkStudy
            // 
            chkStudy.AutoSize = true;
            chkStudy.Text = "上课中";
            chkStudy.Margin = new System.Windows.Forms.Padding(5);
            // 
            // chkClub
            // 
            chkClub.AutoSize = true;
            chkClub.Text = "社团繁忙";
            chkClub.Margin = new System.Windows.Forms.Padding(5);
            // 
            // chkWork
            // 
            chkWork.AutoSize = true;
            chkWork.Text = "打工中";
            chkWork.Margin = new System.Windows.Forms.Padding(5);
            // 
            // chkNight
            // 
            chkNight.AutoSize = true;
            chkNight.Text = "熬夜";
            chkNight.Margin = new System.Windows.Forms.Padding(5);
            // 
            // chkLove
            // 
            chkLove.AutoSize = true;
            chkLove.Text = "恋爱中";
            chkLove.Margin = new System.Windows.Forms.Padding(5);
            // 
            // chkExam
            // 
            chkExam.AutoSize = true;
            chkExam.Text = "准备考试";
            chkExam.Margin = new System.Windows.Forms.Padding(5);
            // 
            // moodCombo
            // 
            moodCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            moodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            moodCombo.Items.AddRange(new object[] { "很开心", "平静", "有点焦虑", "压力大", "很低落" });
            moodCombo.Location = new System.Drawing.Point(90, 52);
            moodCombo.Name = "moodCombo";
            moodCombo.Size = new System.Drawing.Size(364, 25);
            // 
            // datePicker
            // 
            datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            datePicker.Location = new System.Drawing.Point(90, 16);
            datePicker.Name = "datePicker";
            datePicker.Size = new System.Drawing.Size(364, 23);
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // moodLabel
            // 
            moodLabel.AutoSize = true;
            moodLabel.Location = new System.Drawing.Point(14, 55);
            moodLabel.Name = "moodLabel";
            moodLabel.Size = new System.Drawing.Size(68, 17);
            moodLabel.Text = "今日心情";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(14, 19);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(68, 17);
            dateLabel.Text = "选择日期";
            // 
            // diaryPanel
            // 
            diaryPanel.Controls.Add(diaryText);
            diaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            diaryPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            diaryPanel.Size = new System.Drawing.Size(468, 300);
            // 
            // diaryText
            // 
            diaryText.Dock = System.Windows.Forms.DockStyle.Fill;
            diaryText.Multiline = true;
            diaryText.PlaceholderText = "写下你今天的所思所想、发生的事情与心情变化……";
            diaryText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            diaryText.Size = new System.Drawing.Size(448, 300);
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(analyzeButton);
            buttonPanel.Controls.Add(saveButton);
            buttonPanel.Controls.Add(clearButton);
            buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            buttonPanel.Padding = new System.Windows.Forms.Padding(10);
            buttonPanel.Size = new System.Drawing.Size(468, 54);
            // 
            // analyzeButton
            // 
            analyzeButton.AutoSizeMode = AntdUI.TAutoSize.Auto;
            analyzeButton.Text = "生成情绪画像";
            analyzeButton.Type = AntdUI.TTypeMini.Primary;
            analyzeButton.Margin = new System.Windows.Forms.Padding(5);
            analyzeButton.Size = new System.Drawing.Size(120, 32);
            analyzeButton.Click += analyzeButton_Click;
            // 
            // saveButton
            // 
            saveButton.AutoSizeMode = AntdUI.TAutoSize.Auto;
            saveButton.Text = "保存到时间线";
            saveButton.Margin = new System.Windows.Forms.Padding(5);
            saveButton.Size = new System.Drawing.Size(120, 32);
            saveButton.Click += saveButton_Click;
            // 
            // clearButton
            // 
            clearButton.AutoSizeMode = AntdUI.TAutoSize.Auto;
            clearButton.Text = "清空当前日记";
            clearButton.Margin = new System.Windows.Forms.Padding(5);
            clearButton.Size = new System.Drawing.Size(120, 32);
            clearButton.Click += clearButton_Click;
            // 
            // timelinePanel
            // 
            timelinePanel.Controls.Add(timelineGrid);
            timelinePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            timelinePanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            timelinePanel.Size = new System.Drawing.Size(468, 174);
            // 
            // timelineGrid
            // 
            timelineGrid.AllowUserToAddRows = false;
            timelineGrid.AllowUserToDeleteRows = false;
            timelineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            timelineGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { TimelineDate, TimelineMood, TimelineAnxiety, TimelineDepression });
            timelineGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            timelineGrid.MultiSelect = false;
            timelineGrid.ReadOnly = true;
            timelineGrid.RowHeadersVisible = false;
            timelineGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            timelineGrid.CellDoubleClick += timelineGrid_CellDoubleClick;
            timelineGrid.Size = new System.Drawing.Size(448, 164);
            // 
            // TimelineDate
            // 
            TimelineDate.HeaderText = "日期";
            TimelineDate.Name = "TimelineDate";
            TimelineDate.ReadOnly = true;
            // 
            // TimelineMood
            // 
            TimelineMood.HeaderText = "心情";
            TimelineMood.Name = "TimelineMood";
            TimelineMood.ReadOnly = true;
            // 
            // TimelineAnxiety
            // 
            TimelineAnxiety.HeaderText = "焦虑指数";
            TimelineAnxiety.Name = "TimelineAnxiety";
            TimelineAnxiety.ReadOnly = true;
            // 
            // TimelineDepression
            // 
            TimelineDepression.HeaderText = "抑郁指数";
            TimelineDepression.Name = "TimelineDepression";
            TimelineDepression.ReadOnly = true;
            // 
            // rightTabs
            // 
            rightTabs.Controls.Add(analysisTab);
            rightTabs.Controls.Add(scheduleTab);
            rightTabs.Controls.Add(settingsTab);
            rightTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            rightTabs.Size = new System.Drawing.Size(718, 704);
            // 
            // analysisTab
            // 
            analysisTab.Controls.Add(analysisLayout);
            analysisTab.Location = new System.Drawing.Point(4, 26);
            analysisTab.Name = "analysisTab";
            analysisTab.Padding = new System.Windows.Forms.Padding(10);
            analysisTab.Size = new System.Drawing.Size(710, 674);
            analysisTab.Text = "情绪分析";
            analysisTab.UseVisualStyleBackColor = true;
            // 
            // analysisLayout
            // 
            analysisLayout.ColumnCount = 1;
            analysisLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            analysisLayout.Controls.Add(metricLayout, 0, 0);
            analysisLayout.Controls.Add(insightCard, 0, 1);
            analysisLayout.Controls.Add(suggestionCard, 0, 2);
            analysisLayout.Controls.Add(actionCard, 0, 3);
            analysisLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            analysisLayout.RowCount = 4;
            analysisLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            analysisLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            analysisLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            analysisLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            // 
            // metricLayout
            // 
            metricLayout.ColumnCount = 2;
            metricLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            metricLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            metricLayout.Controls.Add(anxietyCard, 0, 0);
            metricLayout.Controls.Add(depressionCard, 1, 0);
            metricLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // anxietyCard
            // 
            anxietyCard.Controls.Add(anxietyProgress);
            anxietyCard.Controls.Add(anxietyValueLabel);
            anxietyCard.Controls.Add(anxietyTitle);
            anxietyCard.Dock = System.Windows.Forms.DockStyle.Fill;
            anxietyCard.Padding = new System.Windows.Forms.Padding(10);
            // 
            // anxietyProgress
            // 
            anxietyProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            anxietyProgress.Location = new System.Drawing.Point(10, 94);
            anxietyProgress.Name = "anxietyProgress";
            anxietyProgress.Size = new System.Drawing.Size(325, 24);
            anxietyProgress.Value = 0F;
            // 
            // anxietyValueLabel
            // 
            anxietyValueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            anxietyValueLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            anxietyValueLabel.Location = new System.Drawing.Point(10, 40);
            anxietyValueLabel.Name = "anxietyValueLabel";
            anxietyValueLabel.Size = new System.Drawing.Size(325, 44);
            anxietyValueLabel.Text = "--";
            anxietyValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // anxietyTitle
            // 
            anxietyTitle.AutoSize = true;
            anxietyTitle.Dock = System.Windows.Forms.DockStyle.Top;
            anxietyTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            anxietyTitle.Location = new System.Drawing.Point(10, 10);
            anxietyTitle.Name = "anxietyTitle";
            anxietyTitle.Size = new System.Drawing.Size(69, 20);
            anxietyTitle.Text = "焦虑指数";
            // 
            // depressionCard
            // 
            depressionCard.Controls.Add(depressionProgress);
            depressionCard.Controls.Add(depressionValueLabel);
            depressionCard.Controls.Add(depressionTitle);
            depressionCard.Dock = System.Windows.Forms.DockStyle.Fill;
            depressionCard.Padding = new System.Windows.Forms.Padding(10);
            // 
            // depressionProgress
            // 
            depressionProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            depressionProgress.Location = new System.Drawing.Point(10, 94);
            depressionProgress.Name = "depressionProgress";
            depressionProgress.Size = new System.Drawing.Size(325, 24);
            depressionProgress.Value = 0F;
            // 
            // depressionValueLabel
            // 
            depressionValueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            depressionValueLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            depressionValueLabel.Location = new System.Drawing.Point(10, 40);
            depressionValueLabel.Name = "depressionValueLabel";
            depressionValueLabel.Size = new System.Drawing.Size(325, 44);
            depressionValueLabel.Text = "--";
            depressionValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // depressionTitle
            // 
            depressionTitle.AutoSize = true;
            depressionTitle.Dock = System.Windows.Forms.DockStyle.Top;
            depressionTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            depressionTitle.Location = new System.Drawing.Point(10, 10);
            depressionTitle.Name = "depressionTitle";
            depressionTitle.Size = new System.Drawing.Size(69, 20);
            depressionTitle.Text = "抑郁指数";
            // 
            // insightCard
            // 
            insightCard.Controls.Add(insightText);
            insightCard.Controls.Add(insightTitle);
            insightCard.Dock = System.Windows.Forms.DockStyle.Fill;
            insightCard.Padding = new System.Windows.Forms.Padding(10);
            // 
            // insightText
            // 
            insightText.Dock = System.Windows.Forms.DockStyle.Fill;
            insightText.Multiline = true;
            insightText.ReadOnly = true;
            insightText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            insightText.Size = new System.Drawing.Size(684, 122);
            // 
            // insightTitle
            // 
            insightTitle.AutoSize = true;
            insightTitle.Dock = System.Windows.Forms.DockStyle.Top;
            insightTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            insightTitle.Location = new System.Drawing.Point(10, 10);
            insightTitle.Name = "insightTitle";
            insightTitle.Size = new System.Drawing.Size(69, 20);
            insightTitle.Text = "情绪洞察";
            // 
            // suggestionCard
            // 
            suggestionCard.Controls.Add(suggestionList);
            suggestionCard.Controls.Add(suggestionTitle);
            suggestionCard.Dock = System.Windows.Forms.DockStyle.Fill;
            suggestionCard.Padding = new System.Windows.Forms.Padding(10);
            // 
            // suggestionList
            // 
            suggestionList.Dock = System.Windows.Forms.DockStyle.Fill;
            suggestionList.ItemHeight = 17;
            suggestionList.Size = new System.Drawing.Size(684, 122);
            // 
            // suggestionTitle
            // 
            suggestionTitle.AutoSize = true;
            suggestionTitle.Dock = System.Windows.Forms.DockStyle.Top;
            suggestionTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            suggestionTitle.Location = new System.Drawing.Point(10, 10);
            suggestionTitle.Name = "suggestionTitle";
            suggestionTitle.Size = new System.Drawing.Size(119, 20);
            suggestionTitle.Text = "学习与生活建议";
            // 
            // actionCard
            // 
            actionCard.Controls.Add(actionList);
            actionCard.Controls.Add(actionTitle);
            actionCard.Dock = System.Windows.Forms.DockStyle.Fill;
            actionCard.Padding = new System.Windows.Forms.Padding(10);
            // 
            // actionList
            // 
            actionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { actionTitleColumn, actionDueColumn });
            actionList.Dock = System.Windows.Forms.DockStyle.Fill;
            actionList.FullRowSelect = true;
            actionList.GridLines = true;
            actionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            actionList.Location = new System.Drawing.Point(10, 30);
            actionList.Name = "actionList";
            actionList.Size = new System.Drawing.Size(684, 172);
            actionList.View = System.Windows.Forms.View.Details;
            // 
            // actionTitle
            // 
            actionTitle.AutoSize = true;
            actionTitle.Dock = System.Windows.Forms.DockStyle.Top;
            actionTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            actionTitle.Location = new System.Drawing.Point(10, 10);
            actionTitle.Name = "actionTitle";
            actionTitle.Size = new System.Drawing.Size(119, 20);
            actionTitle.Text = "行动卡片 / To-do";
            // 
            // scheduleTab
            // 
            scheduleTab.Controls.Add(scheduleLayout);
            scheduleTab.Location = new System.Drawing.Point(4, 26);
            scheduleTab.Name = "scheduleTab";
            scheduleTab.Padding = new System.Windows.Forms.Padding(10);
            scheduleTab.Size = new System.Drawing.Size(710, 674);
            scheduleTab.Text = "课程与 Deadline 提醒";
            scheduleTab.UseVisualStyleBackColor = true;
            // 
            // scheduleLayout
            // 
            scheduleLayout.ColumnCount = 1;
            scheduleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            scheduleLayout.Controls.Add(scheduleGrid, 0, 0);
            scheduleLayout.Controls.Add(forecastPanel, 0, 1);
            scheduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            scheduleLayout.RowCount = 2;
            scheduleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            scheduleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            // 
            // scheduleGrid
            // 
            scheduleGrid.AllowUserToAddRows = false;
            scheduleGrid.AllowUserToDeleteRows = false;
            scheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scheduleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ScheduleTitle, ScheduleTime, ScheduleType, ScheduleRemark });
            scheduleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            scheduleGrid.RowHeadersVisible = false;
            scheduleGrid.Size = new System.Drawing.Size(694, 458);
            // 
            // ScheduleTitle
            // 
            ScheduleTitle.HeaderText = "标题";
            ScheduleTitle.Name = "ScheduleTitle";
            ScheduleTitle.ReadOnly = true;
            // 
            // ScheduleTime
            // 
            ScheduleTime.HeaderText = "时间";
            ScheduleTime.Name = "ScheduleTime";
            ScheduleTime.ReadOnly = true;
            // 
            // ScheduleType
            // 
            ScheduleType.HeaderText = "类型";
            ScheduleType.Name = "ScheduleType";
            ScheduleType.ReadOnly = true;
            // 
            // ScheduleRemark
            // 
            ScheduleRemark.HeaderText = "备注";
            ScheduleRemark.Name = "ScheduleRemark";
            ScheduleRemark.ReadOnly = true;
            // 
            // forecastPanel
            // 
            forecastPanel.Controls.Add(forecastList);
            forecastPanel.Controls.Add(forecastTitle);
            forecastPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            forecastPanel.Padding = new System.Windows.Forms.Padding(10);
            // 
            // forecastList
            // 
            forecastList.Dock = System.Windows.Forms.DockStyle.Fill;
            forecastList.ItemHeight = 17;
            forecastList.Size = new System.Drawing.Size(674, 172);
            // 
            // forecastTitle
            // 
            forecastTitle.AutoSize = true;
            forecastTitle.Dock = System.Windows.Forms.DockStyle.Top;
            forecastTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            forecastTitle.Location = new System.Drawing.Point(10, 10);
            forecastTitle.Name = "forecastTitle";
            forecastTitle.Size = new System.Drawing.Size(137, 20);
            forecastTitle.Text = "未来 7 天压力预报";
            // 
            // settingsTab
            // 
            settingsTab.Controls.Add(settingsLayout);
            settingsTab.Location = new System.Drawing.Point(4, 26);
            settingsTab.Name = "settingsTab";
            settingsTab.Padding = new System.Windows.Forms.Padding(10);
            settingsTab.Size = new System.Drawing.Size(710, 674);
            settingsTab.Text = "设置预览";
            settingsTab.UseVisualStyleBackColor = true;
            // 
            // settingsLayout
            // 
            settingsLayout.ColumnCount = 2;
            settingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            settingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            settingsLayout.Controls.Add(modelLabelTitle, 0, 0);
            settingsLayout.Controls.Add(modelLabel, 1, 0);
            settingsLayout.Controls.Add(baseUrlLabelTitle, 0, 1);
            settingsLayout.Controls.Add(baseUrlLabel, 1, 1);
            settingsLayout.Controls.Add(tuneLabelTitle, 0, 2);
            settingsLayout.Controls.Add(tuneLabel, 1, 2);
            settingsLayout.Controls.Add(gentleLabelTitle, 0, 3);
            settingsLayout.Controls.Add(gentleLabel, 1, 3);
            settingsLayout.Controls.Add(promptPreviewPanel, 0, 4);
            settingsLayout.Controls.Add(outputPanel, 0, 5);
            settingsLayout.Controls.Add(openSettingsButton, 1, 6);
            settingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            settingsLayout.RowCount = 7;
            settingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            settingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            settingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            settingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            settingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            settingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            settingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            // 
            // modelLabelTitle
            // 
            modelLabelTitle.AutoSize = true;
            modelLabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            modelLabelTitle.Text = "模型";
            modelLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baseUrlLabelTitle
            // 
            baseUrlLabelTitle.AutoSize = true;
            baseUrlLabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            baseUrlLabelTitle.Text = "BaseUrl";
            baseUrlLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baseUrlLabel
            // 
            baseUrlLabel.AutoSize = true;
            baseUrlLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            baseUrlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tuneLabelTitle
            // 
            tuneLabelTitle.AutoSize = true;
            tuneLabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            tuneLabelTitle.Text = "课程调优";
            tuneLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tuneLabel
            // 
            tuneLabel.AutoSize = true;
            tuneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            tuneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gentleLabelTitle
            // 
            gentleLabelTitle.AutoSize = true;
            gentleLabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            gentleLabelTitle.Text = "温柔语气";
            gentleLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gentleLabel
            // 
            gentleLabel.AutoSize = true;
            gentleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            gentleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // promptPreviewPanel
            // 
            settingsLayout.SetColumnSpan(promptPreviewPanel, 2);
            promptPreviewPanel.Controls.Add(systemPromptPreview);
            promptPreviewPanel.Controls.Add(promptLabel);
            promptPreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            promptPreviewPanel.Padding = new System.Windows.Forms.Padding(5);
            // 
            // outputPanel
            // 
            settingsLayout.SetColumnSpan(outputPanel, 2);
            outputPanel.Controls.Add(outputLabel);
            outputPanel.Controls.Add(outputPreview);
            outputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            outputPanel.Padding = new System.Windows.Forms.Padding(5);
            // 
            // systemPromptPreview
            // 
            systemPromptPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            systemPromptPreview.Multiline = true;
            systemPromptPreview.ReadOnly = true;
            systemPromptPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            systemPromptPreview.Size = new System.Drawing.Size(700, 140);
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.Dock = System.Windows.Forms.DockStyle.Top;
            promptLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            promptLabel.Location = new System.Drawing.Point(5, 5);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new System.Drawing.Size(80, 20);
            promptLabel.Text = "系统提示词";
            // 
            // outputPreview
            // 
            settingsLayout.SetColumnSpan(outputPreview, 2);
            outputPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            outputPreview.Multiline = true;
            outputPreview.ReadOnly = true;
            outputPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            outputPreview.Size = new System.Drawing.Size(700, 140);
            // 
            // openSettingsButton
            // 
            openSettingsButton.AutoSizeMode = AntdUI.TAutoSize.Auto;
            openSettingsButton.Text = "打开详细设置";
            openSettingsButton.Type = AntdUI.TTypeMini.Primary;
            openSettingsButton.Margin = new System.Windows.Forms.Padding(5);
            openSettingsButton.Size = new System.Drawing.Size(140, 34);
            openSettingsButton.Click += settingsButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            outputLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            outputLabel.Location = new System.Drawing.Point(5, 5);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new System.Drawing.Size(119, 20);
            outputLabel.Text = "JSON 输出模板";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 780);
            Controls.Add(mainLayout);
            Text = "青春心绪助理";
            mainLayout.ResumeLayout(false);
            headerBar.ResumeLayout(false);
            headerBar.PerformLayout();
            headerButtons.ResumeLayout(false);
            contentLayout.ResumeLayout(false);
            leftLayout.ResumeLayout(false);
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            stateFlow.ResumeLayout(false);
            stateFlow.PerformLayout();
            diaryPanel.ResumeLayout(false);
            diaryPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            timelinePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)timelineGrid).EndInit();
            rightTabs.ResumeLayout(false);
            analysisTab.ResumeLayout(false);
            analysisLayout.ResumeLayout(false);
            metricLayout.ResumeLayout(false);
            anxietyCard.ResumeLayout(false);
            anxietyCard.PerformLayout();
            depressionCard.ResumeLayout(false);
            depressionCard.PerformLayout();
            insightCard.ResumeLayout(false);
            insightCard.PerformLayout();
            suggestionCard.ResumeLayout(false);
            suggestionCard.PerformLayout();
            actionCard.ResumeLayout(false);
            actionCard.PerformLayout();
            scheduleTab.ResumeLayout(false);
            scheduleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scheduleGrid).EndInit();
            forecastPanel.ResumeLayout(false);
            forecastPanel.PerformLayout();
            settingsTab.ResumeLayout(false);
            settingsLayout.ResumeLayout(false);
            settingsLayout.PerformLayout();
            promptPreviewPanel.ResumeLayout(false);
            promptPreviewPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private AntdUI.PageHeader headerBar;
        private System.Windows.Forms.FlowLayoutPanel headerButtons;
        private AntdUI.Button settingsButton;
        private AntdUI.Button previewButton;
        private System.Windows.Forms.TableLayoutPanel contentLayout;
        private System.Windows.Forms.TableLayoutPanel leftLayout;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.FlowLayoutPanel stateFlow;
        private System.Windows.Forms.CheckBox chkStudy;
        private System.Windows.Forms.CheckBox chkClub;
        private System.Windows.Forms.CheckBox chkWork;
        private System.Windows.Forms.CheckBox chkNight;
        private System.Windows.Forms.CheckBox chkLove;
        private System.Windows.Forms.CheckBox chkExam;
        private System.Windows.Forms.ComboBox moodCombo;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label moodLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Panel diaryPanel;
        private System.Windows.Forms.TextBox diaryText;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private AntdUI.Button analyzeButton;
        private AntdUI.Button saveButton;
        private AntdUI.Button clearButton;
        private System.Windows.Forms.Panel timelinePanel;
        private System.Windows.Forms.DataGridView timelineGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimelineDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimelineMood;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimelineAnxiety;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimelineDepression;
        private System.Windows.Forms.TabControl rightTabs;
        private System.Windows.Forms.TabPage analysisTab;
        private System.Windows.Forms.TableLayoutPanel analysisLayout;
        private System.Windows.Forms.TableLayoutPanel metricLayout;
        private AntdUI.Panel anxietyCard;
        private AntdUI.Progress anxietyProgress;
        private System.Windows.Forms.Label anxietyValueLabel;
        private System.Windows.Forms.Label anxietyTitle;
        private AntdUI.Panel depressionCard;
        private AntdUI.Progress depressionProgress;
        private System.Windows.Forms.Label depressionValueLabel;
        private System.Windows.Forms.Label depressionTitle;
        private AntdUI.Panel insightCard;
        private System.Windows.Forms.TextBox insightText;
        private System.Windows.Forms.Label insightTitle;
        private AntdUI.Panel suggestionCard;
        private System.Windows.Forms.ListBox suggestionList;
        private System.Windows.Forms.Label suggestionTitle;
        private AntdUI.Panel actionCard;
        private System.Windows.Forms.ListView actionList;
        private System.Windows.Forms.ColumnHeader actionTitleColumn = new System.Windows.Forms.ColumnHeader { Text = "任务" , Width = 420};
        private System.Windows.Forms.ColumnHeader actionDueColumn = new System.Windows.Forms.ColumnHeader { Text = "建议完成时间", Width = 200};
        private System.Windows.Forms.Label actionTitle;
        private System.Windows.Forms.TabPage scheduleTab;
        private System.Windows.Forms.TableLayoutPanel scheduleLayout;
        private System.Windows.Forms.DataGridView scheduleGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleRemark;
        private AntdUI.Panel forecastPanel;
        private System.Windows.Forms.ListBox forecastList;
        private System.Windows.Forms.Label forecastTitle;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.TableLayoutPanel settingsLayout;
        private System.Windows.Forms.Label modelLabelTitle;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label baseUrlLabelTitle;
        private System.Windows.Forms.Label baseUrlLabel;
        private System.Windows.Forms.Label tuneLabelTitle;
        private System.Windows.Forms.Label tuneLabel;
        private System.Windows.Forms.Label gentleLabelTitle;
        private System.Windows.Forms.Label gentleLabel;
        private AntdUI.Panel promptPreviewPanel;
        private AntdUI.Panel outputPanel;
        private System.Windows.Forms.TextBox systemPromptPreview;
        private System.Windows.Forms.TextBox outputPreview;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label outputLabel;
        private AntdUI.Button openSettingsButton;
    }
}
