using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProtoTest.Specter
{
    partial class Specter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.WebDriverCommandText = new System.Windows.Forms.TextBox();
            this.WebDriverCommandDropdown = new System.Windows.Forms.ComboBox();
            this.MinimumXpathsTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ExecuteCommandButton = new System.Windows.Forms.Button();
            this.GenerateXPathLocatorsButton = new System.Windows.Forms.Button();
            this.XpathsDropdown = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GetParentButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.XPathGeneratorMaxAttempts = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
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
            this.ExecuteJS = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.XPathGenerator_tab = new System.Windows.Forms.TabPage();
            this.Browser_Panel = new System.Windows.Forms.Panel();
            this.Step1_Label = new System.Windows.Forms.Label();
            this.Browser_label = new System.Windows.Forms.Label();
            this.GoToUrlButton = new System.Windows.Forms.Button();
            this.BrowserDropdown = new System.Windows.Forms.ComboBox();
            this.LaunchBrowserButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.XPathSectionLocatorUsePanel = new System.Windows.Forms.Panel();
            this.BuildElement_button = new System.Windows.Forms.Button();
            this.VerifyXPathLocatorOnPage = new System.Windows.Forms.Button();
            this.XPathLocatorExecuteWebdriver = new System.Windows.Forms.Label();
            this.CopyXPathToClipboard = new System.Windows.Forms.Button();
            this.XPathSectionXPathGeneratePanel = new System.Windows.Forms.Panel();
            this.XPathSectionLocatorChoose = new System.Windows.Forms.Label();
            this.XPathSectionLocatorGeneration = new System.Windows.Forms.Label();
            this.XPathSectionLoadElementPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.XPathSectionLoadWebsiteElement = new System.Windows.Forms.Label();
            this.RegisterLeftClickButton = new System.Windows.Forms.Button();
            this.RegisterRightClickButton = new System.Windows.Forms.Button();
            this.RefreshTimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WebText = new System.Windows.Forms.WebBrowser();
            this.Elements_tab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetPageObjectButton = new System.Windows.Forms.Button();
            this.CopyElementsToClipboard_button = new System.Windows.Forms.Button();
            this.ClearElements_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Elements_rtb = new System.Windows.Forms.RichTextBox();
            this.JavaScript_tab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.JavscriptTextBox = new System.Windows.Forms.TextBox();
            this.HidePanelButton = new System.Windows.Forms.Button();
            this.DisableMouseOverButton = new System.Windows.Forms.Button();
            this.DisableOnClickButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ErrorLog_tab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.Help_tab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Help1Textbox1 = new System.Windows.Forms.TextBox();
            this.HelpHeader1 = new System.Windows.Forms.Label();
            this.Setting_tab = new System.Windows.Forms.TabPage();
            this.Settings_Panel = new System.Windows.Forms.Panel();
            this.DefaultUrl_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ColorPicker_Link = new System.Windows.Forms.LinkLabel();
            this.DefaultBrowser_cb = new System.Windows.Forms.ComboBox();
            this.defaultBrowser_label = new System.Windows.Forms.Label();
            this.UIToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainTabControl.SuspendLayout();
            this.XPathGenerator_tab.SuspendLayout();
            this.Browser_Panel.SuspendLayout();
            this.XPathSectionLocatorUsePanel.SuspendLayout();
            this.XPathSectionXPathGeneratePanel.SuspendLayout();
            this.XPathSectionLoadElementPanel.SuspendLayout();
            this.Elements_tab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.JavaScript_tab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ErrorLog_tab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Help_tab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Setting_tab.SuspendLayout();
            this.Settings_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebDriverCommandText
            // 
            this.WebDriverCommandText.AccessibleName = "WebDriverCommandText_textbox";
            this.WebDriverCommandText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.WebDriverCommandText.Location = new System.Drawing.Point(473, 69);
            this.WebDriverCommandText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WebDriverCommandText.Multiline = true;
            this.WebDriverCommandText.Name = "WebDriverCommandText";
            this.WebDriverCommandText.Size = new System.Drawing.Size(292, 24);
            this.WebDriverCommandText.TabIndex = 20;
            this.WebDriverCommandText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // WebDriverCommandDropdown
            // 
            this.WebDriverCommandDropdown.AccessibleName = "ExecuteWebDriverCommand_dropdown";
            this.WebDriverCommandDropdown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.WebDriverCommandDropdown.DisplayMember = "1";
            this.WebDriverCommandDropdown.FormattingEnabled = true;
            this.WebDriverCommandDropdown.Items.AddRange(new object[] {
            "Find",
            "Click",
            "MouseOver",
            "Type",
            "Count"});
            this.WebDriverCommandDropdown.Location = new System.Drawing.Point(223, 69);
            this.WebDriverCommandDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WebDriverCommandDropdown.Name = "WebDriverCommandDropdown";
            this.WebDriverCommandDropdown.Size = new System.Drawing.Size(245, 21);
            this.WebDriverCommandDropdown.TabIndex = 19;
            this.WebDriverCommandDropdown.SelectedIndexChanged += new System.EventHandler(this.WebDriverCommandDropdown_SelectedIndexChanged);
            // 
            // MinimumXpathsTextBox
            // 
            this.MinimumXpathsTextBox.AccessibleName = "MinNumGenerated_textbox";
            this.MinimumXpathsTextBox.Location = new System.Drawing.Point(165, 32);
            this.MinimumXpathsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumXpathsTextBox.Name = "MinimumXpathsTextBox";
            this.MinimumXpathsTextBox.Size = new System.Drawing.Size(39, 20);
            this.MinimumXpathsTextBox.TabIndex = 17;
            this.MinimumXpathsTextBox.Text = "3";
            this.MinimumXpathsTextBox.TextChanged += new System.EventHandler(this.MinimumXpathsTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Minimum # Generated:";
            // 
            // ExecuteCommandButton
            // 
            this.ExecuteCommandButton.AccessibleName = "Execute_button";
            this.ExecuteCommandButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExecuteCommandButton.Location = new System.Drawing.Point(772, 69);
            this.ExecuteCommandButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExecuteCommandButton.Name = "ExecuteCommandButton";
            this.ExecuteCommandButton.Size = new System.Drawing.Size(93, 25);
            this.ExecuteCommandButton.TabIndex = 4;
            this.ExecuteCommandButton.Text = "Execute";
            this.ExecuteCommandButton.UseVisualStyleBackColor = true;
            this.ExecuteCommandButton.Click += new System.EventHandler(this.ClickXpathButton_Click);
            // 
            // GenerateXPathLocatorsButton
            // 
            this.GenerateXPathLocatorsButton.AccessibleName = "GenerateXpathLocators_button";
            this.GenerateXPathLocatorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GenerateXPathLocatorsButton.Location = new System.Drawing.Point(9, 148);
            this.GenerateXPathLocatorsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateXPathLocatorsButton.Name = "GenerateXPathLocatorsButton";
            this.GenerateXPathLocatorsButton.Size = new System.Drawing.Size(195, 30);
            this.GenerateXPathLocatorsButton.TabIndex = 3;
            this.GenerateXPathLocatorsButton.Text = "Generate XPath Locators";
            this.GenerateXPathLocatorsButton.UseVisualStyleBackColor = true;
            this.GenerateXPathLocatorsButton.Click += new System.EventHandler(this.GenerateXpathButton_Click);
            // 
            // XpathsDropdown
            // 
            this.XpathsDropdown.AccessibleName = "ChooseLocator_dropdown";
            this.XpathsDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XpathsDropdown.FormattingEnabled = true;
            this.XpathsDropdown.Location = new System.Drawing.Point(123, 183);
            this.XpathsDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XpathsDropdown.MaxDropDownItems = 20;
            this.XpathsDropdown.Name = "XpathsDropdown";
            this.XpathsDropdown.Size = new System.Drawing.Size(432, 21);
            this.XpathsDropdown.TabIndex = 0;
            this.XpathsDropdown.SelectedIndexChanged += new System.EventHandler(this.XpathsDropdown_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.AccessibleName = "FindChild_Button";
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(15, 202);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 30);
            this.button2.TabIndex = 17;
            this.button2.Text = "Find Element\'s Child";
            this.UIToolTip.SetToolTip(this.button2, "Finds the currently selected elements children.");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "FindSibling_button";
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(187, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Find Element\'s Sibling";
            this.UIToolTip.SetToolTip(this.button1, "Finds the sibling of the selected element.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetParentButton
            // 
            this.GetParentButton.AccessibleName = "FindParent_button";
            this.GetParentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GetParentButton.Location = new System.Drawing.Point(359, 202);
            this.GetParentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetParentButton.Name = "GetParentButton";
            this.GetParentButton.Size = new System.Drawing.Size(165, 30);
            this.GetParentButton.TabIndex = 10;
            this.GetParentButton.Text = "Find Element\'s Parent";
            this.UIToolTip.SetToolTip(this.GetParentButton, "Find the parents of the currently selected element.");
            this.GetParentButton.UseVisualStyleBackColor = true;
            this.GetParentButton.Click += new System.EventHandler(this.GetParentButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Max # Attempts";
            // 
            // XPathGeneratorMaxAttempts
            // 
            this.XPathGeneratorMaxAttempts.AccessibleName = "MaxNumGenerated_textbox";
            this.XPathGeneratorMaxAttempts.Location = new System.Drawing.Point(165, 58);
            this.XPathGeneratorMaxAttempts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XPathGeneratorMaxAttempts.Name = "XPathGeneratorMaxAttempts";
            this.XPathGeneratorMaxAttempts.Size = new System.Drawing.Size(39, 20);
            this.XPathGeneratorMaxAttempts.TabIndex = 26;
            this.XPathGeneratorMaxAttempts.Text = "100";
            this.XPathGeneratorMaxAttempts.TextChanged += new System.EventHandler(this.XPathGeneratorMaxAttempts_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Step 4 - Use/Test Locator";
            // 
            // CheckCousinsCheckbox
            // 
            this.CheckCousinsCheckbox.AccessibleName = "Cousins_checkbox";
            this.CheckCousinsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckCousinsCheckbox.AutoSize = true;
            this.CheckCousinsCheckbox.Checked = true;
            this.CheckCousinsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCousinsCheckbox.Location = new System.Drawing.Point(907, 187);
            this.CheckCousinsCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckCousinsCheckbox.Name = "CheckCousinsCheckbox";
            this.CheckCousinsCheckbox.Size = new System.Drawing.Size(63, 17);
            this.CheckCousinsCheckbox.TabIndex = 37;
            this.CheckCousinsCheckbox.Text = "Cousins";
            this.CheckCousinsCheckbox.UseVisualStyleBackColor = true;
            this.CheckCousinsCheckbox.CheckedChanged += new System.EventHandler(this.CheckCousinsCheckbox_CheckedChanged);
            // 
            // CheckChildrenCheckbox
            // 
            this.CheckChildrenCheckbox.AccessibleName = "Children_checkbox";
            this.CheckChildrenCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckChildrenCheckbox.AutoSize = true;
            this.CheckChildrenCheckbox.Checked = true;
            this.CheckChildrenCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckChildrenCheckbox.Location = new System.Drawing.Point(825, 187);
            this.CheckChildrenCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckChildrenCheckbox.Name = "CheckChildrenCheckbox";
            this.CheckChildrenCheckbox.Size = new System.Drawing.Size(64, 17);
            this.CheckChildrenCheckbox.TabIndex = 23;
            this.CheckChildrenCheckbox.Text = "Children";
            this.CheckChildrenCheckbox.UseVisualStyleBackColor = true;
            this.CheckChildrenCheckbox.CheckedChanged += new System.EventHandler(this.CheckChildrenCheckbox_CheckedChanged);
            // 
            // UseQuotesCheckbox
            // 
            this.UseQuotesCheckbox.AccessibleName = "UseDoubleQuotes_checkbox";
            this.UseQuotesCheckbox.AutoSize = true;
            this.UseQuotesCheckbox.Checked = true;
            this.UseQuotesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseQuotesCheckbox.Location = new System.Drawing.Point(235, 60);
            this.UseQuotesCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.UseQuotesCheckbox.Name = "UseQuotesCheckbox";
            this.UseQuotesCheckbox.Size = new System.Drawing.Size(119, 17);
            this.UseQuotesCheckbox.TabIndex = 36;
            this.UseQuotesCheckbox.Text = "Use Double Quotes";
            this.UseQuotesCheckbox.UseVisualStyleBackColor = true;
            this.UseQuotesCheckbox.CheckedChanged += new System.EventHandler(this.UseQuotesCheckbox_CheckedChanged);
            // 
            // CheckSiblingsCheckbox
            // 
            this.CheckSiblingsCheckbox.AccessibleName = "Siblings_checkbox";
            this.CheckSiblingsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckSiblingsCheckbox.AutoSize = true;
            this.CheckSiblingsCheckbox.Checked = true;
            this.CheckSiblingsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckSiblingsCheckbox.Location = new System.Drawing.Point(748, 187);
            this.CheckSiblingsCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckSiblingsCheckbox.Name = "CheckSiblingsCheckbox";
            this.CheckSiblingsCheckbox.Size = new System.Drawing.Size(62, 17);
            this.CheckSiblingsCheckbox.TabIndex = 22;
            this.CheckSiblingsCheckbox.Text = "Siblings";
            this.CheckSiblingsCheckbox.UseVisualStyleBackColor = true;
            this.CheckSiblingsCheckbox.CheckedChanged += new System.EventHandler(this.CheckSiblingsCheckbox_CheckedChanged);
            // 
            // UseTextCheckbox
            // 
            this.UseTextCheckbox.AccessibleName = "UseText_checkbox";
            this.UseTextCheckbox.AutoSize = true;
            this.UseTextCheckbox.Location = new System.Drawing.Point(235, 89);
            this.UseTextCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.UseTextCheckbox.Name = "UseTextCheckbox";
            this.UseTextCheckbox.Size = new System.Drawing.Size(71, 17);
            this.UseTextCheckbox.TabIndex = 35;
            this.UseTextCheckbox.Text = "Use text()";
            this.UIToolTip.SetToolTip(this.UseTextCheckbox, "Determines whether or not to include text in the attribute list for the Locator.");
            this.UseTextCheckbox.UseVisualStyleBackColor = true;
            this.UseTextCheckbox.CheckedChanged += new System.EventHandler(this.UseTextCheckbox_CheckedChanged);
            // 
            // CheckAncestorsCheckbox
            // 
            this.CheckAncestorsCheckbox.AccessibleName = "Ancestors_checkbox";
            this.CheckAncestorsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckAncestorsCheckbox.AutoSize = true;
            this.CheckAncestorsCheckbox.Checked = true;
            this.CheckAncestorsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckAncestorsCheckbox.Location = new System.Drawing.Point(651, 187);
            this.CheckAncestorsCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckAncestorsCheckbox.Name = "CheckAncestorsCheckbox";
            this.CheckAncestorsCheckbox.Size = new System.Drawing.Size(73, 17);
            this.CheckAncestorsCheckbox.TabIndex = 21;
            this.CheckAncestorsCheckbox.Text = "Ancestors";
            this.CheckAncestorsCheckbox.UseVisualStyleBackColor = true;
            this.CheckAncestorsCheckbox.CheckedChanged += new System.EventHandler(this.CheckAncestorsCheckbox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Max # characters:";
            // 
            // CheckSelfCheckbox
            // 
            this.CheckSelfCheckbox.AccessibleName = "Self_checkbox";
            this.CheckSelfCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckSelfCheckbox.AutoSize = true;
            this.CheckSelfCheckbox.Checked = true;
            this.CheckSelfCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckSelfCheckbox.Location = new System.Drawing.Point(579, 187);
            this.CheckSelfCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckSelfCheckbox.Name = "CheckSelfCheckbox";
            this.CheckSelfCheckbox.Size = new System.Drawing.Size(44, 17);
            this.CheckSelfCheckbox.TabIndex = 20;
            this.CheckSelfCheckbox.Text = "Self";
            this.CheckSelfCheckbox.UseVisualStyleBackColor = true;
            this.CheckSelfCheckbox.CheckedChanged += new System.EventHandler(this.CheckSelfCheckbox_CheckedChanged);
            // 
            // MaxAttLength
            // 
            this.MaxAttLength.AccessibleName = "MaxCharactersGenerated_textbox";
            this.MaxAttLength.Location = new System.Drawing.Point(165, 86);
            this.MaxAttLength.Margin = new System.Windows.Forms.Padding(4);
            this.MaxAttLength.Name = "MaxAttLength";
            this.MaxAttLength.Size = new System.Drawing.Size(39, 20);
            this.MaxAttLength.TabIndex = 20;
            this.MaxAttLength.Text = "50";
            this.MaxAttLength.TextChanged += new System.EventHandler(this.MaxAttLength_TextChanged);
            // 
            // UseContainsCheckBox
            // 
            this.UseContainsCheckBox.AccessibleName = "UseContains_checkbox";
            this.UseContainsCheckBox.AutoSize = true;
            this.UseContainsCheckBox.Checked = true;
            this.UseContainsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseContainsCheckBox.Location = new System.Drawing.Point(235, 118);
            this.UseContainsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.UseContainsCheckBox.Name = "UseContainsCheckBox";
            this.UseContainsCheckBox.Size = new System.Drawing.Size(95, 17);
            this.UseContainsCheckBox.TabIndex = 33;
            this.UseContainsCheckBox.Text = "Use Contains()";
            this.UseContainsCheckBox.UseVisualStyleBackColor = true;
            this.UseContainsCheckBox.CheckedChanged += new System.EventHandler(this.UseContainsCheckBox_CheckedChanged);
            // 
            // SkipAttLabel
            // 
            this.SkipAttLabel.AutoSize = true;
            this.SkipAttLabel.Location = new System.Drawing.Point(429, 30);
            this.SkipAttLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkipAttLabel.Name = "SkipAttLabel";
            this.SkipAttLabel.Size = new System.Drawing.Size(136, 13);
            this.SkipAttLabel.TabIndex = 32;
            this.SkipAttLabel.Text = "Do not use HTML attribute:";
            // 
            // SkipAttributeTextBox
            // 
            this.SkipAttributeTextBox.AccessibleName = "DoNOTuseHTML_textbox";
            this.SkipAttributeTextBox.Location = new System.Drawing.Point(608, 28);
            this.SkipAttributeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SkipAttributeTextBox.Name = "SkipAttributeTextBox";
            this.SkipAttributeTextBox.Size = new System.Drawing.Size(119, 20);
            this.SkipAttributeTextBox.TabIndex = 31;
            this.UIToolTip.SetToolTip(this.SkipAttributeTextBox, "The value entered into this field will be ignored when building xpaths.");
            this.SkipAttributeTextBox.TextChanged += new System.EventHandler(this.SkipAttributeTextBox_TextChanged);
            // 
            // SplitAttributesCheckbox
            // 
            this.SplitAttributesCheckbox.AccessibleName = "SplitAttributes_Checkbox";
            this.SplitAttributesCheckbox.AutoSize = true;
            this.SplitAttributesCheckbox.Checked = true;
            this.SplitAttributesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SplitAttributesCheckbox.Location = new System.Drawing.Point(235, 30);
            this.SplitAttributesCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.SplitAttributesCheckbox.Name = "SplitAttributesCheckbox";
            this.SplitAttributesCheckbox.Size = new System.Drawing.Size(93, 17);
            this.SplitAttributesCheckbox.TabIndex = 30;
            this.SplitAttributesCheckbox.Text = "Split Attributes";
            this.SplitAttributesCheckbox.UseVisualStyleBackColor = true;
            this.SplitAttributesCheckbox.CheckedChanged += new System.EventHandler(this.SplitAttributesCheckbox_CheckedChanged);
            // 
            // ExecuteJS
            // 
            this.ExecuteJS.Location = new System.Drawing.Point(581, 27);
            this.ExecuteJS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExecuteJS.Name = "ExecuteJS";
            this.ExecuteJS.Size = new System.Drawing.Size(141, 34);
            this.ExecuteJS.TabIndex = 2;
            this.ExecuteJS.Text = "Execute Javascript";
            this.ExecuteJS.UseVisualStyleBackColor = true;
            this.ExecuteJS.Click += new System.EventHandler(this.ExecuteJS_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.XPathGenerator_tab);
            this.MainTabControl.Controls.Add(this.Elements_tab);
            this.MainTabControl.Controls.Add(this.JavaScript_tab);
            this.MainTabControl.Controls.Add(this.ErrorLog_tab);
            this.MainTabControl.Controls.Add(this.Help_tab);
            this.MainTabControl.Controls.Add(this.Setting_tab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.ShowToolTips = true;
            this.MainTabControl.Size = new System.Drawing.Size(1005, 709);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.MainTabControl.TabIndex = 9;
            // 
            // XPathGenerator_tab
            // 
            this.XPathGenerator_tab.AccessibleName = "XpathGenerator_tab";
            this.XPathGenerator_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.XPathGenerator_tab.Controls.Add(this.Browser_Panel);
            this.XPathGenerator_tab.Controls.Add(this.XPathSectionLocatorUsePanel);
            this.XPathGenerator_tab.Controls.Add(this.XPathSectionXPathGeneratePanel);
            this.XPathGenerator_tab.Controls.Add(this.XPathSectionLoadElementPanel);
            this.XPathGenerator_tab.Location = new System.Drawing.Point(4, 22);
            this.XPathGenerator_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XPathGenerator_tab.Name = "XPathGenerator_tab";
            this.XPathGenerator_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XPathGenerator_tab.Size = new System.Drawing.Size(997, 683);
            this.XPathGenerator_tab.TabIndex = 0;
            this.XPathGenerator_tab.Text = "XPath Generation";
            this.XPathGenerator_tab.ToolTipText = "Record a site element, then generate and test the XPath locators.";
            // 
            // Browser_Panel
            // 
            this.Browser_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Browser_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.Browser_Panel.Controls.Add(this.Step1_Label);
            this.Browser_Panel.Controls.Add(this.Browser_label);
            this.Browser_Panel.Controls.Add(this.GoToUrlButton);
            this.Browser_Panel.Controls.Add(this.BrowserDropdown);
            this.Browser_Panel.Controls.Add(this.LaunchBrowserButton);
            this.Browser_Panel.Controls.Add(this.label3);
            this.Browser_Panel.Controls.Add(this.UrlTextBox);
            this.Browser_Panel.Controls.Add(this.label6);
            this.Browser_Panel.Controls.Add(this.HostTextBox);
            this.Browser_Panel.Location = new System.Drawing.Point(5, 5);
            this.Browser_Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Browser_Panel.Name = "Browser_Panel";
            this.Browser_Panel.Size = new System.Drawing.Size(981, 94);
            this.Browser_Panel.TabIndex = 42;
            // 
            // Step1_Label
            // 
            this.Step1_Label.AutoSize = true;
            this.Step1_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.Step1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step1_Label.Location = new System.Drawing.Point(5, 5);
            this.Step1_Label.Name = "Step1_Label";
            this.Step1_Label.Size = new System.Drawing.Size(147, 17);
            this.Step1_Label.TabIndex = 39;
            this.Step1_Label.Text = "Step 1 - Start Browser";
            // 
            // Browser_label
            // 
            this.Browser_label.AutoSize = true;
            this.Browser_label.Location = new System.Drawing.Point(5, 30);
            this.Browser_label.Name = "Browser_label";
            this.Browser_label.Size = new System.Drawing.Size(48, 13);
            this.Browser_label.TabIndex = 7;
            this.Browser_label.Text = "Browser:";
            // 
            // GoToUrlButton
            // 
            this.GoToUrlButton.AccessibleName = "GotoURL_button";
            this.GoToUrlButton.Location = new System.Drawing.Point(608, 57);
            this.GoToUrlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoToUrlButton.Name = "GoToUrlButton";
            this.GoToUrlButton.Size = new System.Drawing.Size(95, 30);
            this.GoToUrlButton.TabIndex = 14;
            this.GoToUrlButton.Text = "GoToUrl";
            this.GoToUrlButton.UseVisualStyleBackColor = true;
            this.GoToUrlButton.Click += new System.EventHandler(this.GoToUrlButton_Click);
            // 
            // BrowserDropdown
            // 
            this.BrowserDropdown.AccessibleName = "BrowserSelector";
            this.BrowserDropdown.DisplayMember = "1";
            this.BrowserDropdown.FormattingEnabled = true;
            this.BrowserDropdown.Items.AddRange(new object[] {
            "Firefox",
            "Chrome",
            "IE",
            "Safari",
            "Android"});
            this.BrowserDropdown.Location = new System.Drawing.Point(75, 26);
            this.BrowserDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowserDropdown.Name = "BrowserDropdown";
            this.BrowserDropdown.Size = new System.Drawing.Size(219, 21);
            this.BrowserDropdown.TabIndex = 8;
            this.BrowserDropdown.SelectedIndexChanged += new System.EventHandler(this.BrowserDropdown_SelectedIndexChanged);
            // 
            // LaunchBrowserButton
            // 
            this.LaunchBrowserButton.AccessibleName = "LaunchBrowser_Button";
            this.LaunchBrowserButton.Location = new System.Drawing.Point(300, 22);
            this.LaunchBrowserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LaunchBrowserButton.Name = "LaunchBrowserButton";
            this.LaunchBrowserButton.Size = new System.Drawing.Size(191, 30);
            this.LaunchBrowserButton.TabIndex = 11;
            this.LaunchBrowserButton.Text = "Launch Browser";
            this.UIToolTip.SetToolTip(this.LaunchBrowserButton, "This Launches a browser duh!");
            this.LaunchBrowserButton.UseVisualStyleBackColor = true;
            this.LaunchBrowserButton.Click += new System.EventHandler(this.LaunchBrowserButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Host IP:";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.AccessibleName = "URL_textbox";
            this.UrlTextBox.Location = new System.Drawing.Point(76, 60);
            this.UrlTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(524, 20);
            this.UrlTextBox.TabIndex = 13;
            this.UrlTextBox.TextChanged += new System.EventHandler(this.UrlTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "URL:";
            // 
            // HostTextBox
            // 
            this.HostTextBox.AccessibleName = "Localhost_textbox";
            this.HostTextBox.Location = new System.Drawing.Point(561, 26);
            this.HostTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(257, 20);
            this.HostTextBox.TabIndex = 9;
            this.HostTextBox.Text = "localhost";
            this.UIToolTip.SetToolTip(this.HostTextBox, "localHost will target this computer. To Luanch on a remote system, enter the targ" +
        "et\'s IP address.");
            this.HostTextBox.TextChanged += new System.EventHandler(this.HostTextBox_TextChanged);
            // 
            // XPathSectionLocatorUsePanel
            // 
            this.XPathSectionLocatorUsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XPathSectionLocatorUsePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.XPathSectionLocatorUsePanel.Controls.Add(this.BuildElement_button);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.VerifyXPathLocatorOnPage);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.XPathLocatorExecuteWebdriver);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.CopyXPathToClipboard);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.WebDriverCommandDropdown);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.WebDriverCommandText);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.label14);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.ExecuteCommandButton);
            this.XPathSectionLocatorUsePanel.Location = new System.Drawing.Point(5, 569);
            this.XPathSectionLocatorUsePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XPathSectionLocatorUsePanel.Name = "XPathSectionLocatorUsePanel";
            this.XPathSectionLocatorUsePanel.Size = new System.Drawing.Size(981, 107);
            this.XPathSectionLocatorUsePanel.TabIndex = 41;
            // 
            // BuildElement_button
            // 
            this.BuildElement_button.AccessibleName = "ShowXpathLocator_button";
            this.BuildElement_button.Location = new System.Drawing.Point(473, 34);
            this.BuildElement_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuildElement_button.Name = "BuildElement_button";
            this.BuildElement_button.Size = new System.Drawing.Size(213, 32);
            this.BuildElement_button.TabIndex = 32;
            this.BuildElement_button.Text = "Build Golem Element";
            this.BuildElement_button.UseVisualStyleBackColor = true;
            this.BuildElement_button.Click += new System.EventHandler(this.BuildElement_button_Click);
            // 
            // VerifyXPathLocatorOnPage
            // 
            this.VerifyXPathLocatorOnPage.AccessibleName = "ShowXpathLocator_button";
            this.VerifyXPathLocatorOnPage.Location = new System.Drawing.Point(248, 34);
            this.VerifyXPathLocatorOnPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VerifyXPathLocatorOnPage.Name = "VerifyXPathLocatorOnPage";
            this.VerifyXPathLocatorOnPage.Size = new System.Drawing.Size(213, 32);
            this.VerifyXPathLocatorOnPage.TabIndex = 30;
            this.VerifyXPathLocatorOnPage.Text = "Show XPath Locator on page";
            this.VerifyXPathLocatorOnPage.UseVisualStyleBackColor = true;
            this.VerifyXPathLocatorOnPage.Click += new System.EventHandler(this.VerifyXPathLocatorOnPage_Click);
            // 
            // XPathLocatorExecuteWebdriver
            // 
            this.XPathLocatorExecuteWebdriver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XPathLocatorExecuteWebdriver.AutoSize = true;
            this.XPathLocatorExecuteWebdriver.Location = new System.Drawing.Point(12, 73);
            this.XPathLocatorExecuteWebdriver.Name = "XPathLocatorExecuteWebdriver";
            this.XPathLocatorExecuteWebdriver.Size = new System.Drawing.Size(148, 13);
            this.XPathLocatorExecuteWebdriver.TabIndex = 28;
            this.XPathLocatorExecuteWebdriver.Text = "Execute Webdriver Command";
            // 
            // CopyXPathToClipboard
            // 
            this.CopyXPathToClipboard.AccessibleName = "CopyXpathtoclipboard_button";
            this.CopyXPathToClipboard.Location = new System.Drawing.Point(9, 34);
            this.CopyXPathToClipboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CopyXPathToClipboard.Name = "CopyXPathToClipboard";
            this.CopyXPathToClipboard.Size = new System.Drawing.Size(231, 32);
            this.CopyXPathToClipboard.TabIndex = 29;
            this.CopyXPathToClipboard.Text = "Copy XPath Locator to Clipboard";
            this.CopyXPathToClipboard.UseVisualStyleBackColor = true;
            this.CopyXPathToClipboard.Click += new System.EventHandler(this.CopyXPathToClipboard_Click);
            // 
            // XPathSectionXPathGeneratePanel
            // 
            this.XPathSectionXPathGeneratePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XPathSectionXPathGeneratePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.XPathSectionLocatorChoose);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.XPathSectionLocatorGeneration);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.GenerateXPathLocatorsButton);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.label8);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.MinimumXpathsTextBox);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.label13);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.XPathGeneratorMaxAttempts);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.CheckCousinsCheckbox);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.SplitAttributesCheckbox);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.CheckChildrenCheckbox);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.UseContainsCheckBox);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.CheckSiblingsCheckbox);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.CheckAncestorsCheckbox);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.SkipAttributeTextBox);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.CheckSelfCheckbox);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.UseQuotesCheckbox);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.SkipAttLabel);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.XpathsDropdown);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.label9);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.MaxAttLength);
            this.XPathSectionXPathGeneratePanel.Controls.Add(this.UseTextCheckbox);
            this.XPathSectionXPathGeneratePanel.Location = new System.Drawing.Point(5, 345);
            this.XPathSectionXPathGeneratePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XPathSectionXPathGeneratePanel.Name = "XPathSectionXPathGeneratePanel";
            this.XPathSectionXPathGeneratePanel.Size = new System.Drawing.Size(981, 219);
            this.XPathSectionXPathGeneratePanel.TabIndex = 40;
            // 
            // XPathSectionLocatorChoose
            // 
            this.XPathSectionLocatorChoose.AutoSize = true;
            this.XPathSectionLocatorChoose.Location = new System.Drawing.Point(11, 185);
            this.XPathSectionLocatorChoose.Name = "XPathSectionLocatorChoose";
            this.XPathSectionLocatorChoose.Size = new System.Drawing.Size(81, 13);
            this.XPathSectionLocatorChoose.TabIndex = 38;
            this.XPathSectionLocatorChoose.Text = "Choose locator:";
            // 
            // XPathSectionLocatorGeneration
            // 
            this.XPathSectionLocatorGeneration.AutoSize = true;
            this.XPathSectionLocatorGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XPathSectionLocatorGeneration.Location = new System.Drawing.Point(5, 6);
            this.XPathSectionLocatorGeneration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XPathSectionLocatorGeneration.Name = "XPathSectionLocatorGeneration";
            this.XPathSectionLocatorGeneration.Size = new System.Drawing.Size(223, 17);
            this.XPathSectionLocatorGeneration.TabIndex = 29;
            this.XPathSectionLocatorGeneration.Text = "Step 3 - Generate XPath Locators";
            // 
            // XPathSectionLoadElementPanel
            // 
            this.XPathSectionLoadElementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XPathSectionLoadElementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.XPathSectionLoadElementPanel.Controls.Add(this.label1);
            this.XPathSectionLoadElementPanel.Controls.Add(this.XPathSectionLoadWebsiteElement);
            this.XPathSectionLoadElementPanel.Controls.Add(this.RegisterLeftClickButton);
            this.XPathSectionLoadElementPanel.Controls.Add(this.RegisterRightClickButton);
            this.XPathSectionLoadElementPanel.Controls.Add(this.RefreshTimeTextBox);
            this.XPathSectionLoadElementPanel.Controls.Add(this.label4);
            this.XPathSectionLoadElementPanel.Controls.Add(this.GetParentButton);
            this.XPathSectionLoadElementPanel.Controls.Add(this.button1);
            this.XPathSectionLoadElementPanel.Controls.Add(this.button2);
            this.XPathSectionLoadElementPanel.Controls.Add(this.WebText);
            this.XPathSectionLoadElementPanel.Location = new System.Drawing.Point(5, 103);
            this.XPathSectionLoadElementPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XPathSectionLoadElementPanel.Name = "XPathSectionLoadElementPanel";
            this.XPathSectionLoadElementPanel.Size = new System.Drawing.Size(981, 237);
            this.XPathSectionLoadElementPanel.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Current Element (extracted from website):";
            // 
            // XPathSectionLoadWebsiteElement
            // 
            this.XPathSectionLoadWebsiteElement.AutoSize = true;
            this.XPathSectionLoadWebsiteElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.XPathSectionLoadWebsiteElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XPathSectionLoadWebsiteElement.Location = new System.Drawing.Point(5, 5);
            this.XPathSectionLoadWebsiteElement.Name = "XPathSectionLoadWebsiteElement";
            this.XPathSectionLoadWebsiteElement.Size = new System.Drawing.Size(204, 17);
            this.XPathSectionLoadWebsiteElement.TabIndex = 38;
            this.XPathSectionLoadWebsiteElement.Text = "Step 2 - Load Website Element";
            // 
            // RegisterLeftClickButton
            // 
            this.RegisterLeftClickButton.AccessibleName = "CaptureElement_LeftClick_Button";
            this.RegisterLeftClickButton.Location = new System.Drawing.Point(9, 42);
            this.RegisterLeftClickButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterLeftClickButton.Name = "RegisterLeftClickButton";
            this.RegisterLeftClickButton.Size = new System.Drawing.Size(219, 30);
            this.RegisterLeftClickButton.TabIndex = 21;
            this.RegisterLeftClickButton.Text = "Capture Element with Left-click";
            this.RegisterLeftClickButton.UseVisualStyleBackColor = true;
            this.RegisterLeftClickButton.Click += new System.EventHandler(this.RegisterLeftClickButton_Click);
            // 
            // RegisterRightClickButton
            // 
            this.RegisterRightClickButton.AccessibleName = "CaptureElement_RightClick_button";
            this.RegisterRightClickButton.Location = new System.Drawing.Point(232, 42);
            this.RegisterRightClickButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterRightClickButton.Name = "RegisterRightClickButton";
            this.RegisterRightClickButton.Size = new System.Drawing.Size(228, 30);
            this.RegisterRightClickButton.TabIndex = 22;
            this.RegisterRightClickButton.Text = "Capture Element with Right-click";
            this.RegisterRightClickButton.UseVisualStyleBackColor = true;
            this.RegisterRightClickButton.Click += new System.EventHandler(this.RegisterRightClickButton_Click);
            // 
            // RefreshTimeTextBox
            // 
            this.RefreshTimeTextBox.AccessibleName = "RefreshTimer_textbox";
            this.RefreshTimeTextBox.Location = new System.Drawing.Point(608, 48);
            this.RefreshTimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshTimeTextBox.Name = "RefreshTimeTextBox";
            this.RefreshTimeTextBox.Size = new System.Drawing.Size(41, 20);
            this.RefreshTimeTextBox.TabIndex = 23;
            this.RefreshTimeTextBox.Text = "2000";
            this.RefreshTimeTextBox.TextChanged += new System.EventHandler(this.RefreshTimeTextBox_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Refresh Time (ms):";
            // 
            // WebText
            // 
            this.WebText.AccessibleName = "WebText_browserBox";
            this.WebText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebText.CausesValidation = false;
            this.WebText.Location = new System.Drawing.Point(16, 103);
            this.WebText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WebText.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebText.Name = "WebText";
            this.WebText.Size = new System.Drawing.Size(943, 94);
            this.WebText.TabIndex = 25;
            // 
            // Elements_tab
            // 
            this.Elements_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.Elements_tab.Controls.Add(this.panel1);
            this.Elements_tab.Location = new System.Drawing.Point(4, 22);
            this.Elements_tab.Margin = new System.Windows.Forms.Padding(4);
            this.Elements_tab.Name = "Elements_tab";
            this.Elements_tab.Size = new System.Drawing.Size(997, 683);
            this.Elements_tab.TabIndex = 6;
            this.Elements_tab.Text = "Elements";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GetPageObjectButton);
            this.panel1.Controls.Add(this.CopyElementsToClipboard_button);
            this.panel1.Controls.Add(this.ClearElements_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Elements_rtb);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 657);
            this.panel1.TabIndex = 0;
            // 
            // GetPageObjectButton
            // 
            this.GetPageObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetPageObjectButton.Location = new System.Drawing.Point(530, 407);
            this.GetPageObjectButton.Name = "GetPageObjectButton";
            this.GetPageObjectButton.Size = new System.Drawing.Size(159, 28);
            this.GetPageObjectButton.TabIndex = 4;
            this.GetPageObjectButton.Text = "Create Page Object";
            this.GetPageObjectButton.UseVisualStyleBackColor = true;
            this.GetPageObjectButton.Click += new System.EventHandler(this.GetPageObjectButton_Click);
            // 
            // CopyElementsToClipboard_button
            // 
            this.CopyElementsToClipboard_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyElementsToClipboard_button.Location = new System.Drawing.Point(696, 407);
            this.CopyElementsToClipboard_button.Margin = new System.Windows.Forms.Padding(4);
            this.CopyElementsToClipboard_button.Name = "CopyElementsToClipboard_button";
            this.CopyElementsToClipboard_button.Size = new System.Drawing.Size(148, 28);
            this.CopyElementsToClipboard_button.TabIndex = 3;
            this.CopyElementsToClipboard_button.Text = "Copy to Clipboard";
            this.CopyElementsToClipboard_button.UseVisualStyleBackColor = true;
            this.CopyElementsToClipboard_button.Click += new System.EventHandler(this.CopyElementsToClipboard_button_Click);
            // 
            // ClearElements_button
            // 
            this.ClearElements_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearElements_button.Location = new System.Drawing.Point(852, 407);
            this.ClearElements_button.Margin = new System.Windows.Forms.Padding(4);
            this.ClearElements_button.Name = "ClearElements_button";
            this.ClearElements_button.Size = new System.Drawing.Size(100, 28);
            this.ClearElements_button.TabIndex = 2;
            this.ClearElements_button.Text = "Clear Elements";
            this.ClearElements_button.UseVisualStyleBackColor = true;
            this.ClearElements_button.Click += new System.EventHandler(this.ClearElements_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elements Created";
            // 
            // Elements_rtb
            // 
            this.Elements_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Elements_rtb.Location = new System.Drawing.Point(20, 48);
            this.Elements_rtb.Margin = new System.Windows.Forms.Padding(4);
            this.Elements_rtb.Name = "Elements_rtb";
            this.Elements_rtb.Size = new System.Drawing.Size(931, 350);
            this.Elements_rtb.TabIndex = 0;
            this.Elements_rtb.Text = "";
            // 
            // JavaScript_tab
            // 
            this.JavaScript_tab.AccessibleName = "JavaScript_Tab";
            this.JavaScript_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.JavaScript_tab.Controls.Add(this.panel2);
            this.JavaScript_tab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JavaScript_tab.Location = new System.Drawing.Point(4, 22);
            this.JavaScript_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JavaScript_tab.Name = "JavaScript_tab";
            this.JavaScript_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JavaScript_tab.Size = new System.Drawing.Size(997, 683);
            this.JavaScript_tab.TabIndex = 2;
            this.JavaScript_tab.Text = "JavaScript";
            this.JavaScript_tab.ToolTipText = "Execute Javascript";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ExecuteJS);
            this.panel2.Controls.Add(this.JavscriptTextBox);
            this.panel2.Controls.Add(this.HidePanelButton);
            this.panel2.Controls.Add(this.DisableMouseOverButton);
            this.panel2.Controls.Add(this.DisableOnClickButton);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(5, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 665);
            this.panel2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Enter Javascript to execute:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // JavscriptTextBox
            // 
            this.JavscriptTextBox.Location = new System.Drawing.Point(5, 33);
            this.JavscriptTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JavscriptTextBox.Name = "JavscriptTextBox";
            this.JavscriptTextBox.Size = new System.Drawing.Size(569, 20);
            this.JavscriptTextBox.TabIndex = 16;
            this.JavscriptTextBox.TextChanged += new System.EventHandler(this.JavscriptTextBox_TextChanged_1);
            // 
            // HidePanelButton
            // 
            this.HidePanelButton.Location = new System.Drawing.Point(288, 129);
            this.HidePanelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HidePanelButton.Name = "HidePanelButton";
            this.HidePanelButton.Size = new System.Drawing.Size(147, 33);
            this.HidePanelButton.TabIndex = 17;
            this.HidePanelButton.Text = "Hide DTVE Panel";
            this.HidePanelButton.UseVisualStyleBackColor = true;
            this.HidePanelButton.Click += new System.EventHandler(this.HidePanelButton_Click_1);
            // 
            // DisableMouseOverButton
            // 
            this.DisableMouseOverButton.Location = new System.Drawing.Point(139, 129);
            this.DisableMouseOverButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisableMouseOverButton.Name = "DisableMouseOverButton";
            this.DisableMouseOverButton.Size = new System.Drawing.Size(143, 33);
            this.DisableMouseOverButton.TabIndex = 18;
            this.DisableMouseOverButton.Text = "Disable MouseOver";
            this.DisableMouseOverButton.UseVisualStyleBackColor = true;
            this.DisableMouseOverButton.Click += new System.EventHandler(this.DisableMouseOverButton_Click_1);
            // 
            // DisableOnClickButton
            // 
            this.DisableOnClickButton.Location = new System.Drawing.Point(5, 129);
            this.DisableOnClickButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisableOnClickButton.Name = "DisableOnClickButton";
            this.DisableOnClickButton.Size = new System.Drawing.Size(127, 33);
            this.DisableOnClickButton.TabIndex = 19;
            this.DisableOnClickButton.Text = "Disable OnClick";
            this.DisableOnClickButton.UseVisualStyleBackColor = true;
            this.DisableOnClickButton.Click += new System.EventHandler(this.DisableOnClickButton_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Prebuilt Commands";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // ErrorLog_tab
            // 
            this.ErrorLog_tab.AccessibleName = "ErrorLog_tab";
            this.ErrorLog_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.ErrorLog_tab.Controls.Add(this.panel3);
            this.ErrorLog_tab.Location = new System.Drawing.Point(4, 22);
            this.ErrorLog_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ErrorLog_tab.Name = "ErrorLog_tab";
            this.ErrorLog_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ErrorLog_tab.Size = new System.Drawing.Size(997, 683);
            this.ErrorLog_tab.TabIndex = 3;
            this.ErrorLog_tab.Text = "Error Log";
            this.ErrorLog_tab.ToolTipText = "Log of errors";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.LogTextBox);
            this.panel3.Controls.Add(this.ClearLogButton);
            this.panel3.Location = new System.Drawing.Point(5, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 665);
            this.panel3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Log";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(5, 39);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(932, 276);
            this.LogTextBox.TabIndex = 4;
            this.LogTextBox.Text = "";
            this.LogTextBox.TextChanged += new System.EventHandler(this.LogTextBox_TextChanged_1);
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new System.Drawing.Point(41, 12);
            this.ClearLogButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(75, 23);
            this.ClearLogButton.TabIndex = 3;
            this.ClearLogButton.Text = "Clear";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // Help_tab
            // 
            this.Help_tab.AccessibleName = "Help_tab";
            this.Help_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.Help_tab.Controls.Add(this.panel4);
            this.Help_tab.Location = new System.Drawing.Point(4, 22);
            this.Help_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Help_tab.Name = "Help_tab";
            this.Help_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Help_tab.Size = new System.Drawing.Size(997, 683);
            this.Help_tab.TabIndex = 4;
            this.Help_tab.Text = "Help";
            this.Help_tab.ToolTipText = "HELP!!!";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.Help1Textbox1);
            this.panel4.Controls.Add(this.HelpHeader1);
            this.panel4.Location = new System.Drawing.Point(5, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 671);
            this.panel4.TabIndex = 0;
            // 
            // Help1Textbox1
            // 
            this.Help1Textbox1.Location = new System.Drawing.Point(44, 33);
            this.Help1Textbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Help1Textbox1.Multiline = true;
            this.Help1Textbox1.Name = "Help1Textbox1";
            this.Help1Textbox1.Size = new System.Drawing.Size(852, 99);
            this.Help1Textbox1.TabIndex = 1;
            this.Help1Textbox1.Text = resources.GetString("Help1Textbox1.Text");
            this.Help1Textbox1.TextChanged += new System.EventHandler(this.Help1Textbox1_TextChanged);
            // 
            // HelpHeader1
            // 
            this.HelpHeader1.AutoSize = true;
            this.HelpHeader1.Location = new System.Drawing.Point(4, 4);
            this.HelpHeader1.Name = "HelpHeader1";
            this.HelpHeader1.Size = new System.Drawing.Size(163, 13);
            this.HelpHeader1.TabIndex = 0;
            this.HelpHeader1.Text = "XPath Basics - Plugins and Tools";
            // 
            // Setting_tab
            // 
            this.Setting_tab.AccessibleName = "Settings_tab";
            this.Setting_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.Setting_tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Setting_tab.Controls.Add(this.Settings_Panel);
            this.Setting_tab.Location = new System.Drawing.Point(4, 22);
            this.Setting_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Setting_tab.Name = "Setting_tab";
            this.Setting_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Setting_tab.Size = new System.Drawing.Size(997, 683);
            this.Setting_tab.TabIndex = 5;
            this.Setting_tab.Text = "Settings";
            this.Setting_tab.ToolTipText = "Specter internal settings";
            // 
            // Settings_Panel
            // 
            this.Settings_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.Settings_Panel.Controls.Add(this.DefaultUrl_tb);
            this.Settings_Panel.Controls.Add(this.label10);
            this.Settings_Panel.Controls.Add(this.ColorPicker_Link);
            this.Settings_Panel.Controls.Add(this.DefaultBrowser_cb);
            this.Settings_Panel.Controls.Add(this.defaultBrowser_label);
            this.Settings_Panel.Location = new System.Drawing.Point(11, 6);
            this.Settings_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.Settings_Panel.Name = "Settings_Panel";
            this.Settings_Panel.Size = new System.Drawing.Size(973, 271);
            this.Settings_Panel.TabIndex = 0;
            // 
            // DefaultUrl_tb
            // 
            this.DefaultUrl_tb.Location = new System.Drawing.Point(140, 55);
            this.DefaultUrl_tb.Name = "DefaultUrl_tb";
            this.DefaultUrl_tb.Size = new System.Drawing.Size(248, 20);
            this.DefaultUrl_tb.TabIndex = 5;
            this.DefaultUrl_tb.TextChanged += new System.EventHandler(this.DefaultUrl_tb_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Default Url";
            // 
            // ColorPicker_Link
            // 
            this.ColorPicker_Link.AutoSize = true;
            this.ColorPicker_Link.Location = new System.Drawing.Point(531, 94);
            this.ColorPicker_Link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorPicker_Link.Name = "ColorPicker_Link";
            this.ColorPicker_Link.Size = new System.Drawing.Size(120, 13);
            this.ColorPicker_Link.TabIndex = 2;
            this.ColorPicker_Link.TabStop = true;
            this.ColorPicker_Link.Text = "What values do I want?";
            this.ColorPicker_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ColorPicker_Link_LinkClicked);
            // 
            // DefaultBrowser_cb
            // 
            this.DefaultBrowser_cb.FormattingEnabled = true;
            this.DefaultBrowser_cb.Items.AddRange(new object[] {
            "Firefox",
            "Chrome",
            "IE",
            "Safari",
            "Android"});
            this.DefaultBrowser_cb.Location = new System.Drawing.Point(140, 10);
            this.DefaultBrowser_cb.Margin = new System.Windows.Forms.Padding(4);
            this.DefaultBrowser_cb.Name = "DefaultBrowser_cb";
            this.DefaultBrowser_cb.Size = new System.Drawing.Size(160, 21);
            this.DefaultBrowser_cb.TabIndex = 1;
            this.DefaultBrowser_cb.SelectedIndexChanged += new System.EventHandler(this.DefaultBrowser_cb_SelectedIndexChanged);
            // 
            // defaultBrowser_label
            // 
            this.defaultBrowser_label.AutoSize = true;
            this.defaultBrowser_label.Location = new System.Drawing.Point(23, 13);
            this.defaultBrowser_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defaultBrowser_label.Name = "defaultBrowser_label";
            this.defaultBrowser_label.Size = new System.Drawing.Size(82, 13);
            this.defaultBrowser_label.TabIndex = 0;
            this.defaultBrowser_label.Text = "Default Browser";
            // 
            // UIToolTip
            // 
            this.UIToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.UIToolTip.ShowAlways = true;
            this.UIToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.UIToolTip.ToolTipTitle = "What\'s this do?";
            this.UIToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.LaunchBrowser_tooltip_Popup);
            // 
            // Specter
            // 
            this.ClientSize = new System.Drawing.Size(1005, 709);
            this.Controls.Add(this.MainTabControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1359, 1249);
            this.MinimumSize = new System.Drawing.Size(999, 698);
            this.Name = "Specter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Specter, by ProtoTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Specter_FormClosing);
            this.Load += new System.EventHandler(this.Specter_Load);
            this.MainTabControl.ResumeLayout(false);
            this.XPathGenerator_tab.ResumeLayout(false);
            this.Browser_Panel.ResumeLayout(false);
            this.Browser_Panel.PerformLayout();
            this.XPathSectionLocatorUsePanel.ResumeLayout(false);
            this.XPathSectionLocatorUsePanel.PerformLayout();
            this.XPathSectionXPathGeneratePanel.ResumeLayout(false);
            this.XPathSectionXPathGeneratePanel.PerformLayout();
            this.XPathSectionLoadElementPanel.ResumeLayout(false);
            this.XPathSectionLoadElementPanel.PerformLayout();
            this.Elements_tab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.JavaScript_tab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ErrorLog_tab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Help_tab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Setting_tab.ResumeLayout(false);
            this.Settings_Panel.ResumeLayout(false);
            this.Settings_Panel.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private Button GenerateXPathLocatorsButton;
        private Button ExecuteCommandButton;
        private ComboBox XpathsDropdown;
        private Button GetParentButton;
        private Label label8;
        private TextBox MinimumXpathsTextBox;
        private TextBox WebDriverCommandText;
        private ComboBox WebDriverCommandDropdown;
        private TextBox XPathGeneratorMaxAttempts;
        private Label label13;
        private Label label14;
        private Button ExecuteJS;
        private NotifyIcon notifyIcon1;
        private Button button2;
        private Button button1;
        private CheckBox UseContainsCheckBox;
        private Label SkipAttLabel;
        private TextBox SkipAttributeTextBox;
        private CheckBox SplitAttributesCheckbox;
        private Label label9;
        private TextBox MaxAttLength;
        private CheckBox UseQuotesCheckbox;
        private CheckBox UseTextCheckbox;
        private CheckBox CheckCousinsCheckbox;
        private CheckBox CheckChildrenCheckbox;
        private CheckBox CheckSiblingsCheckbox;
        private CheckBox CheckAncestorsCheckbox;
        private CheckBox CheckSelfCheckbox;
        private TabControl MainTabControl;
        private TabPage XPathGenerator_tab;
        private TabPage JavaScript_tab;
        private TabPage ErrorLog_tab;
        private TabPage Help_tab;
        private TabPage Setting_tab;
        private Label label11;
        private Button DisableOnClickButton;
        private Button DisableMouseOverButton;
        private Label label7;
        private TextBox JavscriptTextBox;
        private Button HidePanelButton;
        private RichTextBox LogTextBox;
        private Button ClearLogButton;
        private Label label5;
        private WebBrowser WebText;
        private Label label4;
        private TextBox RefreshTimeTextBox;
        private Button RegisterLeftClickButton;
        private Label label1;
        private Button RegisterRightClickButton;
        private Label XPathSectionLocatorGeneration;
        private Label XPathSectionLoadWebsiteElement;
        private Panel XPathSectionLoadElementPanel;
        private Panel XPathSectionXPathGeneratePanel;
        private Panel XPathSectionLocatorUsePanel;
        private Label XPathLocatorExecuteWebdriver;
        private Button VerifyXPathLocatorOnPage;
        private Button CopyXPathToClipboard;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox Help1Textbox1;
        private Label HelpHeader1;
        private Label XPathSectionLocatorChoose;
        private ToolTip UIToolTip;
        private Panel Browser_Panel;
        private Label Browser_label;
        private Button GoToUrlButton;
        private ComboBox BrowserDropdown;
        private Button LaunchBrowserButton;
        private Label label3;
        private TextBox UrlTextBox;
        private Label label6;
        private TextBox HostTextBox;
        private Label Step1_Label;
        private Panel Settings_Panel;
        private ComboBox DefaultBrowser_cb;
        private Label defaultBrowser_label;
        private LinkLabel ColorPicker_Link;
        private TabPage Elements_tab;
        private Panel panel1;
        public RichTextBox Elements_rtb;
        private Button BuildElement_button;
        private Button ClearElements_button;
        private Label label2;
        private Button CopyElementsToClipboard_button;
        private Button GetPageObjectButton;
        private Label label10;
        private TextBox DefaultUrl_tb;
    }
}

