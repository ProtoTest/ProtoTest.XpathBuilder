namespace ProtoTest.Specter
{
    partial class XpathBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RegisterRightClickButton = new System.Windows.Forms.Button();
            this.RegisterClickEventButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.WebDriverCommandText = new System.Windows.Forms.TextBox();
            this.WebDriverCommandDropdown = new System.Windows.Forms.ComboBox();
            this.MinimumXpathsTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ExecuteCommandButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.XpathsDropdown = new System.Windows.Forms.ComboBox();
            this.ElementPanel = new System.Windows.Forms.Panel();
            this.WebText = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.GetClickedElementButton = new System.Windows.Forms.Button();
            this.GetElementButton = new System.Windows.Forms.Button();
            this.GetParentButton = new System.Windows.Forms.Button();
            this.HighlightElementButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.XPathGeneratorMaxAttempts = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SelectedXpathTextBox = new System.Windows.Forms.TextBox();
            this.XpathPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CommandPanel = new System.Windows.Forms.Panel();
            this.GoToUrlButton = new System.Windows.Forms.Button();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BrowserPanel = new System.Windows.Forms.Panel();
            this.LaunchBrowserButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.BrowserDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.JavascriptPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.DisableOnClickButton = new System.Windows.Forms.Button();
            this.DisableMouseOverButton = new System.Windows.Forms.Button();
            this.ExecuteJS = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.JavscriptTextBox = new System.Windows.Forms.TextBox();
            this.HidePanelButton = new System.Windows.Forms.Button();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RecordingPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ElementPanel.SuspendLayout();
            this.XpathPanel.SuspendLayout();
            this.CommandPanel.SuspendLayout();
            this.BrowserPanel.SuspendLayout();
            this.JavascriptPanel.SuspendLayout();
            this.LogPanel.SuspendLayout();
            this.RecordingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterRightClickButton
            // 
            this.RegisterRightClickButton.Location = new System.Drawing.Point(119, 7);
            this.RegisterRightClickButton.Name = "RegisterRightClickButton";
            this.RegisterRightClickButton.Size = new System.Drawing.Size(141, 23);
            this.RegisterRightClickButton.TabIndex = 15;
            this.RegisterRightClickButton.Text = "RecordRightClick";
            this.RegisterRightClickButton.UseVisualStyleBackColor = true;
            this.RegisterRightClickButton.Click += new System.EventHandler(this.RegisterRightClickButton_Click);
            // 
            // RegisterClickEventButton
            // 
            this.RegisterClickEventButton.Location = new System.Drawing.Point(277, 7);
            this.RegisterClickEventButton.Name = "RegisterClickEventButton";
            this.RegisterClickEventButton.Size = new System.Drawing.Size(141, 23);
            this.RegisterClickEventButton.TabIndex = 8;
            this.RegisterClickEventButton.Text = "RecordLeftClick";
            this.RegisterClickEventButton.UseVisualStyleBackColor = true;
            this.RegisterClickEventButton.Click += new System.EventHandler(this.RegisterClickEventButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Text:";
            // 
            // WebDriverCommandText
            // 
            this.WebDriverCommandText.Location = new System.Drawing.Point(474, 6);
            this.WebDriverCommandText.Name = "WebDriverCommandText";
            this.WebDriverCommandText.Size = new System.Drawing.Size(242, 22);
            this.WebDriverCommandText.TabIndex = 20;
            this.WebDriverCommandText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // WebDriverCommandDropdown
            // 
            this.WebDriverCommandDropdown.DisplayMember = "1";
            this.WebDriverCommandDropdown.FormattingEnabled = true;
            this.WebDriverCommandDropdown.Items.AddRange(new object[] {
            "Highlight",
            "Click",
            "MouseOver",
            "Type",
            "ClickOffSet"});
            this.WebDriverCommandDropdown.Location = new System.Drawing.Point(140, 7);
            this.WebDriverCommandDropdown.Name = "WebDriverCommandDropdown";
            this.WebDriverCommandDropdown.Size = new System.Drawing.Size(163, 24);
            this.WebDriverCommandDropdown.TabIndex = 19;
            this.WebDriverCommandDropdown.SelectedIndexChanged += new System.EventHandler(this.WebDriverCommandDropdown_SelectedIndexChanged);
            // 
            // MinimumXpathsTextBox
            // 
            this.MinimumXpathsTextBox.Location = new System.Drawing.Point(536, 13);
            this.MinimumXpathsTextBox.Name = "MinimumXpathsTextBox";
            this.MinimumXpathsTextBox.Size = new System.Drawing.Size(38, 22);
            this.MinimumXpathsTextBox.TabIndex = 17;
            this.MinimumXpathsTextBox.Text = "3";
            this.MinimumXpathsTextBox.TextChanged += new System.EventHandler(this.MinimumXpathsTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Minimum";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ExecuteCommandButton
            // 
            this.ExecuteCommandButton.Location = new System.Drawing.Point(312, 6);
            this.ExecuteCommandButton.Name = "ExecuteCommandButton";
            this.ExecuteCommandButton.Size = new System.Drawing.Size(83, 23);
            this.ExecuteCommandButton.TabIndex = 4;
            this.ExecuteCommandButton.Text = "Execute";
            this.ExecuteCommandButton.UseVisualStyleBackColor = true;
            this.ExecuteCommandButton.Click += new System.EventHandler(this.ClickXpathButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "XPath Generator";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "GenerateFromElement";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GenerateXpathButton_Click);
            // 
            // XpathsDropdown
            // 
            this.XpathsDropdown.FormattingEnabled = true;
            this.XpathsDropdown.Location = new System.Drawing.Point(9, 41);
            this.XpathsDropdown.Name = "XpathsDropdown";
            this.XpathsDropdown.Size = new System.Drawing.Size(704, 24);
            this.XpathsDropdown.TabIndex = 0;
            this.XpathsDropdown.SelectedIndexChanged += new System.EventHandler(this.XpathsDropdown_SelectedIndexChanged);
            // 
            // ElementPanel
            // 
            this.ElementPanel.BackColor = System.Drawing.Color.DimGray;
            this.ElementPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ElementPanel.Controls.Add(this.WebText);
            this.ElementPanel.Controls.Add(this.label1);
            this.ElementPanel.Controls.Add(this.GetClickedElementButton);
            this.ElementPanel.Controls.Add(this.GetElementButton);
            this.ElementPanel.Controls.Add(this.GetParentButton);
            this.ElementPanel.Controls.Add(this.HighlightElementButton);
            this.ElementPanel.Location = new System.Drawing.Point(736, 12);
            this.ElementPanel.Name = "ElementPanel";
            this.ElementPanel.Size = new System.Drawing.Size(728, 220);
            this.ElementPanel.TabIndex = 5;
            // 
            // WebText
            // 
            this.WebText.Location = new System.Drawing.Point(7, 39);
            this.WebText.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebText.Name = "WebText";
            this.WebText.Size = new System.Drawing.Size(706, 176);
            this.WebText.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Element";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // GetClickedElementButton
            // 
            this.GetClickedElementButton.Location = new System.Drawing.Point(323, 7);
            this.GetClickedElementButton.Name = "GetClickedElementButton";
            this.GetClickedElementButton.Size = new System.Drawing.Size(127, 23);
            this.GetClickedElementButton.TabIndex = 7;
            this.GetClickedElementButton.Text = "FindLastClicked";
            this.GetClickedElementButton.UseVisualStyleBackColor = true;
            this.GetClickedElementButton.Click += new System.EventHandler(this.GetClickedElementButton_Click);
            // 
            // GetElementButton
            // 
            this.GetElementButton.Location = new System.Drawing.Point(456, 7);
            this.GetElementButton.Name = "GetElementButton";
            this.GetElementButton.Size = new System.Drawing.Size(120, 23);
            this.GetElementButton.TabIndex = 16;
            this.GetElementButton.Text = "FindFromXpath";
            this.GetElementButton.UseVisualStyleBackColor = true;
            this.GetElementButton.Click += new System.EventHandler(this.GetElementButton_Click);
            // 
            // GetParentButton
            // 
            this.GetParentButton.Location = new System.Drawing.Point(582, 7);
            this.GetParentButton.Name = "GetParentButton";
            this.GetParentButton.Size = new System.Drawing.Size(92, 23);
            this.GetParentButton.TabIndex = 10;
            this.GetParentButton.Text = "FindParent";
            this.GetParentButton.UseVisualStyleBackColor = true;
            this.GetParentButton.Click += new System.EventHandler(this.GetParentButton_Click);
            // 
            // HighlightElementButton
            // 
            this.HighlightElementButton.Location = new System.Drawing.Point(1158, 7);
            this.HighlightElementButton.Name = "HighlightElementButton";
            this.HighlightElementButton.Size = new System.Drawing.Size(85, 23);
            this.HighlightElementButton.TabIndex = 2;
            this.HighlightElementButton.Text = "Highlight";
            this.HighlightElementButton.UseVisualStyleBackColor = true;
            this.HighlightElementButton.Click += new System.EventHandler(this.HighlightElementButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(576, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Max Attempts";
            // 
            // XPathGeneratorMaxAttempts
            // 
            this.XPathGeneratorMaxAttempts.Location = new System.Drawing.Point(674, 12);
            this.XPathGeneratorMaxAttempts.Name = "XPathGeneratorMaxAttempts";
            this.XPathGeneratorMaxAttempts.Size = new System.Drawing.Size(39, 22);
            this.XPathGeneratorMaxAttempts.TabIndex = 26;
            this.XPathGeneratorMaxAttempts.Text = "100";
            this.XPathGeneratorMaxAttempts.TextChanged += new System.EventHandler(this.XPathGeneratorMaxAttempts_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Command Executor";
            // 
            // SelectedXpathTextBox
            // 
            this.SelectedXpathTextBox.Location = new System.Drawing.Point(5, 43);
            this.SelectedXpathTextBox.Name = "SelectedXpathTextBox";
            this.SelectedXpathTextBox.Size = new System.Drawing.Size(710, 22);
            this.SelectedXpathTextBox.TabIndex = 28;
            this.SelectedXpathTextBox.TextChanged += new System.EventHandler(this.SelectedXpathTextBox_TextChanged);
            // 
            // XpathPanel
            // 
            this.XpathPanel.BackColor = System.Drawing.Color.DimGray;
            this.XpathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XpathPanel.Controls.Add(this.button1);
            this.XpathPanel.Controls.Add(this.button3);
            this.XpathPanel.Controls.Add(this.XpathsDropdown);
            this.XpathPanel.Controls.Add(this.XPathGeneratorMaxAttempts);
            this.XpathPanel.Controls.Add(this.label4);
            this.XpathPanel.Controls.Add(this.label13);
            this.XpathPanel.Controls.Add(this.label8);
            this.XpathPanel.Controls.Add(this.MinimumXpathsTextBox);
            this.XpathPanel.Location = new System.Drawing.Point(736, 238);
            this.XpathPanel.Name = "XpathPanel";
            this.XpathPanel.Size = new System.Drawing.Size(728, 85);
            this.XpathPanel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Generate From Xpath";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CommandPanel
            // 
            this.CommandPanel.BackColor = System.Drawing.Color.DimGray;
            this.CommandPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommandPanel.Controls.Add(this.SelectedXpathTextBox);
            this.CommandPanel.Controls.Add(this.label14);
            this.CommandPanel.Controls.Add(this.ExecuteCommandButton);
            this.CommandPanel.Controls.Add(this.WebDriverCommandDropdown);
            this.CommandPanel.Controls.Add(this.WebDriverCommandText);
            this.CommandPanel.Controls.Add(this.label9);
            this.CommandPanel.Location = new System.Drawing.Point(4, 238);
            this.CommandPanel.Name = "CommandPanel";
            this.CommandPanel.Size = new System.Drawing.Size(727, 85);
            this.CommandPanel.TabIndex = 8;
            // 
            // GoToUrlButton
            // 
            this.GoToUrlButton.Location = new System.Drawing.Point(520, 42);
            this.GoToUrlButton.Name = "GoToUrlButton";
            this.GoToUrlButton.Size = new System.Drawing.Size(95, 23);
            this.GoToUrlButton.TabIndex = 14;
            this.GoToUrlButton.Text = "GoToUrl";
            this.GoToUrlButton.UseVisualStyleBackColor = true;
            this.GoToUrlButton.Click += new System.EventHandler(this.GoToUrlButton_Click);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(74, 42);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(440, 22);
            this.UrlTextBox.TabIndex = 13;
            this.UrlTextBox.TextChanged += new System.EventHandler(this.UrlTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "URL";
            // 
            // BrowserPanel
            // 
            this.BrowserPanel.AutoSize = true;
            this.BrowserPanel.BackColor = System.Drawing.Color.DimGray;
            this.BrowserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrowserPanel.Controls.Add(this.GoToUrlButton);
            this.BrowserPanel.Controls.Add(this.LaunchBrowserButton);
            this.BrowserPanel.Controls.Add(this.label3);
            this.BrowserPanel.Controls.Add(this.UrlTextBox);
            this.BrowserPanel.Controls.Add(this.HostTextBox);
            this.BrowserPanel.Controls.Add(this.BrowserDropdown);
            this.BrowserPanel.Controls.Add(this.label6);
            this.BrowserPanel.Controls.Add(this.label2);
            this.BrowserPanel.Location = new System.Drawing.Point(3, 12);
            this.BrowserPanel.Name = "BrowserPanel";
            this.BrowserPanel.Size = new System.Drawing.Size(727, 82);
            this.BrowserPanel.TabIndex = 4;
            // 
            // LaunchBrowserButton
            // 
            this.LaunchBrowserButton.Location = new System.Drawing.Point(520, 13);
            this.LaunchBrowserButton.Name = "LaunchBrowserButton";
            this.LaunchBrowserButton.Size = new System.Drawing.Size(95, 23);
            this.LaunchBrowserButton.TabIndex = 11;
            this.LaunchBrowserButton.Text = "Launch";
            this.LaunchBrowserButton.UseVisualStyleBackColor = true;
            this.LaunchBrowserButton.Click += new System.EventHandler(this.LaunchBrowserButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Host";
            // 
            // HostTextBox
            // 
            this.HostTextBox.Location = new System.Drawing.Point(342, 14);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(172, 22);
            this.HostTextBox.TabIndex = 9;
            this.HostTextBox.Text = "localhost";
            this.HostTextBox.TextChanged += new System.EventHandler(this.HostTextBox_TextChanged);
            // 
            // BrowserDropdown
            // 
            this.BrowserDropdown.DisplayMember = "1";
            this.BrowserDropdown.FormattingEnabled = true;
            this.BrowserDropdown.Items.AddRange(new object[] {
            "Firefox",
            "Chrome",
            "IE",
            "Safari",
            "Android"});
            this.BrowserDropdown.Location = new System.Drawing.Point(74, 12);
            this.BrowserDropdown.Name = "BrowserDropdown";
            this.BrowserDropdown.Size = new System.Drawing.Size(219, 24);
            this.BrowserDropdown.TabIndex = 8;
            this.BrowserDropdown.SelectedIndexChanged += new System.EventHandler(this.BrowserDropdown_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Browser";
            // 
            // JavascriptPanel
            // 
            this.JavascriptPanel.AutoSize = true;
            this.JavascriptPanel.BackColor = System.Drawing.Color.DimGray;
            this.JavascriptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JavascriptPanel.Controls.Add(this.label11);
            this.JavascriptPanel.Controls.Add(this.DisableOnClickButton);
            this.JavascriptPanel.Controls.Add(this.DisableMouseOverButton);
            this.JavascriptPanel.Controls.Add(this.ExecuteJS);
            this.JavascriptPanel.Controls.Add(this.label7);
            this.JavascriptPanel.Controls.Add(this.JavscriptTextBox);
            this.JavascriptPanel.Controls.Add(this.HidePanelButton);
            this.JavascriptPanel.Location = new System.Drawing.Point(4, 150);
            this.JavascriptPanel.Name = "JavascriptPanel";
            this.JavascriptPanel.Size = new System.Drawing.Size(726, 82);
            this.JavascriptPanel.TabIndex = 8;
            this.JavascriptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Prebuilt Commands";
            // 
            // DisableOnClickButton
            // 
            this.DisableOnClickButton.Location = new System.Drawing.Point(143, 43);
            this.DisableOnClickButton.Name = "DisableOnClickButton";
            this.DisableOnClickButton.Size = new System.Drawing.Size(118, 23);
            this.DisableOnClickButton.TabIndex = 13;
            this.DisableOnClickButton.Text = "DisableOnClick";
            this.DisableOnClickButton.UseVisualStyleBackColor = true;
            this.DisableOnClickButton.Click += new System.EventHandler(this.DisableOnClickButton_Click);
            // 
            // DisableMouseOverButton
            // 
            this.DisableMouseOverButton.Location = new System.Drawing.Point(277, 43);
            this.DisableMouseOverButton.Name = "DisableMouseOverButton";
            this.DisableMouseOverButton.Size = new System.Drawing.Size(143, 23);
            this.DisableMouseOverButton.TabIndex = 12;
            this.DisableMouseOverButton.Text = "Disable MouseOver";
            this.DisableMouseOverButton.UseVisualStyleBackColor = true;
            this.DisableMouseOverButton.Click += new System.EventHandler(this.DisableMouseOverButton_Click);
            // 
            // ExecuteJS
            // 
            this.ExecuteJS.Location = new System.Drawing.Point(621, 12);
            this.ExecuteJS.Name = "ExecuteJS";
            this.ExecuteJS.Size = new System.Drawing.Size(94, 23);
            this.ExecuteJS.TabIndex = 2;
            this.ExecuteJS.Text = "Execute JS";
            this.ExecuteJS.UseVisualStyleBackColor = true;
            this.ExecuteJS.Click += new System.EventHandler(this.ExecuteJS_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Javascript";
            // 
            // JavscriptTextBox
            // 
            this.JavscriptTextBox.Location = new System.Drawing.Point(85, 12);
            this.JavscriptTextBox.Name = "JavscriptTextBox";
            this.JavscriptTextBox.Size = new System.Drawing.Size(530, 22);
            this.JavscriptTextBox.TabIndex = 1;
            // 
            // HidePanelButton
            // 
            this.HidePanelButton.Location = new System.Drawing.Point(432, 43);
            this.HidePanelButton.Name = "HidePanelButton";
            this.HidePanelButton.Size = new System.Drawing.Size(121, 23);
            this.HidePanelButton.TabIndex = 11;
            this.HidePanelButton.Text = "HideDTVEPanel";
            this.HidePanelButton.UseVisualStyleBackColor = true;
            this.HidePanelButton.Click += new System.EventHandler(this.HidePanelButton_Click);
            // 
            // LogPanel
            // 
            this.LogPanel.BackColor = System.Drawing.Color.DimGray;
            this.LogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogPanel.Controls.Add(this.ClearLogButton);
            this.LogPanel.Controls.Add(this.LogTextBox);
            this.LogPanel.Controls.Add(this.label5);
            this.LogPanel.Location = new System.Drawing.Point(3, 329);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(1461, 226);
            this.LogPanel.TabIndex = 7;
            this.LogPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new System.Drawing.Point(49, 6);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(75, 23);
            this.ClearLogButton.TabIndex = 2;
            this.ClearLogButton.Text = "Clear";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(9, 35);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(1437, 177);
            this.LogTextBox.TabIndex = 1;
            this.LogTextBox.Text = "";
            this.LogTextBox.TextChanged += new System.EventHandler(this.LogTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Log";
            // 
            // RecordingPanel
            // 
            this.RecordingPanel.BackColor = System.Drawing.Color.DimGray;
            this.RecordingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecordingPanel.Controls.Add(this.label10);
            this.RecordingPanel.Controls.Add(this.RegisterClickEventButton);
            this.RecordingPanel.Controls.Add(this.RegisterRightClickButton);
            this.RecordingPanel.Location = new System.Drawing.Point(4, 100);
            this.RecordingPanel.Name = "RecordingPanel";
            this.RecordingPanel.Size = new System.Drawing.Size(726, 44);
            this.RecordingPanel.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Start Recording";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // XpathBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1484, 588);
            this.Controls.Add(this.RecordingPanel);
            this.Controls.Add(this.JavascriptPanel);
            this.Controls.Add(this.BrowserPanel);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.XpathPanel);
            this.Controls.Add(this.CommandPanel);
            this.Controls.Add(this.ElementPanel);
            this.Name = "XpathBuilder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ProtoTest.Specter";
            this.Load += new System.EventHandler(this.XpathBuilder_Load);
            this.ElementPanel.ResumeLayout(false);
            this.ElementPanel.PerformLayout();
            this.XpathPanel.ResumeLayout(false);
            this.XpathPanel.PerformLayout();
            this.CommandPanel.ResumeLayout(false);
            this.CommandPanel.PerformLayout();
            this.BrowserPanel.ResumeLayout(false);
            this.BrowserPanel.PerformLayout();
            this.JavascriptPanel.ResumeLayout(false);
            this.JavascriptPanel.PerformLayout();
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.RecordingPanel.ResumeLayout(false);
            this.RecordingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Panel ElementPanel;
        private System.Windows.Forms.Button HighlightElementButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ExecuteCommandButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox XpathsDropdown;
        private System.Windows.Forms.Button RegisterClickEventButton;
        private System.Windows.Forms.Button GetClickedElementButton;
        private System.Windows.Forms.Button GetParentButton;
        private System.Windows.Forms.Button RegisterRightClickButton;
        private System.Windows.Forms.Button GetElementButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MinimumXpathsTextBox;
        private System.Windows.Forms.TextBox WebDriverCommandText;
        private System.Windows.Forms.ComboBox WebDriverCommandDropdown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox XPathGeneratorMaxAttempts;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SelectedXpathTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel XpathPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel CommandPanel;
        private System.Windows.Forms.Panel BrowserPanel;
        private System.Windows.Forms.Button GoToUrlButton;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LaunchBrowserButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.ComboBox BrowserDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel JavascriptPanel;
        private System.Windows.Forms.Button DisableOnClickButton;
        private System.Windows.Forms.Button DisableMouseOverButton;
        private System.Windows.Forms.Button ExecuteJS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox JavscriptTextBox;
        private System.Windows.Forms.Button HidePanelButton;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Button ClearLogButton;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.WebBrowser WebText;
        private System.Windows.Forms.Panel RecordingPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

