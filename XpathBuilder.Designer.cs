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
            this.GetParentButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.XPathGeneratorMaxAttempts = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.XpathPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ElementPanel.SuspendLayout();
            this.XpathPanel.SuspendLayout();
            this.BrowserPanel.SuspendLayout();
            this.JavascriptPanel.SuspendLayout();
            this.LogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterRightClickButton
            // 
            this.RegisterRightClickButton.Location = new System.Drawing.Point(102, 5);
            this.RegisterRightClickButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterRightClickButton.Name = "RegisterRightClickButton";
            this.RegisterRightClickButton.Size = new System.Drawing.Size(106, 19);
            this.RegisterRightClickButton.TabIndex = 15;
            this.RegisterRightClickButton.Text = "RecordRightClick";
            this.RegisterRightClickButton.UseVisualStyleBackColor = true;
            this.RegisterRightClickButton.Click += new System.EventHandler(this.RegisterRightClickButton_Click);
            // 
            // RegisterClickEventButton
            // 
            this.RegisterClickEventButton.Location = new System.Drawing.Point(212, 5);
            this.RegisterClickEventButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterClickEventButton.Name = "RegisterClickEventButton";
            this.RegisterClickEventButton.Size = new System.Drawing.Size(106, 19);
            this.RegisterClickEventButton.TabIndex = 8;
            this.RegisterClickEventButton.Text = "RecordLeftClick";
            this.RegisterClickEventButton.UseVisualStyleBackColor = true;
            this.RegisterClickEventButton.Click += new System.EventHandler(this.RegisterClickEventButton_Click);
            // 
            // WebDriverCommandText
            // 
            this.WebDriverCommandText.Location = new System.Drawing.Point(902, 5);
            this.WebDriverCommandText.Margin = new System.Windows.Forms.Padding(2);
            this.WebDriverCommandText.Name = "WebDriverCommandText";
            this.WebDriverCommandText.Size = new System.Drawing.Size(182, 20);
            this.WebDriverCommandText.TabIndex = 20;
            this.WebDriverCommandText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // WebDriverCommandDropdown
            // 
            this.WebDriverCommandDropdown.DisplayMember = "1";
            this.WebDriverCommandDropdown.FormattingEnabled = true;
            this.WebDriverCommandDropdown.Items.AddRange(new object[] {
            "Find",
            "Click",
            "MouseOver",
            "Type",
            "ClickOffSet"});
            this.WebDriverCommandDropdown.Location = new System.Drawing.Point(613, 6);
            this.WebDriverCommandDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.WebDriverCommandDropdown.Name = "WebDriverCommandDropdown";
            this.WebDriverCommandDropdown.Size = new System.Drawing.Size(163, 21);
            this.WebDriverCommandDropdown.TabIndex = 19;
            this.WebDriverCommandDropdown.SelectedIndexChanged += new System.EventHandler(this.WebDriverCommandDropdown_SelectedIndexChanged);
            // 
            // MinimumXpathsTextBox
            // 
            this.MinimumXpathsTextBox.Location = new System.Drawing.Point(352, 9);
            this.MinimumXpathsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumXpathsTextBox.Name = "MinimumXpathsTextBox";
            this.MinimumXpathsTextBox.Size = new System.Drawing.Size(30, 20);
            this.MinimumXpathsTextBox.TabIndex = 17;
            this.MinimumXpathsTextBox.Text = "3";
            this.MinimumXpathsTextBox.TextChanged += new System.EventHandler(this.MinimumXpathsTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Minimum";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ExecuteCommandButton
            // 
            this.ExecuteCommandButton.Location = new System.Drawing.Point(791, 8);
            this.ExecuteCommandButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExecuteCommandButton.Name = "ExecuteCommandButton";
            this.ExecuteCommandButton.Size = new System.Drawing.Size(62, 19);
            this.ExecuteCommandButton.TabIndex = 4;
            this.ExecuteCommandButton.Text = "Execute";
            this.ExecuteCommandButton.UseVisualStyleBackColor = true;
            this.ExecuteCommandButton.Click += new System.EventHandler(this.ClickXpathButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "XPath Generator";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 19);
            this.button3.TabIndex = 3;
            this.button3.Text = "GenerateFromCurrentElement";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GenerateXpathButton_Click);
            // 
            // XpathsDropdown
            // 
            this.XpathsDropdown.FormattingEnabled = true;
            this.XpathsDropdown.Location = new System.Drawing.Point(55, 33);
            this.XpathsDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.XpathsDropdown.MaxDropDownItems = 20;
            this.XpathsDropdown.Name = "XpathsDropdown";
            this.XpathsDropdown.Size = new System.Drawing.Size(1029, 21);
            this.XpathsDropdown.TabIndex = 0;
            this.XpathsDropdown.SelectedIndexChanged += new System.EventHandler(this.XpathsDropdown_SelectedIndexChanged);
            // 
            // ElementPanel
            // 
            this.ElementPanel.BackColor = System.Drawing.Color.DimGray;
            this.ElementPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ElementPanel.Controls.Add(this.WebText);
            this.ElementPanel.Controls.Add(this.RegisterClickEventButton);
            this.ElementPanel.Controls.Add(this.label1);
            this.ElementPanel.Controls.Add(this.RegisterRightClickButton);
            this.ElementPanel.Controls.Add(this.GetParentButton);
            this.ElementPanel.Location = new System.Drawing.Point(2, 81);
            this.ElementPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ElementPanel.Name = "ElementPanel";
            this.ElementPanel.Size = new System.Drawing.Size(1100, 165);
            this.ElementPanel.TabIndex = 5;
            // 
            // WebText
            // 
            this.WebText.Location = new System.Drawing.Point(7, 32);
            this.WebText.Margin = new System.Windows.Forms.Padding(2);
            this.WebText.MinimumSize = new System.Drawing.Size(15, 16);
            this.WebText.Name = "WebText";
            this.WebText.Size = new System.Drawing.Size(1078, 129);
            this.WebText.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Element";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // GetParentButton
            // 
            this.GetParentButton.Location = new System.Drawing.Point(1015, 5);
            this.GetParentButton.Margin = new System.Windows.Forms.Padding(2);
            this.GetParentButton.Name = "GetParentButton";
            this.GetParentButton.Size = new System.Drawing.Size(69, 19);
            this.GetParentButton.TabIndex = 10;
            this.GetParentButton.Text = "FindParent";
            this.GetParentButton.UseVisualStyleBackColor = true;
            this.GetParentButton.Click += new System.EventHandler(this.GetParentButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(382, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Max Attempts";
            // 
            // XPathGeneratorMaxAttempts
            // 
            this.XPathGeneratorMaxAttempts.Location = new System.Drawing.Point(456, 8);
            this.XPathGeneratorMaxAttempts.Margin = new System.Windows.Forms.Padding(2);
            this.XPathGeneratorMaxAttempts.Name = "XPathGeneratorMaxAttempts";
            this.XPathGeneratorMaxAttempts.Size = new System.Drawing.Size(30, 20);
            this.XPathGeneratorMaxAttempts.TabIndex = 26;
            this.XPathGeneratorMaxAttempts.Text = "100";
            this.XPathGeneratorMaxAttempts.TextChanged += new System.EventHandler(this.XPathGeneratorMaxAttempts_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(510, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Execute Command";
            // 
            // XpathPanel
            // 
            this.XpathPanel.AutoSize = true;
            this.XpathPanel.BackColor = System.Drawing.Color.DimGray;
            this.XpathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XpathPanel.Controls.Add(this.label15);
            this.XpathPanel.Controls.Add(this.button3);
            this.XpathPanel.Controls.Add(this.label14);
            this.XpathPanel.Controls.Add(this.ExecuteCommandButton);
            this.XpathPanel.Controls.Add(this.XpathsDropdown);
            this.XpathPanel.Controls.Add(this.WebDriverCommandDropdown);
            this.XpathPanel.Controls.Add(this.XPathGeneratorMaxAttempts);
            this.XpathPanel.Controls.Add(this.WebDriverCommandText);
            this.XpathPanel.Controls.Add(this.label4);
            this.XpathPanel.Controls.Add(this.label13);
            this.XpathPanel.Controls.Add(this.label8);
            this.XpathPanel.Controls.Add(this.MinimumXpathsTextBox);
            this.XpathPanel.Location = new System.Drawing.Point(2, 251);
            this.XpathPanel.Margin = new System.Windows.Forms.Padding(2);
            this.XpathPanel.Name = "XpathPanel";
            this.XpathPanel.Size = new System.Drawing.Size(1100, 69);
            this.XpathPanel.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Xpath";
            // 
            // GoToUrlButton
            // 
            this.GoToUrlButton.Location = new System.Drawing.Point(390, 34);
            this.GoToUrlButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoToUrlButton.Name = "GoToUrlButton";
            this.GoToUrlButton.Size = new System.Drawing.Size(71, 19);
            this.GoToUrlButton.TabIndex = 14;
            this.GoToUrlButton.Text = "GoToUrl";
            this.GoToUrlButton.UseVisualStyleBackColor = true;
            this.GoToUrlButton.Click += new System.EventHandler(this.GoToUrlButton_Click);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(56, 34);
            this.UrlTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(331, 20);
            this.UrlTextBox.TabIndex = 13;
            this.UrlTextBox.TextChanged += new System.EventHandler(this.UrlTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
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
            this.BrowserPanel.Location = new System.Drawing.Point(2, 10);
            this.BrowserPanel.Margin = new System.Windows.Forms.Padding(2);
            this.BrowserPanel.Name = "BrowserPanel";
            this.BrowserPanel.Size = new System.Drawing.Size(471, 67);
            this.BrowserPanel.TabIndex = 4;
            // 
            // LaunchBrowserButton
            // 
            this.LaunchBrowserButton.Location = new System.Drawing.Point(390, 11);
            this.LaunchBrowserButton.Margin = new System.Windows.Forms.Padding(2);
            this.LaunchBrowserButton.Name = "LaunchBrowserButton";
            this.LaunchBrowserButton.Size = new System.Drawing.Size(71, 19);
            this.LaunchBrowserButton.TabIndex = 11;
            this.LaunchBrowserButton.Text = "Launch";
            this.LaunchBrowserButton.UseVisualStyleBackColor = true;
            this.LaunchBrowserButton.Click += new System.EventHandler(this.LaunchBrowserButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Host";
            // 
            // HostTextBox
            // 
            this.HostTextBox.Location = new System.Drawing.Point(256, 11);
            this.HostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(130, 20);
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
            this.BrowserDropdown.Location = new System.Drawing.Point(56, 10);
            this.BrowserDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.BrowserDropdown.Name = "BrowserDropdown";
            this.BrowserDropdown.Size = new System.Drawing.Size(165, 21);
            this.BrowserDropdown.TabIndex = 8;
            this.BrowserDropdown.SelectedIndexChanged += new System.EventHandler(this.BrowserDropdown_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
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
            this.JavascriptPanel.Location = new System.Drawing.Point(477, 10);
            this.JavascriptPanel.Margin = new System.Windows.Forms.Padding(2);
            this.JavascriptPanel.Name = "JavascriptPanel";
            this.JavascriptPanel.Size = new System.Drawing.Size(625, 67);
            this.JavascriptPanel.TabIndex = 8;
            this.JavascriptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Prebuilt Commands";
            // 
            // DisableOnClickButton
            // 
            this.DisableOnClickButton.Location = new System.Drawing.Point(107, 35);
            this.DisableOnClickButton.Margin = new System.Windows.Forms.Padding(2);
            this.DisableOnClickButton.Name = "DisableOnClickButton";
            this.DisableOnClickButton.Size = new System.Drawing.Size(88, 19);
            this.DisableOnClickButton.TabIndex = 13;
            this.DisableOnClickButton.Text = "DisableOnClick";
            this.DisableOnClickButton.UseVisualStyleBackColor = true;
            this.DisableOnClickButton.Click += new System.EventHandler(this.DisableOnClickButton_Click);
            // 
            // DisableMouseOverButton
            // 
            this.DisableMouseOverButton.Location = new System.Drawing.Point(208, 35);
            this.DisableMouseOverButton.Margin = new System.Windows.Forms.Padding(2);
            this.DisableMouseOverButton.Name = "DisableMouseOverButton";
            this.DisableMouseOverButton.Size = new System.Drawing.Size(107, 19);
            this.DisableMouseOverButton.TabIndex = 12;
            this.DisableMouseOverButton.Text = "Disable MouseOver";
            this.DisableMouseOverButton.UseVisualStyleBackColor = true;
            this.DisableMouseOverButton.Click += new System.EventHandler(this.DisableMouseOverButton_Click);
            // 
            // ExecuteJS
            // 
            this.ExecuteJS.Location = new System.Drawing.Point(539, 12);
            this.ExecuteJS.Margin = new System.Windows.Forms.Padding(2);
            this.ExecuteJS.Name = "ExecuteJS";
            this.ExecuteJS.Size = new System.Drawing.Size(70, 19);
            this.ExecuteJS.TabIndex = 2;
            this.ExecuteJS.Text = "Execute JS";
            this.ExecuteJS.UseVisualStyleBackColor = true;
            this.ExecuteJS.Click += new System.EventHandler(this.ExecuteJS_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Javascript";
            // 
            // JavscriptTextBox
            // 
            this.JavscriptTextBox.Location = new System.Drawing.Point(64, 10);
            this.JavscriptTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.JavscriptTextBox.Name = "JavscriptTextBox";
            this.JavscriptTextBox.Size = new System.Drawing.Size(471, 20);
            this.JavscriptTextBox.TabIndex = 1;
            // 
            // HidePanelButton
            // 
            this.HidePanelButton.Location = new System.Drawing.Point(324, 35);
            this.HidePanelButton.Margin = new System.Windows.Forms.Padding(2);
            this.HidePanelButton.Name = "HidePanelButton";
            this.HidePanelButton.Size = new System.Drawing.Size(109, 19);
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
            this.LogPanel.Location = new System.Drawing.Point(2, 324);
            this.LogPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(1100, 207);
            this.LogPanel.TabIndex = 7;
            this.LogPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new System.Drawing.Point(37, 5);
            this.ClearLogButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(56, 19);
            this.ClearLogButton.TabIndex = 2;
            this.ClearLogButton.Text = "Clear";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(5, 28);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(1079, 173);
            this.LogTextBox.TabIndex = 1;
            this.LogTextBox.Text = "";
            this.LogTextBox.TextChanged += new System.EventHandler(this.LogTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Log";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // XpathBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1113, 533);
            this.Controls.Add(this.JavascriptPanel);
            this.Controls.Add(this.BrowserPanel);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.XpathPanel);
            this.Controls.Add(this.ElementPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "XpathBuilder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ProtoTest.Specter";
            this.Load += new System.EventHandler(this.XpathBuilder_Load);
            this.ElementPanel.ResumeLayout(false);
            this.ElementPanel.PerformLayout();
            this.XpathPanel.ResumeLayout(false);
            this.XpathPanel.PerformLayout();
            this.BrowserPanel.ResumeLayout(false);
            this.BrowserPanel.PerformLayout();
            this.JavascriptPanel.ResumeLayout(false);
            this.JavascriptPanel.PerformLayout();
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Panel ElementPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ExecuteCommandButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox XpathsDropdown;
        private System.Windows.Forms.Button RegisterClickEventButton;
        private System.Windows.Forms.Button GetParentButton;
        private System.Windows.Forms.Button RegisterRightClickButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MinimumXpathsTextBox;
        private System.Windows.Forms.TextBox WebDriverCommandText;
        private System.Windows.Forms.ComboBox WebDriverCommandDropdown;
        private System.Windows.Forms.TextBox XPathGeneratorMaxAttempts;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel XpathPanel;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label15;
    }
}

