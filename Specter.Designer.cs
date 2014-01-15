namespace ProtoTest.Specter
{
    partial class Specter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Specter));
            this.RegisterRightClickButton = new System.Windows.Forms.Button();
            this.RegisterClickEventButton = new System.Windows.Forms.Button();
            this.WebDriverCommandText = new System.Windows.Forms.TextBox();
            this.WebDriverCommandDropdown = new System.Windows.Forms.ComboBox();
            this.MinimumXpathsTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ExecuteCommandButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.XpathsDropdown = new System.Windows.Forms.ComboBox();
            this.ElementPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.RefreshTimeTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.WebText = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.GetParentButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.XPathGeneratorMaxAttempts = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.XpathPanel = new System.Windows.Forms.Panel();
            this.CheckCousinsCheckbox = new System.Windows.Forms.CheckBox();
            this.CheckChildrenCheckbox = new System.Windows.Forms.CheckBox();
            this.UseQuotesCheckbox = new System.Windows.Forms.CheckBox();
            this.CheckSiblingsCheckbox = new System.Windows.Forms.CheckBox();
            this.UseTextCheckbox = new System.Windows.Forms.CheckBox();
            this.CheckAncestorsCheckbox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CheckSelfCheckbox = new System.Windows.Forms.CheckBox();
            this.MaxAttLength = new System.Windows.Forms.TextBox();
            this.UseContainsCheckBox = new System.Windows.Forms.CheckBox();
            this.SkipAttLabel = new System.Windows.Forms.Label();
            this.SkipAttributeTextBox = new System.Windows.Forms.TextBox();
            this.SplitAttributesCheckbox = new System.Windows.Forms.CheckBox();
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
            this.RegisterRightClickButton.Location = new System.Drawing.Point(136, 6);
            this.RegisterRightClickButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterRightClickButton.Name = "RegisterRightClickButton";
            this.RegisterRightClickButton.Size = new System.Drawing.Size(141, 23);
            this.RegisterRightClickButton.TabIndex = 15;
            this.RegisterRightClickButton.Text = "RecordRightClick";
            this.RegisterRightClickButton.UseVisualStyleBackColor = true;
            this.RegisterRightClickButton.Click += new System.EventHandler(this.RegisterRightClickButton_Click);
            // 
            // RegisterClickEventButton
            // 
            this.RegisterClickEventButton.Location = new System.Drawing.Point(283, 6);
            this.RegisterClickEventButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterClickEventButton.Name = "RegisterClickEventButton";
            this.RegisterClickEventButton.Size = new System.Drawing.Size(141, 23);
            this.RegisterClickEventButton.TabIndex = 8;
            this.RegisterClickEventButton.Text = "RecordLeftClick";
            this.RegisterClickEventButton.UseVisualStyleBackColor = true;
            this.RegisterClickEventButton.Click += new System.EventHandler(this.RegisterClickEventButton_Click);
            // 
            // WebDriverCommandText
            // 
            this.WebDriverCommandText.Location = new System.Drawing.Point(1195, 82);
            this.WebDriverCommandText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WebDriverCommandText.Name = "WebDriverCommandText";
            this.WebDriverCommandText.Size = new System.Drawing.Size(152, 22);
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
            "Count"});
            this.WebDriverCommandDropdown.Location = new System.Drawing.Point(972, 81);
            this.WebDriverCommandDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WebDriverCommandDropdown.Name = "WebDriverCommandDropdown";
            this.WebDriverCommandDropdown.Size = new System.Drawing.Size(216, 24);
            this.WebDriverCommandDropdown.TabIndex = 19;
            this.WebDriverCommandDropdown.SelectedIndexChanged += new System.EventHandler(this.WebDriverCommandDropdown_SelectedIndexChanged);
            // 
            // MinimumXpathsTextBox
            // 
            this.MinimumXpathsTextBox.Location = new System.Drawing.Point(253, 16);
            this.MinimumXpathsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumXpathsTextBox.Name = "MinimumXpathsTextBox";
            this.MinimumXpathsTextBox.Size = new System.Drawing.Size(39, 22);
            this.MinimumXpathsTextBox.TabIndex = 17;
            this.MinimumXpathsTextBox.Text = "3";
            this.MinimumXpathsTextBox.TextChanged += new System.EventHandler(this.MinimumXpathsTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Minimum";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ExecuteCommandButton
            // 
            this.ExecuteCommandButton.Location = new System.Drawing.Point(1363, 82);
            this.ExecuteCommandButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExecuteCommandButton.Name = "ExecuteCommandButton";
            this.ExecuteCommandButton.Size = new System.Drawing.Size(83, 23);
            this.ExecuteCommandButton.TabIndex = 4;
            this.ExecuteCommandButton.Text = "Execute";
            this.ExecuteCommandButton.UseVisualStyleBackColor = true;
            this.ExecuteCommandButton.Click += new System.EventHandler(this.ClickXpathButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(73, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "GenerateXpaths";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GenerateXpathButton_Click);
            // 
            // XpathsDropdown
            // 
            this.XpathsDropdown.FormattingEnabled = true;
            this.XpathsDropdown.Location = new System.Drawing.Point(73, 46);
            this.XpathsDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XpathsDropdown.MaxDropDownItems = 20;
            this.XpathsDropdown.Name = "XpathsDropdown";
            this.XpathsDropdown.Size = new System.Drawing.Size(1371, 24);
            this.XpathsDropdown.TabIndex = 0;
            this.XpathsDropdown.SelectedIndexChanged += new System.EventHandler(this.XpathsDropdown_SelectedIndexChanged);
            // 
            // ElementPanel
            // 
            this.ElementPanel.BackColor = System.Drawing.Color.DimGray;
            this.ElementPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ElementPanel.Controls.Add(this.label4);
            this.ElementPanel.Controls.Add(this.RefreshTimeTextBox);
            this.ElementPanel.Controls.Add(this.button2);
            this.ElementPanel.Controls.Add(this.button1);
            this.ElementPanel.Controls.Add(this.WebText);
            this.ElementPanel.Controls.Add(this.RegisterClickEventButton);
            this.ElementPanel.Controls.Add(this.label1);
            this.ElementPanel.Controls.Add(this.RegisterRightClickButton);
            this.ElementPanel.Controls.Add(this.GetParentButton);
            this.ElementPanel.Location = new System.Drawing.Point(3, 100);
            this.ElementPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ElementPanel.Name = "ElementPanel";
            this.ElementPanel.Size = new System.Drawing.Size(1466, 203);
            this.ElementPanel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Refresh Time (ms)";
            // 
            // RefreshTimeTextBox
            // 
            this.RefreshTimeTextBox.Location = new System.Drawing.Point(445, 6);
            this.RefreshTimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshTimeTextBox.Name = "RefreshTimeTextBox";
            this.RefreshTimeTextBox.Size = new System.Drawing.Size(53, 22);
            this.RefreshTimeTextBox.TabIndex = 18;
            this.RefreshTimeTextBox.Text = "2000";
            this.RefreshTimeTextBox.TextChanged += new System.EventHandler(this.RefreshTimeTextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1159, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "FindChild";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1256, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "FindSibling";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WebText
            // 
            this.WebText.Location = new System.Drawing.Point(9, 39);
            this.WebText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WebText.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebText.Name = "WebText";
            this.WebText.Size = new System.Drawing.Size(1437, 159);
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
            // GetParentButton
            // 
            this.GetParentButton.Location = new System.Drawing.Point(1353, 6);
            this.GetParentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetParentButton.Name = "GetParentButton";
            this.GetParentButton.Size = new System.Drawing.Size(92, 23);
            this.GetParentButton.TabIndex = 10;
            this.GetParentButton.Text = "FindParent";
            this.GetParentButton.UseVisualStyleBackColor = true;
            this.GetParentButton.Click += new System.EventHandler(this.GetParentButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(425, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Max Attempts";
            // 
            // XPathGeneratorMaxAttempts
            // 
            this.XPathGeneratorMaxAttempts.Location = new System.Drawing.Point(380, 17);
            this.XPathGeneratorMaxAttempts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XPathGeneratorMaxAttempts.Name = "XPathGeneratorMaxAttempts";
            this.XPathGeneratorMaxAttempts.Size = new System.Drawing.Size(39, 22);
            this.XPathGeneratorMaxAttempts.TabIndex = 26;
            this.XPathGeneratorMaxAttempts.Text = "100";
            this.XPathGeneratorMaxAttempts.TextChanged += new System.EventHandler(this.XPathGeneratorMaxAttempts_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(839, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Execute Command";
            // 
            // XpathPanel
            // 
            this.XpathPanel.AutoSize = true;
            this.XpathPanel.BackColor = System.Drawing.Color.DimGray;
            this.XpathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XpathPanel.Controls.Add(this.CheckCousinsCheckbox);
            this.XpathPanel.Controls.Add(this.CheckChildrenCheckbox);
            this.XpathPanel.Controls.Add(this.UseQuotesCheckbox);
            this.XpathPanel.Controls.Add(this.CheckSiblingsCheckbox);
            this.XpathPanel.Controls.Add(this.UseTextCheckbox);
            this.XpathPanel.Controls.Add(this.CheckAncestorsCheckbox);
            this.XpathPanel.Controls.Add(this.label9);
            this.XpathPanel.Controls.Add(this.CheckSelfCheckbox);
            this.XpathPanel.Controls.Add(this.MaxAttLength);
            this.XpathPanel.Controls.Add(this.UseContainsCheckBox);
            this.XpathPanel.Controls.Add(this.SkipAttLabel);
            this.XpathPanel.Controls.Add(this.SkipAttributeTextBox);
            this.XpathPanel.Controls.Add(this.SplitAttributesCheckbox);
            this.XpathPanel.Controls.Add(this.label15);
            this.XpathPanel.Controls.Add(this.button3);
            this.XpathPanel.Controls.Add(this.label14);
            this.XpathPanel.Controls.Add(this.ExecuteCommandButton);
            this.XpathPanel.Controls.Add(this.XpathsDropdown);
            this.XpathPanel.Controls.Add(this.WebDriverCommandDropdown);
            this.XpathPanel.Controls.Add(this.XPathGeneratorMaxAttempts);
            this.XpathPanel.Controls.Add(this.WebDriverCommandText);
            this.XpathPanel.Controls.Add(this.label13);
            this.XpathPanel.Controls.Add(this.label8);
            this.XpathPanel.Controls.Add(this.MinimumXpathsTextBox);
            this.XpathPanel.Location = new System.Drawing.Point(3, 309);
            this.XpathPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XpathPanel.Name = "XpathPanel";
            this.XpathPanel.Size = new System.Drawing.Size(1466, 114);
            this.XpathPanel.TabIndex = 7;
            // 
            // CheckCousinsCheckbox
            // 
            this.CheckCousinsCheckbox.AutoSize = true;
            this.CheckCousinsCheckbox.Checked = true;
            this.CheckCousinsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCousinsCheckbox.Location = new System.Drawing.Point(428, 82);
            this.CheckCousinsCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckCousinsCheckbox.Name = "CheckCousinsCheckbox";
            this.CheckCousinsCheckbox.Size = new System.Drawing.Size(80, 21);
            this.CheckCousinsCheckbox.TabIndex = 37;
            this.CheckCousinsCheckbox.Text = "Cousins";
            this.CheckCousinsCheckbox.UseVisualStyleBackColor = true;
            this.CheckCousinsCheckbox.CheckedChanged += new System.EventHandler(this.CheckCousinsCheckbox_CheckedChanged);
            // 
            // CheckChildrenCheckbox
            // 
            this.CheckChildrenCheckbox.AutoSize = true;
            this.CheckChildrenCheckbox.Checked = true;
            this.CheckChildrenCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckChildrenCheckbox.Location = new System.Drawing.Point(335, 82);
            this.CheckChildrenCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckChildrenCheckbox.Name = "CheckChildrenCheckbox";
            this.CheckChildrenCheckbox.Size = new System.Drawing.Size(82, 21);
            this.CheckChildrenCheckbox.TabIndex = 23;
            this.CheckChildrenCheckbox.Text = "Children";
            this.CheckChildrenCheckbox.UseVisualStyleBackColor = true;
            this.CheckChildrenCheckbox.CheckedChanged += new System.EventHandler(this.CheckChildrenCheckbox_CheckedChanged);
            // 
            // UseQuotesCheckbox
            // 
            this.UseQuotesCheckbox.AutoSize = true;
            this.UseQuotesCheckbox.Checked = true;
            this.UseQuotesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseQuotesCheckbox.Location = new System.Drawing.Point(1301, 17);
            this.UseQuotesCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.UseQuotesCheckbox.Name = "UseQuotesCheckbox";
            this.UseQuotesCheckbox.Size = new System.Drawing.Size(154, 21);
            this.UseQuotesCheckbox.TabIndex = 36;
            this.UseQuotesCheckbox.Text = "Use Double Quotes";
            this.UseQuotesCheckbox.UseVisualStyleBackColor = true;
            this.UseQuotesCheckbox.CheckedChanged += new System.EventHandler(this.UseQuotesCheckbox_CheckedChanged);
            // 
            // CheckSiblingsCheckbox
            // 
            this.CheckSiblingsCheckbox.AutoSize = true;
            this.CheckSiblingsCheckbox.Checked = true;
            this.CheckSiblingsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckSiblingsCheckbox.Location = new System.Drawing.Point(244, 82);
            this.CheckSiblingsCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckSiblingsCheckbox.Name = "CheckSiblingsCheckbox";
            this.CheckSiblingsCheckbox.Size = new System.Drawing.Size(79, 21);
            this.CheckSiblingsCheckbox.TabIndex = 22;
            this.CheckSiblingsCheckbox.Text = "Siblings";
            this.CheckSiblingsCheckbox.UseVisualStyleBackColor = true;
            this.CheckSiblingsCheckbox.CheckedChanged += new System.EventHandler(this.CheckSiblingsCheckbox_CheckedChanged);
            // 
            // UseTextCheckbox
            // 
            this.UseTextCheckbox.AutoSize = true;
            this.UseTextCheckbox.Location = new System.Drawing.Point(1197, 18);
            this.UseTextCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.UseTextCheckbox.Name = "UseTextCheckbox";
            this.UseTextCheckbox.Size = new System.Drawing.Size(91, 21);
            this.UseTextCheckbox.TabIndex = 35;
            this.UseTextCheckbox.Text = "Use text()";
            this.UseTextCheckbox.UseVisualStyleBackColor = true;
            this.UseTextCheckbox.CheckedChanged += new System.EventHandler(this.UseTextCheckbox_CheckedChanged);
            // 
            // CheckAncestorsCheckbox
            // 
            this.CheckAncestorsCheckbox.AutoSize = true;
            this.CheckAncestorsCheckbox.Checked = true;
            this.CheckAncestorsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckAncestorsCheckbox.Location = new System.Drawing.Point(141, 82);
            this.CheckAncestorsCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckAncestorsCheckbox.Name = "CheckAncestorsCheckbox";
            this.CheckAncestorsCheckbox.Size = new System.Drawing.Size(93, 21);
            this.CheckAncestorsCheckbox.TabIndex = 21;
            this.CheckAncestorsCheckbox.Text = "Ancestors";
            this.CheckAncestorsCheckbox.UseVisualStyleBackColor = true;
            this.CheckAncestorsCheckbox.CheckedChanged += new System.EventHandler(this.CheckAncestorsCheckbox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1072, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Max string length";
            // 
            // CheckSelfCheckbox
            // 
            this.CheckSelfCheckbox.AutoSize = true;
            this.CheckSelfCheckbox.Checked = true;
            this.CheckSelfCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckSelfCheckbox.Location = new System.Drawing.Point(75, 82);
            this.CheckSelfCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckSelfCheckbox.Name = "CheckSelfCheckbox";
            this.CheckSelfCheckbox.Size = new System.Drawing.Size(54, 21);
            this.CheckSelfCheckbox.TabIndex = 20;
            this.CheckSelfCheckbox.Text = "Self";
            this.CheckSelfCheckbox.UseVisualStyleBackColor = true;
            this.CheckSelfCheckbox.CheckedChanged += new System.EventHandler(this.CheckSelfCheckbox_CheckedChanged);
            // 
            // MaxAttLength
            // 
            this.MaxAttLength.Location = new System.Drawing.Point(1020, 16);
            this.MaxAttLength.Margin = new System.Windows.Forms.Padding(4);
            this.MaxAttLength.Name = "MaxAttLength";
            this.MaxAttLength.Size = new System.Drawing.Size(43, 22);
            this.MaxAttLength.TabIndex = 20;
            this.MaxAttLength.Text = "50";
            this.MaxAttLength.TextChanged += new System.EventHandler(this.MaxAttLength_TextChanged);
            // 
            // UseContainsCheckBox
            // 
            this.UseContainsCheckBox.AutoSize = true;
            this.UseContainsCheckBox.Checked = true;
            this.UseContainsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseContainsCheckBox.Location = new System.Drawing.Point(659, 20);
            this.UseContainsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.UseContainsCheckBox.Name = "UseContainsCheckBox";
            this.UseContainsCheckBox.Size = new System.Drawing.Size(124, 21);
            this.UseContainsCheckBox.TabIndex = 33;
            this.UseContainsCheckBox.Text = "Use Contains()";
            this.UseContainsCheckBox.UseVisualStyleBackColor = true;
            this.UseContainsCheckBox.CheckedChanged += new System.EventHandler(this.UseContainsCheckBox_CheckedChanged);
            // 
            // SkipAttLabel
            // 
            this.SkipAttLabel.AutoSize = true;
            this.SkipAttLabel.Location = new System.Drawing.Point(919, 21);
            this.SkipAttLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkipAttLabel.Name = "SkipAttLabel";
            this.SkipAttLabel.Size = new System.Drawing.Size(92, 17);
            this.SkipAttLabel.TabIndex = 32;
            this.SkipAttLabel.Text = "Skip Attribute";
            // 
            // SkipAttributeTextBox
            // 
            this.SkipAttributeTextBox.Location = new System.Drawing.Point(791, 17);
            this.SkipAttributeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SkipAttributeTextBox.Name = "SkipAttributeTextBox";
            this.SkipAttributeTextBox.Size = new System.Drawing.Size(119, 22);
            this.SkipAttributeTextBox.TabIndex = 31;
            this.SkipAttributeTextBox.TextChanged += new System.EventHandler(this.SkipAttributeTextBox_TextChanged);
            // 
            // SplitAttributesCheckbox
            // 
            this.SplitAttributesCheckbox.AutoSize = true;
            this.SplitAttributesCheckbox.Checked = true;
            this.SplitAttributesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SplitAttributesCheckbox.Location = new System.Drawing.Point(536, 18);
            this.SplitAttributesCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.SplitAttributesCheckbox.Name = "SplitAttributesCheckbox";
            this.SplitAttributesCheckbox.Size = new System.Drawing.Size(121, 21);
            this.SplitAttributesCheckbox.TabIndex = 30;
            this.SplitAttributesCheckbox.Text = "Split Attributes";
            this.SplitAttributesCheckbox.UseVisualStyleBackColor = true;
            this.SplitAttributesCheckbox.CheckedChanged += new System.EventHandler(this.SplitAttributesCheckbox_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Xpath";
            // 
            // GoToUrlButton
            // 
            this.GoToUrlButton.Location = new System.Drawing.Point(605, 42);
            this.GoToUrlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoToUrlButton.Name = "GoToUrlButton";
            this.GoToUrlButton.Size = new System.Drawing.Size(95, 23);
            this.GoToUrlButton.TabIndex = 14;
            this.GoToUrlButton.Text = "GoToUrl";
            this.GoToUrlButton.UseVisualStyleBackColor = true;
            this.GoToUrlButton.Click += new System.EventHandler(this.GoToUrlButton_Click);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(75, 42);
            this.UrlTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(524, 22);
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
            this.BrowserPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowserPanel.Name = "BrowserPanel";
            this.BrowserPanel.Size = new System.Drawing.Size(708, 82);
            this.BrowserPanel.TabIndex = 4;
            // 
            // LaunchBrowserButton
            // 
            this.LaunchBrowserButton.Location = new System.Drawing.Point(608, 14);
            this.LaunchBrowserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.HostTextBox.Location = new System.Drawing.Point(341, 14);
            this.HostTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(257, 22);
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
            this.BrowserDropdown.Location = new System.Drawing.Point(75, 12);
            this.BrowserDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.JavascriptPanel.Location = new System.Drawing.Point(713, 12);
            this.JavascriptPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JavascriptPanel.Name = "JavascriptPanel";
            this.JavascriptPanel.Size = new System.Drawing.Size(755, 82);
            this.JavascriptPanel.TabIndex = 8;
            this.JavascriptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Prebuilt Commands";
            // 
            // DisableOnClickButton
            // 
            this.DisableOnClickButton.Location = new System.Drawing.Point(213, 46);
            this.DisableOnClickButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisableOnClickButton.Name = "DisableOnClickButton";
            this.DisableOnClickButton.Size = new System.Drawing.Size(117, 23);
            this.DisableOnClickButton.TabIndex = 13;
            this.DisableOnClickButton.Text = "DisableOnClick";
            this.DisableOnClickButton.UseVisualStyleBackColor = true;
            this.DisableOnClickButton.Click += new System.EventHandler(this.DisableOnClickButton_Click);
            // 
            // DisableMouseOverButton
            // 
            this.DisableMouseOverButton.Location = new System.Drawing.Point(348, 46);
            this.DisableMouseOverButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisableMouseOverButton.Name = "DisableMouseOverButton";
            this.DisableMouseOverButton.Size = new System.Drawing.Size(143, 23);
            this.DisableMouseOverButton.TabIndex = 12;
            this.DisableMouseOverButton.Text = "Disable MouseOver";
            this.DisableMouseOverButton.UseVisualStyleBackColor = true;
            this.DisableMouseOverButton.Click += new System.EventHandler(this.DisableMouseOverButton_Click);
            // 
            // ExecuteJS
            // 
            this.ExecuteJS.Location = new System.Drawing.Point(657, 12);
            this.ExecuteJS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExecuteJS.Name = "ExecuteJS";
            this.ExecuteJS.Size = new System.Drawing.Size(93, 23);
            this.ExecuteJS.TabIndex = 2;
            this.ExecuteJS.Text = "Execute JS";
            this.ExecuteJS.UseVisualStyleBackColor = true;
            this.ExecuteJS.Click += new System.EventHandler(this.ExecuteJS_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Javascript";
            // 
            // JavscriptTextBox
            // 
            this.JavscriptTextBox.Location = new System.Drawing.Point(81, 10);
            this.JavscriptTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JavscriptTextBox.Name = "JavscriptTextBox";
            this.JavscriptTextBox.Size = new System.Drawing.Size(569, 22);
            this.JavscriptTextBox.TabIndex = 1;
            // 
            // HidePanelButton
            // 
            this.HidePanelButton.Location = new System.Drawing.Point(503, 46);
            this.HidePanelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HidePanelButton.Name = "HidePanelButton";
            this.HidePanelButton.Size = new System.Drawing.Size(145, 23);
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
            this.LogPanel.Location = new System.Drawing.Point(3, 428);
            this.LogPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(1466, 254);
            this.LogPanel.TabIndex = 7;
            this.LogPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new System.Drawing.Point(49, 6);
            this.ClearLogButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(75, 23);
            this.ClearLogButton.TabIndex = 2;
            this.ClearLogButton.Text = "Clear";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(7, 34);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(1437, 212);
            this.LogTextBox.TabIndex = 1;
            this.LogTextBox.Text = "";
            this.LogTextBox.TextChanged += new System.EventHandler(this.LogTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Log";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Specter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1360, 733);
            this.Controls.Add(this.JavascriptPanel);
            this.Controls.Add(this.BrowserPanel);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.XpathPanel);
            this.Controls.Add(this.ElementPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Specter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProtoTest.Specter";
            this.Load += new System.EventHandler(this.Specter_Load);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox UseContainsCheckBox;
        private System.Windows.Forms.Label SkipAttLabel;
        private System.Windows.Forms.TextBox SkipAttributeTextBox;
        private System.Windows.Forms.CheckBox SplitAttributesCheckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RefreshTimeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MaxAttLength;
        private System.Windows.Forms.CheckBox UseQuotesCheckbox;
        private System.Windows.Forms.CheckBox UseTextCheckbox;
        private System.Windows.Forms.CheckBox CheckCousinsCheckbox;
        private System.Windows.Forms.CheckBox CheckChildrenCheckbox;
        private System.Windows.Forms.CheckBox CheckSiblingsCheckbox;
        private System.Windows.Forms.CheckBox CheckAncestorsCheckbox;
        private System.Windows.Forms.CheckBox CheckSelfCheckbox;
    }
}

