namespace ProtoTest.XpathBuilder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MinimumXpathsTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ExecuteCommandButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.XpathsDropdown = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RegisterRightClickButton = new System.Windows.Forms.Button();
            this.DisableOnClickButton = new System.Windows.Forms.Button();
            this.DisableMouseOverButton = new System.Windows.Forms.Button();
            this.RegisterClickEventButton = new System.Windows.Forms.Button();
            this.ExecuteJS = new System.Windows.Forms.Button();
            this.HidePanelButton = new System.Windows.Forms.Button();
            this.JavscriptTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GetElementButton = new System.Windows.Forms.Button();
            this.WebText = new System.Windows.Forms.WebBrowser();
            this.GetParentButton = new System.Windows.Forms.Button();
            this.HighlightElementButton = new System.Windows.Forms.Button();
            this.GetClickedElementButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoToUrlButton = new System.Windows.Forms.Button();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LaunchBrowserButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.BrowserDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WebDriverCommandDropdown = new System.Windows.Forms.ComboBox();
            this.WebDriverCommandText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 808);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.WebDriverCommandText);
            this.panel4.Controls.Add(this.WebDriverCommandDropdown);
            this.panel4.Controls.Add(this.MinimumXpathsTextBox);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.ExecuteCommandButton);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.XpathsDropdown);
            this.panel4.Location = new System.Drawing.Point(13, 442);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(628, 109);
            this.panel4.TabIndex = 6;
            // 
            // MinimumXpathsTextBox
            // 
            this.MinimumXpathsTextBox.Location = new System.Drawing.Point(299, 11);
            this.MinimumXpathsTextBox.Name = "MinimumXpathsTextBox";
            this.MinimumXpathsTextBox.Size = new System.Drawing.Size(38, 22);
            this.MinimumXpathsTextBox.TabIndex = 17;
            this.MinimumXpathsTextBox.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Minimum";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ExecuteCommandButton
            // 
            this.ExecuteCommandButton.Location = new System.Drawing.Point(268, 73);
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
            this.label4.Location = new System.Drawing.Point(11, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Xpaths";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Generate Xpaths";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GenerateXpathButton_Click);
            // 
            // XpathsDropdown
            // 
            this.XpathsDropdown.FormattingEnabled = true;
            this.XpathsDropdown.Location = new System.Drawing.Point(11, 42);
            this.XpathsDropdown.Name = "XpathsDropdown";
            this.XpathsDropdown.Size = new System.Drawing.Size(597, 24);
            this.XpathsDropdown.TabIndex = 0;
            this.XpathsDropdown.SelectedIndexChanged += new System.EventHandler(this.XpathsDropdown_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.RegisterRightClickButton);
            this.panel6.Controls.Add(this.DisableOnClickButton);
            this.panel6.Controls.Add(this.DisableMouseOverButton);
            this.panel6.Controls.Add(this.RegisterClickEventButton);
            this.panel6.Controls.Add(this.ExecuteJS);
            this.panel6.Controls.Add(this.HidePanelButton);
            this.panel6.Controls.Add(this.JavscriptTextBox);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(13, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(628, 98);
            this.panel6.TabIndex = 8;
            // 
            // RegisterRightClickButton
            // 
            this.RegisterRightClickButton.Location = new System.Drawing.Point(74, 37);
            this.RegisterRightClickButton.Name = "RegisterRightClickButton";
            this.RegisterRightClickButton.Size = new System.Drawing.Size(141, 23);
            this.RegisterRightClickButton.TabIndex = 15;
            this.RegisterRightClickButton.Text = "RecordRightClick";
            this.RegisterRightClickButton.UseVisualStyleBackColor = true;
            this.RegisterRightClickButton.Click += new System.EventHandler(this.RegisterRightClickButton_Click);
            // 
            // DisableOnClickButton
            // 
            this.DisableOnClickButton.Location = new System.Drawing.Point(222, 66);
            this.DisableOnClickButton.Name = "DisableOnClickButton";
            this.DisableOnClickButton.Size = new System.Drawing.Size(118, 23);
            this.DisableOnClickButton.TabIndex = 13;
            this.DisableOnClickButton.Text = "DisableOnClick";
            this.DisableOnClickButton.UseVisualStyleBackColor = true;
            this.DisableOnClickButton.Click += new System.EventHandler(this.DisableOnClickButton_Click);
            // 
            // DisableMouseOverButton
            // 
            this.DisableMouseOverButton.Location = new System.Drawing.Point(222, 37);
            this.DisableMouseOverButton.Name = "DisableMouseOverButton";
            this.DisableMouseOverButton.Size = new System.Drawing.Size(143, 23);
            this.DisableMouseOverButton.TabIndex = 12;
            this.DisableMouseOverButton.Text = "Disable MouseOver";
            this.DisableMouseOverButton.UseVisualStyleBackColor = true;
            this.DisableMouseOverButton.Click += new System.EventHandler(this.DisableMouseOverButton_Click);
            // 
            // RegisterClickEventButton
            // 
            this.RegisterClickEventButton.Location = new System.Drawing.Point(75, 66);
            this.RegisterClickEventButton.Name = "RegisterClickEventButton";
            this.RegisterClickEventButton.Size = new System.Drawing.Size(141, 23);
            this.RegisterClickEventButton.TabIndex = 8;
            this.RegisterClickEventButton.Text = "RecordLeftClick";
            this.RegisterClickEventButton.UseVisualStyleBackColor = true;
            this.RegisterClickEventButton.Click += new System.EventHandler(this.RegisterClickEventButton_Click);
            // 
            // ExecuteJS
            // 
            this.ExecuteJS.Location = new System.Drawing.Point(522, 9);
            this.ExecuteJS.Name = "ExecuteJS";
            this.ExecuteJS.Size = new System.Drawing.Size(94, 23);
            this.ExecuteJS.TabIndex = 2;
            this.ExecuteJS.Text = "Execute JS";
            this.ExecuteJS.UseVisualStyleBackColor = true;
            this.ExecuteJS.Click += new System.EventHandler(this.ExecuteJS_Click);
            // 
            // HidePanelButton
            // 
            this.HidePanelButton.Location = new System.Drawing.Point(495, 37);
            this.HidePanelButton.Name = "HidePanelButton";
            this.HidePanelButton.Size = new System.Drawing.Size(121, 23);
            this.HidePanelButton.TabIndex = 11;
            this.HidePanelButton.Text = "HideDTVEPanel";
            this.HidePanelButton.UseVisualStyleBackColor = true;
            this.HidePanelButton.Click += new System.EventHandler(this.HidePanelButton_Click);
            // 
            // JavscriptTextBox
            // 
            this.JavscriptTextBox.Location = new System.Drawing.Point(75, 9);
            this.JavscriptTextBox.Name = "JavscriptTextBox";
            this.JavscriptTextBox.Size = new System.Drawing.Size(440, 22);
            this.JavscriptTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Javascript";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.GetElementButton);
            this.panel3.Controls.Add(this.WebText);
            this.panel3.Controls.Add(this.GetParentButton);
            this.panel3.Controls.Add(this.HighlightElementButton);
            this.panel3.Controls.Add(this.GetClickedElementButton);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(13, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 232);
            this.panel3.TabIndex = 5;
            // 
            // GetElementButton
            // 
            this.GetElementButton.Location = new System.Drawing.Point(183, 6);
            this.GetElementButton.Name = "GetElementButton";
            this.GetElementButton.Size = new System.Drawing.Size(110, 23);
            this.GetElementButton.TabIndex = 16;
            this.GetElementButton.Text = "GetFromXpath";
            this.GetElementButton.UseVisualStyleBackColor = true;
            this.GetElementButton.Click += new System.EventHandler(this.GetElementButton_Click);
            // 
            // WebText
            // 
            this.WebText.Location = new System.Drawing.Point(14, 35);
            this.WebText.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebText.Name = "WebText";
            this.WebText.Size = new System.Drawing.Size(601, 188);
            this.WebText.TabIndex = 12;
            // 
            // GetParentButton
            // 
            this.GetParentButton.Location = new System.Drawing.Point(299, 6);
            this.GetParentButton.Name = "GetParentButton";
            this.GetParentButton.Size = new System.Drawing.Size(92, 23);
            this.GetParentButton.TabIndex = 10;
            this.GetParentButton.Text = "Get Parent";
            this.GetParentButton.UseVisualStyleBackColor = true;
            this.GetParentButton.Click += new System.EventHandler(this.GetParentButton_Click);
            // 
            // HighlightElementButton
            // 
            this.HighlightElementButton.Location = new System.Drawing.Point(397, 6);
            this.HighlightElementButton.Name = "HighlightElementButton";
            this.HighlightElementButton.Size = new System.Drawing.Size(85, 23);
            this.HighlightElementButton.TabIndex = 2;
            this.HighlightElementButton.Text = "Highlight";
            this.HighlightElementButton.UseVisualStyleBackColor = true;
            this.HighlightElementButton.Click += new System.EventHandler(this.HighlightElementButton_Click);
            // 
            // GetClickedElementButton
            // 
            this.GetClickedElementButton.Location = new System.Drawing.Point(75, 6);
            this.GetClickedElementButton.Name = "GetClickedElementButton";
            this.GetClickedElementButton.Size = new System.Drawing.Size(104, 23);
            this.GetClickedElementButton.TabIndex = 7;
            this.GetClickedElementButton.Text = "GetFromClick";
            this.GetClickedElementButton.UseVisualStyleBackColor = true;
            this.GetClickedElementButton.Click += new System.EventHandler(this.GetClickedElementButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Element";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.ClearLogButton);
            this.panel5.Controls.Add(this.LogTextBox);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(13, 557);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(628, 239);
            this.panel5.TabIndex = 7;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
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
            this.LogTextBox.Location = new System.Drawing.Point(11, 35);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(605, 195);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.GoToUrlButton);
            this.panel2.Controls.Add(this.UrlTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.LaunchBrowserButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.HostTextBox);
            this.panel2.Controls.Add(this.BrowserDropdown);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 75);
            this.panel2.TabIndex = 4;
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
            this.label6.Location = new System.Drawing.Point(11, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "URL";
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
            // WebDriverCommandDropdown
            // 
            this.WebDriverCommandDropdown.FormattingEnabled = true;
            this.WebDriverCommandDropdown.Items.AddRange(new object[] {
            "Highlight",
            "Click",
            "MouseOver",
            "Type"});
            this.WebDriverCommandDropdown.Location = new System.Drawing.Point(99, 73);
            this.WebDriverCommandDropdown.Name = "WebDriverCommandDropdown";
            this.WebDriverCommandDropdown.Size = new System.Drawing.Size(163, 24);
            this.WebDriverCommandDropdown.TabIndex = 19;
            this.WebDriverCommandDropdown.SelectedIndexChanged += new System.EventHandler(this.WebDriverCommandDropdown_SelectedIndexChanged);
            // 
            // WebDriverCommandText
            // 
            this.WebDriverCommandText.Location = new System.Drawing.Point(397, 73);
            this.WebDriverCommandText.Name = "WebDriverCommandText";
            this.WebDriverCommandText.Size = new System.Drawing.Size(149, 22);
            this.WebDriverCommandText.TabIndex = 20;
            this.WebDriverCommandText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Text:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Command :";
            // 
            // XpathBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 821);
            this.Controls.Add(this.panel1);
            this.Name = "XpathBuilder";
            this.Text = "ProtoTest.XpathBuilder";
            this.Load += new System.EventHandler(this.XpathBuilder_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button HighlightElementButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button LaunchBrowserButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.ComboBox BrowserDropdown;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ExecuteCommandButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox XpathsDropdown;
        private System.Windows.Forms.Button ClearLogButton;
        private System.Windows.Forms.Button GoToUrlButton;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RegisterClickEventButton;
        private System.Windows.Forms.Button GetClickedElementButton;
        private System.Windows.Forms.Button GetParentButton;
        private System.Windows.Forms.Button RegisterRightClickButton;
        private System.Windows.Forms.Button HidePanelButton;
        private System.Windows.Forms.WebBrowser WebText;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ExecuteJS;
        private System.Windows.Forms.TextBox JavscriptTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GetElementButton;
        private System.Windows.Forms.Button DisableMouseOverButton;
        private System.Windows.Forms.Button DisableOnClickButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MinimumXpathsTextBox;
        private System.Windows.Forms.TextBox WebDriverCommandText;
        private System.Windows.Forms.ComboBox WebDriverCommandDropdown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

