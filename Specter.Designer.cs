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
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Specter));
            this.WebDriverCommandText = new TextBox();
            this.WebDriverCommandDropdown = new ComboBox();
            this.MinimumXpathsTextBox = new TextBox();
            this.label8 = new Label();
            this.ExecuteCommandButton = new Button();
            this.GenerateXPathLocatorsButton = new Button();
            this.XpathsDropdown = new ComboBox();
            this.button2 = new Button();
            this.button1 = new Button();
            this.GetParentButton = new Button();
            this.label13 = new Label();
            this.XPathGeneratorMaxAttempts = new TextBox();
            this.label14 = new Label();
            this.CheckCousinsCheckbox = new CheckBox();
            this.CheckChildrenCheckbox = new CheckBox();
            this.UseQuotesCheckbox = new CheckBox();
            this.CheckSiblingsCheckbox = new CheckBox();
            this.UseTextCheckbox = new CheckBox();
            this.CheckAncestorsCheckbox = new CheckBox();
            this.label9 = new Label();
            this.CheckSelfCheckbox = new CheckBox();
            this.MaxAttLength = new TextBox();
            this.UseContainsCheckBox = new CheckBox();
            this.SkipAttLabel = new Label();
            this.SkipAttributeTextBox = new TextBox();
            this.SplitAttributesCheckbox = new CheckBox();
            this.ExecuteJS = new Button();
            this.notifyIcon1 = new NotifyIcon(this.components);
            this.MainTabControl = new TabControl();
            this.XPathGenerator_tab = new TabPage();
            this.Browser_Panel = new Panel();
            this.Step1_Label = new Label();
            this.Browser_label = new Label();
            this.GoToUrlButton = new Button();
            this.BrowserDropdown = new ComboBox();
            this.LaunchBrowserButton = new Button();
            this.label3 = new Label();
            this.UrlTextBox = new TextBox();
            this.label6 = new Label();
            this.HostTextBox = new TextBox();
            this.XPathSectionLocatorUsePanel = new Panel();
            this.BuildElement_button = new Button();
            this.VerifyXPathLocatorOnPage = new Button();
            this.XPathLocatorExecuteWebdriver = new Label();
            this.CopyXPathToClipboard = new Button();
            this.XPathSectionXPathGeneratePanel = new Panel();
            this.XPathSectionLocatorChoose = new Label();
            this.XPathSectionLocatorGeneration = new Label();
            this.XPathSectionLoadElementPanel = new Panel();
            this.label1 = new Label();
            this.XPathSectionLoadWebsiteElement = new Label();
            this.RegisterLeftClickButton = new Button();
            this.RegisterRightClickButton = new Button();
            this.RefreshTimeTextBox = new TextBox();
            this.label4 = new Label();
            this.WebText = new WebBrowser();
            this.Elements_tab = new TabPage();
            this.panel1 = new Panel();
            this.GetPageObjectButton = new Button();
            this.CopyElementsToClipboard_button = new Button();
            this.ClearElements_button = new Button();
            this.label2 = new Label();
            this.Elements_rtb = new RichTextBox();
            this.JavaScript_tab = new TabPage();
            this.panel2 = new Panel();
            this.label7 = new Label();
            this.JavscriptTextBox = new TextBox();
            this.HidePanelButton = new Button();
            this.DisableMouseOverButton = new Button();
            this.DisableOnClickButton = new Button();
            this.label11 = new Label();
            this.ErrorLog_tab = new TabPage();
            this.panel3 = new Panel();
            this.label5 = new Label();
            this.LogTextBox = new RichTextBox();
            this.ClearLogButton = new Button();
            this.Help_tab = new TabPage();
            this.panel4 = new Panel();
            this.Help1Textbox1 = new TextBox();
            this.HelpHeader1 = new Label();
            this.Setting_tab = new TabPage();
            this.Settings_Panel = new Panel();
            this.label10 = new Label();
            this.ColorPicker_Link = new LinkLabel();
            this.DefaultBrowser_cb = new ComboBox();
            this.defaultBrowser_label = new Label();
            this.UIToolTip = new ToolTip(this.components);
            this.DefaultUrl_tb = new TextBox();
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
            this.WebDriverCommandText.Anchor = AnchorStyles.Bottom;
            this.WebDriverCommandText.Location = new Point(473, 69);
            this.WebDriverCommandText.Margin = new Padding(3, 2, 3, 2);
            this.WebDriverCommandText.Multiline = true;
            this.WebDriverCommandText.Name = "WebDriverCommandText";
            this.WebDriverCommandText.Size = new Size(292, 24);
            this.WebDriverCommandText.TabIndex = 20;
            this.WebDriverCommandText.TextChanged += new EventHandler(this.textBox1_TextChanged);
            // 
            // WebDriverCommandDropdown
            // 
            this.WebDriverCommandDropdown.AccessibleName = "ExecuteWebDriverCommand_dropdown";
            this.WebDriverCommandDropdown.Anchor = AnchorStyles.Bottom;
            this.WebDriverCommandDropdown.DisplayMember = "1";
            this.WebDriverCommandDropdown.FormattingEnabled = true;
            this.WebDriverCommandDropdown.Items.AddRange(new object[] {
            "Find",
            "Click",
            "MouseOver",
            "Type",
            "Count"});
            this.WebDriverCommandDropdown.Location = new Point(223, 69);
            this.WebDriverCommandDropdown.Margin = new Padding(3, 2, 3, 2);
            this.WebDriverCommandDropdown.Name = "WebDriverCommandDropdown";
            this.WebDriverCommandDropdown.Size = new Size(245, 24);
            this.WebDriverCommandDropdown.TabIndex = 19;
            this.WebDriverCommandDropdown.SelectedIndexChanged += new EventHandler(this.WebDriverCommandDropdown_SelectedIndexChanged);
            // 
            // MinimumXpathsTextBox
            // 
            this.MinimumXpathsTextBox.AccessibleName = "MinNumGenerated_textbox";
            this.MinimumXpathsTextBox.Location = new Point(165, 32);
            this.MinimumXpathsTextBox.Margin = new Padding(3, 2, 3, 2);
            this.MinimumXpathsTextBox.Name = "MinimumXpathsTextBox";
            this.MinimumXpathsTextBox.Size = new Size(39, 22);
            this.MinimumXpathsTextBox.TabIndex = 17;
            this.MinimumXpathsTextBox.Text = "3";
            this.MinimumXpathsTextBox.TextChanged += new EventHandler(this.MinimumXpathsTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new Point(12, 34);
            this.label8.Name = "label8";
            this.label8.Size = new Size(151, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Minimum # Generated:";
            // 
            // ExecuteCommandButton
            // 
            this.ExecuteCommandButton.AccessibleName = "Execute_button";
            this.ExecuteCommandButton.Anchor = AnchorStyles.Bottom;
            this.ExecuteCommandButton.Location = new Point(772, 69);
            this.ExecuteCommandButton.Margin = new Padding(3, 2, 3, 2);
            this.ExecuteCommandButton.Name = "ExecuteCommandButton";
            this.ExecuteCommandButton.Size = new Size(93, 25);
            this.ExecuteCommandButton.TabIndex = 4;
            this.ExecuteCommandButton.Text = "Execute";
            this.ExecuteCommandButton.UseVisualStyleBackColor = true;
            this.ExecuteCommandButton.Click += new EventHandler(this.ClickXpathButton_Click);
            // 
            // GenerateXPathLocatorsButton
            // 
            this.GenerateXPathLocatorsButton.AccessibleName = "GenerateXpathLocators_button";
            this.GenerateXPathLocatorsButton.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.GenerateXPathLocatorsButton.Location = new Point(9, 148);
            this.GenerateXPathLocatorsButton.Margin = new Padding(3, 2, 3, 2);
            this.GenerateXPathLocatorsButton.Name = "GenerateXPathLocatorsButton";
            this.GenerateXPathLocatorsButton.Size = new Size(195, 30);
            this.GenerateXPathLocatorsButton.TabIndex = 3;
            this.GenerateXPathLocatorsButton.Text = "Generate XPath Locators";
            this.GenerateXPathLocatorsButton.UseVisualStyleBackColor = true;
            this.GenerateXPathLocatorsButton.Click += new EventHandler(this.GenerateXpathButton_Click);
            // 
            // XpathsDropdown
            // 
            this.XpathsDropdown.AccessibleName = "ChooseLocator_dropdown";
            this.XpathsDropdown.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.XpathsDropdown.FormattingEnabled = true;
            this.XpathsDropdown.Location = new Point(123, 183);
            this.XpathsDropdown.Margin = new Padding(3, 2, 3, 2);
            this.XpathsDropdown.MaxDropDownItems = 20;
            this.XpathsDropdown.Name = "XpathsDropdown";
            this.XpathsDropdown.Size = new Size(432, 24);
            this.XpathsDropdown.TabIndex = 0;
            this.XpathsDropdown.SelectedIndexChanged += new EventHandler(this.XpathsDropdown_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.AccessibleName = "FindChild_Button";
            this.button2.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.button2.Location = new Point(15, 199);
            this.button2.Margin = new Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new Size(165, 30);
            this.button2.TabIndex = 17;
            this.button2.Text = "Find Element\'s Child";
            this.UIToolTip.SetToolTip(this.button2, "Finds the currently selected elements children.");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "FindSibling_button";
            this.button1.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.button1.Location = new Point(187, 199);
            this.button1.Margin = new Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new Size(165, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Find Element\'s Sibling";
            this.UIToolTip.SetToolTip(this.button1, "Finds the sibling of the selected element.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            // 
            // GetParentButton
            // 
            this.GetParentButton.AccessibleName = "FindParent_button";
            this.GetParentButton.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.GetParentButton.Location = new Point(359, 199);
            this.GetParentButton.Margin = new Padding(3, 2, 3, 2);
            this.GetParentButton.Name = "GetParentButton";
            this.GetParentButton.Size = new Size(165, 30);
            this.GetParentButton.TabIndex = 10;
            this.GetParentButton.Text = "Find Element\'s Parent";
            this.UIToolTip.SetToolTip(this.GetParentButton, "Find the parents of the currently selected element.");
            this.GetParentButton.UseVisualStyleBackColor = true;
            this.GetParentButton.Click += new EventHandler(this.GetParentButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new Point(12, 62);
            this.label13.Name = "label13";
            this.label13.Size = new Size(104, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Max # Attempts";
            // 
            // XPathGeneratorMaxAttempts
            // 
            this.XPathGeneratorMaxAttempts.AccessibleName = "MaxNumGenerated_textbox";
            this.XPathGeneratorMaxAttempts.Location = new Point(165, 58);
            this.XPathGeneratorMaxAttempts.Margin = new Padding(3, 2, 3, 2);
            this.XPathGeneratorMaxAttempts.Name = "XPathGeneratorMaxAttempts";
            this.XPathGeneratorMaxAttempts.Size = new Size(39, 22);
            this.XPathGeneratorMaxAttempts.TabIndex = 26;
            this.XPathGeneratorMaxAttempts.Text = "100";
            this.XPathGeneratorMaxAttempts.TextChanged += new EventHandler(this.XPathGeneratorMaxAttempts_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new Point(5, 10);
            this.label14.Name = "label14";
            this.label14.Size = new Size(203, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Step 4 - Use/Test Locator";
            // 
            // CheckCousinsCheckbox
            // 
            this.CheckCousinsCheckbox.AccessibleName = "Cousins_checkbox";
            this.CheckCousinsCheckbox.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.CheckCousinsCheckbox.AutoSize = true;
            this.CheckCousinsCheckbox.Checked = true;
            this.CheckCousinsCheckbox.CheckState = CheckState.Checked;
            this.CheckCousinsCheckbox.Location = new Point(890, 183);
            this.CheckCousinsCheckbox.Margin = new Padding(4);
            this.CheckCousinsCheckbox.Name = "CheckCousinsCheckbox";
            this.CheckCousinsCheckbox.Size = new Size(80, 21);
            this.CheckCousinsCheckbox.TabIndex = 37;
            this.CheckCousinsCheckbox.Text = "Cousins";
            this.CheckCousinsCheckbox.UseVisualStyleBackColor = true;
            this.CheckCousinsCheckbox.CheckedChanged += new EventHandler(this.CheckCousinsCheckbox_CheckedChanged);
            // 
            // CheckChildrenCheckbox
            // 
            this.CheckChildrenCheckbox.AccessibleName = "Children_checkbox";
            this.CheckChildrenCheckbox.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.CheckChildrenCheckbox.AutoSize = true;
            this.CheckChildrenCheckbox.Checked = true;
            this.CheckChildrenCheckbox.CheckState = CheckState.Checked;
            this.CheckChildrenCheckbox.Location = new Point(807, 183);
            this.CheckChildrenCheckbox.Margin = new Padding(4);
            this.CheckChildrenCheckbox.Name = "CheckChildrenCheckbox";
            this.CheckChildrenCheckbox.Size = new Size(82, 21);
            this.CheckChildrenCheckbox.TabIndex = 23;
            this.CheckChildrenCheckbox.Text = "Children";
            this.CheckChildrenCheckbox.UseVisualStyleBackColor = true;
            this.CheckChildrenCheckbox.CheckedChanged += new EventHandler(this.CheckChildrenCheckbox_CheckedChanged);
            // 
            // UseQuotesCheckbox
            // 
            this.UseQuotesCheckbox.AccessibleName = "UseDoubleQuotes_checkbox";
            this.UseQuotesCheckbox.AutoSize = true;
            this.UseQuotesCheckbox.Checked = true;
            this.UseQuotesCheckbox.CheckState = CheckState.Checked;
            this.UseQuotesCheckbox.Location = new Point(235, 60);
            this.UseQuotesCheckbox.Margin = new Padding(4);
            this.UseQuotesCheckbox.Name = "UseQuotesCheckbox";
            this.UseQuotesCheckbox.Size = new Size(154, 21);
            this.UseQuotesCheckbox.TabIndex = 36;
            this.UseQuotesCheckbox.Text = "Use Double Quotes";
            this.UseQuotesCheckbox.UseVisualStyleBackColor = true;
            this.UseQuotesCheckbox.CheckedChanged += new EventHandler(this.UseQuotesCheckbox_CheckedChanged);
            // 
            // CheckSiblingsCheckbox
            // 
            this.CheckSiblingsCheckbox.AccessibleName = "Siblings_checkbox";
            this.CheckSiblingsCheckbox.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.CheckSiblingsCheckbox.AutoSize = true;
            this.CheckSiblingsCheckbox.Checked = true;
            this.CheckSiblingsCheckbox.CheckState = CheckState.Checked;
            this.CheckSiblingsCheckbox.Location = new Point(731, 183);
            this.CheckSiblingsCheckbox.Margin = new Padding(4);
            this.CheckSiblingsCheckbox.Name = "CheckSiblingsCheckbox";
            this.CheckSiblingsCheckbox.Size = new Size(79, 21);
            this.CheckSiblingsCheckbox.TabIndex = 22;
            this.CheckSiblingsCheckbox.Text = "Siblings";
            this.CheckSiblingsCheckbox.UseVisualStyleBackColor = true;
            this.CheckSiblingsCheckbox.CheckedChanged += new EventHandler(this.CheckSiblingsCheckbox_CheckedChanged);
            // 
            // UseTextCheckbox
            // 
            this.UseTextCheckbox.AccessibleName = "UseText_checkbox";
            this.UseTextCheckbox.AutoSize = true;
            this.UseTextCheckbox.Location = new Point(235, 89);
            this.UseTextCheckbox.Margin = new Padding(4);
            this.UseTextCheckbox.Name = "UseTextCheckbox";
            this.UseTextCheckbox.Size = new Size(91, 21);
            this.UseTextCheckbox.TabIndex = 35;
            this.UseTextCheckbox.Text = "Use text()";
            this.UIToolTip.SetToolTip(this.UseTextCheckbox, "Determines whether or not to include text in the attribute list for the Locator.");
            this.UseTextCheckbox.UseVisualStyleBackColor = true;
            this.UseTextCheckbox.CheckedChanged += new EventHandler(this.UseTextCheckbox_CheckedChanged);
            // 
            // CheckAncestorsCheckbox
            // 
            this.CheckAncestorsCheckbox.AccessibleName = "Ancestors_checkbox";
            this.CheckAncestorsCheckbox.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.CheckAncestorsCheckbox.AutoSize = true;
            this.CheckAncestorsCheckbox.Checked = true;
            this.CheckAncestorsCheckbox.CheckState = CheckState.Checked;
            this.CheckAncestorsCheckbox.Location = new Point(631, 183);
            this.CheckAncestorsCheckbox.Margin = new Padding(4);
            this.CheckAncestorsCheckbox.Name = "CheckAncestorsCheckbox";
            this.CheckAncestorsCheckbox.Size = new Size(93, 21);
            this.CheckAncestorsCheckbox.TabIndex = 21;
            this.CheckAncestorsCheckbox.Text = "Ancestors";
            this.CheckAncestorsCheckbox.UseVisualStyleBackColor = true;
            this.CheckAncestorsCheckbox.CheckedChanged += new EventHandler(this.CheckAncestorsCheckbox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new Point(12, 89);
            this.label9.Margin = new Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new Size(120, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Max # characters:";
            // 
            // CheckSelfCheckbox
            // 
            this.CheckSelfCheckbox.AccessibleName = "Self_checkbox";
            this.CheckSelfCheckbox.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.CheckSelfCheckbox.AutoSize = true;
            this.CheckSelfCheckbox.Checked = true;
            this.CheckSelfCheckbox.CheckState = CheckState.Checked;
            this.CheckSelfCheckbox.Location = new Point(569, 183);
            this.CheckSelfCheckbox.Margin = new Padding(4);
            this.CheckSelfCheckbox.Name = "CheckSelfCheckbox";
            this.CheckSelfCheckbox.Size = new Size(54, 21);
            this.CheckSelfCheckbox.TabIndex = 20;
            this.CheckSelfCheckbox.Text = "Self";
            this.CheckSelfCheckbox.UseVisualStyleBackColor = true;
            this.CheckSelfCheckbox.CheckedChanged += new EventHandler(this.CheckSelfCheckbox_CheckedChanged);
            // 
            // MaxAttLength
            // 
            this.MaxAttLength.AccessibleName = "MaxCharactersGenerated_textbox";
            this.MaxAttLength.Location = new Point(165, 86);
            this.MaxAttLength.Margin = new Padding(4);
            this.MaxAttLength.Name = "MaxAttLength";
            this.MaxAttLength.Size = new Size(39, 22);
            this.MaxAttLength.TabIndex = 20;
            this.MaxAttLength.Text = "50";
            this.MaxAttLength.TextChanged += new EventHandler(this.MaxAttLength_TextChanged);
            // 
            // UseContainsCheckBox
            // 
            this.UseContainsCheckBox.AccessibleName = "UseContains_checkbox";
            this.UseContainsCheckBox.AutoSize = true;
            this.UseContainsCheckBox.Checked = true;
            this.UseContainsCheckBox.CheckState = CheckState.Checked;
            this.UseContainsCheckBox.Location = new Point(235, 118);
            this.UseContainsCheckBox.Margin = new Padding(4);
            this.UseContainsCheckBox.Name = "UseContainsCheckBox";
            this.UseContainsCheckBox.Size = new Size(124, 21);
            this.UseContainsCheckBox.TabIndex = 33;
            this.UseContainsCheckBox.Text = "Use Contains()";
            this.UseContainsCheckBox.UseVisualStyleBackColor = true;
            this.UseContainsCheckBox.CheckedChanged += new EventHandler(this.UseContainsCheckBox_CheckedChanged);
            // 
            // SkipAttLabel
            // 
            this.SkipAttLabel.AutoSize = true;
            this.SkipAttLabel.Location = new Point(429, 30);
            this.SkipAttLabel.Margin = new Padding(4, 0, 4, 0);
            this.SkipAttLabel.Name = "SkipAttLabel";
            this.SkipAttLabel.Size = new Size(179, 17);
            this.SkipAttLabel.TabIndex = 32;
            this.SkipAttLabel.Text = "Do not use HTML attribute:";
            // 
            // SkipAttributeTextBox
            // 
            this.SkipAttributeTextBox.AccessibleName = "DoNOTuseHTML_textbox";
            this.SkipAttributeTextBox.Location = new Point(608, 28);
            this.SkipAttributeTextBox.Margin = new Padding(4);
            this.SkipAttributeTextBox.Name = "SkipAttributeTextBox";
            this.SkipAttributeTextBox.Size = new Size(119, 22);
            this.SkipAttributeTextBox.TabIndex = 31;
            this.UIToolTip.SetToolTip(this.SkipAttributeTextBox, "The value entered into this field will be ignored when building xpaths.");
            this.SkipAttributeTextBox.TextChanged += new EventHandler(this.SkipAttributeTextBox_TextChanged);
            // 
            // SplitAttributesCheckbox
            // 
            this.SplitAttributesCheckbox.AccessibleName = "SplitAttributes_Checkbox";
            this.SplitAttributesCheckbox.AutoSize = true;
            this.SplitAttributesCheckbox.Checked = true;
            this.SplitAttributesCheckbox.CheckState = CheckState.Checked;
            this.SplitAttributesCheckbox.Location = new Point(235, 30);
            this.SplitAttributesCheckbox.Margin = new Padding(4);
            this.SplitAttributesCheckbox.Name = "SplitAttributesCheckbox";
            this.SplitAttributesCheckbox.Size = new Size(121, 21);
            this.SplitAttributesCheckbox.TabIndex = 30;
            this.SplitAttributesCheckbox.Text = "Split Attributes";
            this.SplitAttributesCheckbox.UseVisualStyleBackColor = true;
            this.SplitAttributesCheckbox.CheckedChanged += new EventHandler(this.SplitAttributesCheckbox_CheckedChanged);
            // 
            // ExecuteJS
            // 
            this.ExecuteJS.Location = new Point(581, 27);
            this.ExecuteJS.Margin = new Padding(3, 2, 3, 2);
            this.ExecuteJS.Name = "ExecuteJS";
            this.ExecuteJS.Size = new Size(141, 34);
            this.ExecuteJS.TabIndex = 2;
            this.ExecuteJS.Text = "Execute Javascript";
            this.ExecuteJS.UseVisualStyleBackColor = true;
            this.ExecuteJS.Click += new EventHandler(this.ExecuteJS_Click);
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
            this.MainTabControl.Dock = DockStyle.Fill;
            this.MainTabControl.Location = new Point(0, 0);
            this.MainTabControl.Margin = new Padding(3, 2, 3, 2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.ShowToolTips = true;
            this.MainTabControl.Size = new Size(1005, 709);
            this.MainTabControl.SizeMode = TabSizeMode.FillToRight;
            this.MainTabControl.TabIndex = 9;
            this.MainTabControl.SelectedIndexChanged += new EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // XPathGenerator_tab
            // 
            this.XPathGenerator_tab.AccessibleName = "XpathGenerator_tab";
            this.XPathGenerator_tab.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.XPathGenerator_tab.Controls.Add(this.Browser_Panel);
            this.XPathGenerator_tab.Controls.Add(this.XPathSectionLocatorUsePanel);
            this.XPathGenerator_tab.Controls.Add(this.XPathSectionXPathGeneratePanel);
            this.XPathGenerator_tab.Controls.Add(this.XPathSectionLoadElementPanel);
            this.XPathGenerator_tab.Location = new Point(4, 25);
            this.XPathGenerator_tab.Margin = new Padding(3, 2, 3, 2);
            this.XPathGenerator_tab.Name = "XPathGenerator_tab";
            this.XPathGenerator_tab.Padding = new Padding(3, 2, 3, 2);
            this.XPathGenerator_tab.Size = new Size(997, 680);
            this.XPathGenerator_tab.TabIndex = 0;
            this.XPathGenerator_tab.Text = "XPath Generation";
            this.XPathGenerator_tab.ToolTipText = "Record a site element, then generate and test the XPath locators.";
            // 
            // Browser_Panel
            // 
            this.Browser_Panel.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.Browser_Panel.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.Browser_Panel.Controls.Add(this.Step1_Label);
            this.Browser_Panel.Controls.Add(this.Browser_label);
            this.Browser_Panel.Controls.Add(this.GoToUrlButton);
            this.Browser_Panel.Controls.Add(this.BrowserDropdown);
            this.Browser_Panel.Controls.Add(this.LaunchBrowserButton);
            this.Browser_Panel.Controls.Add(this.label3);
            this.Browser_Panel.Controls.Add(this.UrlTextBox);
            this.Browser_Panel.Controls.Add(this.label6);
            this.Browser_Panel.Controls.Add(this.HostTextBox);
            this.Browser_Panel.Location = new Point(5, 5);
            this.Browser_Panel.Margin = new Padding(3, 2, 3, 2);
            this.Browser_Panel.Name = "Browser_Panel";
            this.Browser_Panel.Size = new Size(981, 94);
            this.Browser_Panel.TabIndex = 42;
            // 
            // Step1_Label
            // 
            this.Step1_Label.AutoSize = true;
            this.Step1_Label.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.Step1_Label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Step1_Label.Location = new Point(5, 5);
            this.Step1_Label.Name = "Step1_Label";
            this.Step1_Label.Size = new Size(177, 20);
            this.Step1_Label.TabIndex = 39;
            this.Step1_Label.Text = "Step 1 - Start Browser";
            // 
            // Browser_label
            // 
            this.Browser_label.AutoSize = true;
            this.Browser_label.Location = new Point(5, 30);
            this.Browser_label.Name = "Browser_label";
            this.Browser_label.Size = new Size(63, 17);
            this.Browser_label.TabIndex = 7;
            this.Browser_label.Text = "Browser:";
            // 
            // GoToUrlButton
            // 
            this.GoToUrlButton.AccessibleName = "GotoURL_button";
            this.GoToUrlButton.Location = new Point(608, 57);
            this.GoToUrlButton.Margin = new Padding(3, 2, 3, 2);
            this.GoToUrlButton.Name = "GoToUrlButton";
            this.GoToUrlButton.Size = new Size(95, 30);
            this.GoToUrlButton.TabIndex = 14;
            this.GoToUrlButton.Text = "GoToUrl";
            this.GoToUrlButton.UseVisualStyleBackColor = true;
            this.GoToUrlButton.Click += new EventHandler(this.GoToUrlButton_Click);
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
            this.BrowserDropdown.Location = new Point(75, 26);
            this.BrowserDropdown.Margin = new Padding(3, 2, 3, 2);
            this.BrowserDropdown.Name = "BrowserDropdown";
            this.BrowserDropdown.Size = new Size(219, 24);
            this.BrowserDropdown.TabIndex = 8;
            this.BrowserDropdown.SelectedIndexChanged += new EventHandler(this.BrowserDropdown_SelectedIndexChanged);
            // 
            // LaunchBrowserButton
            // 
            this.LaunchBrowserButton.AccessibleName = "LaunchBrowser_Button";
            this.LaunchBrowserButton.Location = new Point(300, 22);
            this.LaunchBrowserButton.Margin = new Padding(3, 2, 3, 2);
            this.LaunchBrowserButton.Name = "LaunchBrowserButton";
            this.LaunchBrowserButton.Size = new Size(191, 30);
            this.LaunchBrowserButton.TabIndex = 11;
            this.LaunchBrowserButton.Text = "Launch Browser";
            this.UIToolTip.SetToolTip(this.LaunchBrowserButton, "This Launches a browser duh!");
            this.LaunchBrowserButton.UseVisualStyleBackColor = true;
            this.LaunchBrowserButton.Click += new EventHandler(this.LaunchBrowserButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(496, 30);
            this.label3.Name = "label3";
            this.label3.Size = new Size(57, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Host IP:";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.AccessibleName = "URL_textbox";
            this.UrlTextBox.Location = new Point(76, 60);
            this.UrlTextBox.Margin = new Padding(3, 2, 3, 2);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new Size(524, 22);
            this.UrlTextBox.TabIndex = 13;
            this.UrlTextBox.TextChanged += new EventHandler(this.UrlTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(27, 64);
            this.label6.Name = "label6";
            this.label6.Size = new Size(40, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "URL:";
            // 
            // HostTextBox
            // 
            this.HostTextBox.AccessibleName = "Localhost_textbox";
            this.HostTextBox.Location = new Point(561, 26);
            this.HostTextBox.Margin = new Padding(3, 2, 3, 2);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new Size(257, 22);
            this.HostTextBox.TabIndex = 9;
            this.HostTextBox.Text = "localhost";
            this.UIToolTip.SetToolTip(this.HostTextBox, "localHost will target this computer. To Luanch on a remote system, enter the targ" +
        "et\'s IP address.");
            this.HostTextBox.TextChanged += new EventHandler(this.HostTextBox_TextChanged);
            // 
            // XPathSectionLocatorUsePanel
            // 
            this.XPathSectionLocatorUsePanel.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.XPathSectionLocatorUsePanel.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.XPathSectionLocatorUsePanel.Controls.Add(this.BuildElement_button);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.VerifyXPathLocatorOnPage);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.XPathLocatorExecuteWebdriver);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.CopyXPathToClipboard);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.WebDriverCommandDropdown);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.WebDriverCommandText);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.label14);
            this.XPathSectionLocatorUsePanel.Controls.Add(this.ExecuteCommandButton);
            this.XPathSectionLocatorUsePanel.Location = new Point(5, 566);
            this.XPathSectionLocatorUsePanel.Margin = new Padding(3, 2, 3, 2);
            this.XPathSectionLocatorUsePanel.Name = "XPathSectionLocatorUsePanel";
            this.XPathSectionLocatorUsePanel.Size = new Size(981, 107);
            this.XPathSectionLocatorUsePanel.TabIndex = 41;
            // 
            // BuildElement_button
            // 
            this.BuildElement_button.AccessibleName = "ShowXpathLocator_button";
            this.BuildElement_button.Location = new Point(473, 34);
            this.BuildElement_button.Margin = new Padding(3, 2, 3, 2);
            this.BuildElement_button.Name = "BuildElement_button";
            this.BuildElement_button.Size = new Size(213, 32);
            this.BuildElement_button.TabIndex = 32;
            this.BuildElement_button.Text = "Build Golem Element";
            this.BuildElement_button.UseVisualStyleBackColor = true;
            this.BuildElement_button.Click += new EventHandler(this.BuildElement_button_Click);
            // 
            // VerifyXPathLocatorOnPage
            // 
            this.VerifyXPathLocatorOnPage.AccessibleName = "ShowXpathLocator_button";
            this.VerifyXPathLocatorOnPage.Location = new Point(248, 34);
            this.VerifyXPathLocatorOnPage.Margin = new Padding(3, 2, 3, 2);
            this.VerifyXPathLocatorOnPage.Name = "VerifyXPathLocatorOnPage";
            this.VerifyXPathLocatorOnPage.Size = new Size(213, 32);
            this.VerifyXPathLocatorOnPage.TabIndex = 30;
            this.VerifyXPathLocatorOnPage.Text = "Show XPath Locator on page";
            this.VerifyXPathLocatorOnPage.UseVisualStyleBackColor = true;
            this.VerifyXPathLocatorOnPage.Click += new EventHandler(this.VerifyXPathLocatorOnPage_Click);
            // 
            // XPathLocatorExecuteWebdriver
            // 
            this.XPathLocatorExecuteWebdriver.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.XPathLocatorExecuteWebdriver.AutoSize = true;
            this.XPathLocatorExecuteWebdriver.Location = new Point(12, 73);
            this.XPathLocatorExecuteWebdriver.Name = "XPathLocatorExecuteWebdriver";
            this.XPathLocatorExecuteWebdriver.Size = new Size(194, 17);
            this.XPathLocatorExecuteWebdriver.TabIndex = 28;
            this.XPathLocatorExecuteWebdriver.Text = "Execute Webdriver Command";
            // 
            // CopyXPathToClipboard
            // 
            this.CopyXPathToClipboard.AccessibleName = "CopyXpathtoclipboard_button";
            this.CopyXPathToClipboard.Location = new Point(9, 34);
            this.CopyXPathToClipboard.Margin = new Padding(3, 2, 3, 2);
            this.CopyXPathToClipboard.Name = "CopyXPathToClipboard";
            this.CopyXPathToClipboard.Size = new Size(231, 32);
            this.CopyXPathToClipboard.TabIndex = 29;
            this.CopyXPathToClipboard.Text = "Copy XPath Locator to Clipboard";
            this.CopyXPathToClipboard.UseVisualStyleBackColor = true;
            this.CopyXPathToClipboard.Click += new EventHandler(this.CopyXPathToClipboard_Click);
            // 
            // XPathSectionXPathGeneratePanel
            // 
            this.XPathSectionXPathGeneratePanel.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.XPathSectionXPathGeneratePanel.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
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
            this.XPathSectionXPathGeneratePanel.Location = new Point(5, 342);
            this.XPathSectionXPathGeneratePanel.Margin = new Padding(3, 2, 3, 2);
            this.XPathSectionXPathGeneratePanel.Name = "XPathSectionXPathGeneratePanel";
            this.XPathSectionXPathGeneratePanel.Size = new Size(981, 219);
            this.XPathSectionXPathGeneratePanel.TabIndex = 40;
            // 
            // XPathSectionLocatorChoose
            // 
            this.XPathSectionLocatorChoose.AutoSize = true;
            this.XPathSectionLocatorChoose.Location = new Point(11, 185);
            this.XPathSectionLocatorChoose.Name = "XPathSectionLocatorChoose";
            this.XPathSectionLocatorChoose.Size = new Size(107, 17);
            this.XPathSectionLocatorChoose.TabIndex = 38;
            this.XPathSectionLocatorChoose.Text = "Choose locator:";
            // 
            // XPathSectionLocatorGeneration
            // 
            this.XPathSectionLocatorGeneration.AutoSize = true;
            this.XPathSectionLocatorGeneration.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.XPathSectionLocatorGeneration.Location = new Point(5, 6);
            this.XPathSectionLocatorGeneration.Margin = new Padding(4, 0, 4, 0);
            this.XPathSectionLocatorGeneration.Name = "XPathSectionLocatorGeneration";
            this.XPathSectionLocatorGeneration.Size = new Size(263, 20);
            this.XPathSectionLocatorGeneration.TabIndex = 29;
            this.XPathSectionLocatorGeneration.Text = "Step 3 - Generate XPath Locators";
            // 
            // XPathSectionLoadElementPanel
            // 
            this.XPathSectionLoadElementPanel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.XPathSectionLoadElementPanel.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
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
            this.XPathSectionLoadElementPanel.Location = new Point(5, 103);
            this.XPathSectionLoadElementPanel.Margin = new Padding(3, 2, 3, 2);
            this.XPathSectionLoadElementPanel.Name = "XPathSectionLoadElementPanel";
            this.XPathSectionLoadElementPanel.Size = new Size(981, 234);
            this.XPathSectionLoadElementPanel.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new Size(269, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Current Element (extracted from website):";
            // 
            // XPathSectionLoadWebsiteElement
            // 
            this.XPathSectionLoadWebsiteElement.AutoSize = true;
            this.XPathSectionLoadWebsiteElement.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.XPathSectionLoadWebsiteElement.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.XPathSectionLoadWebsiteElement.Location = new Point(5, 5);
            this.XPathSectionLoadWebsiteElement.Name = "XPathSectionLoadWebsiteElement";
            this.XPathSectionLoadWebsiteElement.Size = new Size(242, 20);
            this.XPathSectionLoadWebsiteElement.TabIndex = 38;
            this.XPathSectionLoadWebsiteElement.Text = "Step 2 - Load Website Element";
            // 
            // RegisterLeftClickButton
            // 
            this.RegisterLeftClickButton.AccessibleName = "CaptureElement_LeftClick_Button";
            this.RegisterLeftClickButton.Location = new Point(9, 42);
            this.RegisterLeftClickButton.Margin = new Padding(3, 2, 3, 2);
            this.RegisterLeftClickButton.Name = "RegisterLeftClickButton";
            this.RegisterLeftClickButton.Size = new Size(219, 30);
            this.RegisterLeftClickButton.TabIndex = 21;
            this.RegisterLeftClickButton.Text = "Capture Element with Left-click";
            this.RegisterLeftClickButton.UseVisualStyleBackColor = true;
            this.RegisterLeftClickButton.Click += new EventHandler(this.RegisterLeftClickButton_Click);
            // 
            // RegisterRightClickButton
            // 
            this.RegisterRightClickButton.AccessibleName = "CaptureElement_RightClick_button";
            this.RegisterRightClickButton.Location = new Point(232, 42);
            this.RegisterRightClickButton.Margin = new Padding(3, 2, 3, 2);
            this.RegisterRightClickButton.Name = "RegisterRightClickButton";
            this.RegisterRightClickButton.Size = new Size(228, 30);
            this.RegisterRightClickButton.TabIndex = 22;
            this.RegisterRightClickButton.Text = "Capture Element with Right-click";
            this.RegisterRightClickButton.UseVisualStyleBackColor = true;
            this.RegisterRightClickButton.Click += new EventHandler(this.RegisterRightClickButton_Click);
            // 
            // RefreshTimeTextBox
            // 
            this.RefreshTimeTextBox.AccessibleName = "RefreshTimer_textbox";
            this.RefreshTimeTextBox.Location = new Point(608, 48);
            this.RefreshTimeTextBox.Margin = new Padding(4);
            this.RefreshTimeTextBox.Name = "RefreshTimeTextBox";
            this.RefreshTimeTextBox.Size = new Size(41, 22);
            this.RefreshTimeTextBox.TabIndex = 23;
            this.RefreshTimeTextBox.Text = "2000";
            this.RefreshTimeTextBox.TextChanged += new EventHandler(this.RefreshTimeTextBox_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(475, 49);
            this.label4.Margin = new Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new Size(129, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Refresh Time (ms):";
            // 
            // WebText
            // 
            this.WebText.AccessibleName = "WebText_browserBox";
            this.WebText.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.WebText.CausesValidation = false;
            this.WebText.Location = new Point(16, 103);
            this.WebText.Margin = new Padding(3, 2, 3, 2);
            this.WebText.MinimumSize = new Size(20, 20);
            this.WebText.Name = "WebText";
            this.WebText.Size = new Size(943, 91);
            this.WebText.TabIndex = 25;
            // 
            // Elements_tab
            // 
            this.Elements_tab.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.Elements_tab.Controls.Add(this.panel1);
            this.Elements_tab.Location = new Point(4, 25);
            this.Elements_tab.Margin = new Padding(4);
            this.Elements_tab.Name = "Elements_tab";
            this.Elements_tab.Size = new Size(997, 680);
            this.Elements_tab.TabIndex = 6;
            this.Elements_tab.Text = "Elements";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.panel1.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GetPageObjectButton);
            this.panel1.Controls.Add(this.CopyElementsToClipboard_button);
            this.panel1.Controls.Add(this.ClearElements_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Elements_rtb);
            this.panel1.Location = new Point(11, 12);
            this.panel1.Margin = new Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(973, 654);
            this.panel1.TabIndex = 0;
            // 
            // GetPageObjectButton
            // 
            this.GetPageObjectButton.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.GetPageObjectButton.Location = new Point(547, 407);
            this.GetPageObjectButton.Name = "GetPageObjectButton";
            this.GetPageObjectButton.Size = new Size(142, 23);
            this.GetPageObjectButton.TabIndex = 4;
            this.GetPageObjectButton.Text = "Get Page Object";
            this.GetPageObjectButton.UseVisualStyleBackColor = true;
            this.GetPageObjectButton.Click += new EventHandler(this.GetPageObjectButton_Click);
            // 
            // CopyElementsToClipboard_button
            // 
            this.CopyElementsToClipboard_button.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.CopyElementsToClipboard_button.Location = new Point(696, 404);
            this.CopyElementsToClipboard_button.Margin = new Padding(4);
            this.CopyElementsToClipboard_button.Name = "CopyElementsToClipboard_button";
            this.CopyElementsToClipboard_button.Size = new Size(148, 28);
            this.CopyElementsToClipboard_button.TabIndex = 3;
            this.CopyElementsToClipboard_button.Text = "Copy to Clipboard";
            this.CopyElementsToClipboard_button.UseVisualStyleBackColor = true;
            this.CopyElementsToClipboard_button.Click += new EventHandler(this.CopyElementsToClipboard_button_Click);
            // 
            // ClearElements_button
            // 
            this.ClearElements_button.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.ClearElements_button.Location = new Point(852, 404);
            this.ClearElements_button.Margin = new Padding(4);
            this.ClearElements_button.Name = "ClearElements_button";
            this.ClearElements_button.Size = new Size(100, 28);
            this.ClearElements_button.TabIndex = 2;
            this.ClearElements_button.Text = "Clear Elements";
            this.ClearElements_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new Point(15, 20);
            this.label2.Margin = new Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(168, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elements Created";
            // 
            // Elements_rtb
            // 
            this.Elements_rtb.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.Elements_rtb.Location = new Point(20, 48);
            this.Elements_rtb.Margin = new Padding(4);
            this.Elements_rtb.Name = "Elements_rtb";
            this.Elements_rtb.Size = new Size(931, 347);
            this.Elements_rtb.TabIndex = 0;
            this.Elements_rtb.Text = "";
            // 
            // JavaScript_tab
            // 
            this.JavaScript_tab.AccessibleName = "JavaScript_Tab";
            this.JavaScript_tab.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.JavaScript_tab.Controls.Add(this.panel2);
            this.JavaScript_tab.Cursor = Cursors.IBeam;
            this.JavaScript_tab.Location = new Point(4, 25);
            this.JavaScript_tab.Margin = new Padding(3, 2, 3, 2);
            this.JavaScript_tab.Name = "JavaScript_tab";
            this.JavaScript_tab.Padding = new Padding(3, 2, 3, 2);
            this.JavaScript_tab.Size = new Size(997, 680);
            this.JavaScript_tab.TabIndex = 2;
            this.JavaScript_tab.Text = "JavaScript";
            this.JavaScript_tab.ToolTipText = "Execute Javascript";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.panel2.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ExecuteJS);
            this.panel2.Controls.Add(this.JavscriptTextBox);
            this.panel2.Controls.Add(this.HidePanelButton);
            this.panel2.Controls.Add(this.DisableMouseOverButton);
            this.panel2.Controls.Add(this.DisableOnClickButton);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new Point(5, 6);
            this.panel2.Margin = new Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(980, 662);
            this.panel2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new Size(183, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Enter Javascript to execute:";
            this.label7.Click += new EventHandler(this.label7_Click);
            // 
            // JavscriptTextBox
            // 
            this.JavscriptTextBox.Location = new Point(5, 33);
            this.JavscriptTextBox.Margin = new Padding(3, 2, 3, 2);
            this.JavscriptTextBox.Name = "JavscriptTextBox";
            this.JavscriptTextBox.Size = new Size(569, 22);
            this.JavscriptTextBox.TabIndex = 16;
            this.JavscriptTextBox.TextChanged += new EventHandler(this.JavscriptTextBox_TextChanged_1);
            // 
            // HidePanelButton
            // 
            this.HidePanelButton.Location = new Point(288, 129);
            this.HidePanelButton.Margin = new Padding(3, 2, 3, 2);
            this.HidePanelButton.Name = "HidePanelButton";
            this.HidePanelButton.Size = new Size(147, 33);
            this.HidePanelButton.TabIndex = 17;
            this.HidePanelButton.Text = "Hide DTVE Panel";
            this.HidePanelButton.UseVisualStyleBackColor = true;
            this.HidePanelButton.Click += new EventHandler(this.HidePanelButton_Click_1);
            // 
            // DisableMouseOverButton
            // 
            this.DisableMouseOverButton.Location = new Point(139, 129);
            this.DisableMouseOverButton.Margin = new Padding(3, 2, 3, 2);
            this.DisableMouseOverButton.Name = "DisableMouseOverButton";
            this.DisableMouseOverButton.Size = new Size(143, 33);
            this.DisableMouseOverButton.TabIndex = 18;
            this.DisableMouseOverButton.Text = "Disable MouseOver";
            this.DisableMouseOverButton.UseVisualStyleBackColor = true;
            this.DisableMouseOverButton.Click += new EventHandler(this.DisableMouseOverButton_Click_1);
            // 
            // DisableOnClickButton
            // 
            this.DisableOnClickButton.Location = new Point(5, 129);
            this.DisableOnClickButton.Margin = new Padding(3, 2, 3, 2);
            this.DisableOnClickButton.Name = "DisableOnClickButton";
            this.DisableOnClickButton.Size = new Size(127, 33);
            this.DisableOnClickButton.TabIndex = 19;
            this.DisableOnClickButton.Text = "Disable OnClick";
            this.DisableOnClickButton.UseVisualStyleBackColor = true;
            this.DisableOnClickButton.Click += new EventHandler(this.DisableOnClickButton_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new Point(3, 110);
            this.label11.Name = "label11";
            this.label11.Size = new Size(130, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Prebuilt Commands";
            this.label11.Click += new EventHandler(this.label11_Click);
            // 
            // ErrorLog_tab
            // 
            this.ErrorLog_tab.AccessibleName = "ErrorLog_tab";
            this.ErrorLog_tab.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.ErrorLog_tab.Controls.Add(this.panel3);
            this.ErrorLog_tab.Location = new Point(4, 25);
            this.ErrorLog_tab.Margin = new Padding(3, 2, 3, 2);
            this.ErrorLog_tab.Name = "ErrorLog_tab";
            this.ErrorLog_tab.Padding = new Padding(3, 2, 3, 2);
            this.ErrorLog_tab.Size = new Size(997, 680);
            this.ErrorLog_tab.TabIndex = 3;
            this.ErrorLog_tab.Text = "Error Log";
            this.ErrorLog_tab.ToolTipText = "Log of errors";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.panel3.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.LogTextBox);
            this.panel3.Controls.Add(this.ClearLogButton);
            this.panel3.Location = new Point(5, 6);
            this.panel3.Margin = new Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(976, 662);
            this.panel3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new Size(32, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Log";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new Point(5, 39);
            this.LogTextBox.Margin = new Padding(3, 2, 3, 2);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new Size(932, 276);
            this.LogTextBox.TabIndex = 4;
            this.LogTextBox.Text = "";
            this.LogTextBox.TextChanged += new EventHandler(this.LogTextBox_TextChanged_1);
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new Point(41, 12);
            this.ClearLogButton.Margin = new Padding(3, 2, 3, 2);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new Size(75, 23);
            this.ClearLogButton.TabIndex = 3;
            this.ClearLogButton.Text = "Clear";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new EventHandler(this.ClearLogButton_Click);
            // 
            // Help_tab
            // 
            this.Help_tab.AccessibleName = "Help_tab";
            this.Help_tab.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.Help_tab.Controls.Add(this.panel4);
            this.Help_tab.Location = new Point(4, 25);
            this.Help_tab.Margin = new Padding(3, 2, 3, 2);
            this.Help_tab.Name = "Help_tab";
            this.Help_tab.Padding = new Padding(3, 2, 3, 2);
            this.Help_tab.Size = new Size(997, 680);
            this.Help_tab.TabIndex = 4;
            this.Help_tab.Text = "Help";
            this.Help_tab.ToolTipText = "HELP!!!";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.panel4.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.Help1Textbox1);
            this.panel4.Controls.Add(this.HelpHeader1);
            this.panel4.Location = new Point(5, 6);
            this.panel4.Margin = new Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new Size(984, 668);
            this.panel4.TabIndex = 0;
            // 
            // Help1Textbox1
            // 
            this.Help1Textbox1.Location = new Point(44, 33);
            this.Help1Textbox1.Margin = new Padding(3, 2, 3, 2);
            this.Help1Textbox1.Multiline = true;
            this.Help1Textbox1.Name = "Help1Textbox1";
            this.Help1Textbox1.Size = new Size(852, 99);
            this.Help1Textbox1.TabIndex = 1;
            this.Help1Textbox1.Text = resources.GetString("Help1Textbox1.Text");
            this.Help1Textbox1.TextChanged += new EventHandler(this.Help1Textbox1_TextChanged);
            // 
            // HelpHeader1
            // 
            this.HelpHeader1.AutoSize = true;
            this.HelpHeader1.Location = new Point(4, 4);
            this.HelpHeader1.Name = "HelpHeader1";
            this.HelpHeader1.Size = new Size(217, 17);
            this.HelpHeader1.TabIndex = 0;
            this.HelpHeader1.Text = "XPath Basics - Plugins and Tools";
            // 
            // Setting_tab
            // 
            this.Setting_tab.AccessibleName = "Settings_tab";
            this.Setting_tab.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.Setting_tab.BackgroundImageLayout = ImageLayout.Center;
            this.Setting_tab.Controls.Add(this.Settings_Panel);
            this.Setting_tab.Location = new Point(4, 25);
            this.Setting_tab.Margin = new Padding(3, 2, 3, 2);
            this.Setting_tab.Name = "Setting_tab";
            this.Setting_tab.Padding = new Padding(3, 2, 3, 2);
            this.Setting_tab.Size = new Size(997, 680);
            this.Setting_tab.TabIndex = 5;
            this.Setting_tab.Text = "Settings";
            this.Setting_tab.ToolTipText = "Specter internal settings";
            // 
            // Settings_Panel
            // 
            this.Settings_Panel.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.Settings_Panel.Controls.Add(this.DefaultUrl_tb);
            this.Settings_Panel.Controls.Add(this.label10);
            this.Settings_Panel.Controls.Add(this.ColorPicker_Link);
            this.Settings_Panel.Controls.Add(this.DefaultBrowser_cb);
            this.Settings_Panel.Controls.Add(this.defaultBrowser_label);
            this.Settings_Panel.Location = new Point(11, 6);
            this.Settings_Panel.Margin = new Padding(4);
            this.Settings_Panel.Name = "Settings_Panel";
            this.Settings_Panel.Size = new Size(973, 271);
            this.Settings_Panel.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new Point(23, 55);
            this.label10.Name = "label10";
            this.label10.Size = new Size(75, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Default Url";
            // 
            // ColorPicker_Link
            // 
            this.ColorPicker_Link.AutoSize = true;
            this.ColorPicker_Link.Location = new Point(531, 94);
            this.ColorPicker_Link.Margin = new Padding(4, 0, 4, 0);
            this.ColorPicker_Link.Name = "ColorPicker_Link";
            this.ColorPicker_Link.Size = new Size(154, 17);
            this.ColorPicker_Link.TabIndex = 2;
            this.ColorPicker_Link.TabStop = true;
            this.ColorPicker_Link.Text = "What values do I want?";
            this.ColorPicker_Link.LinkClicked += new LinkLabelLinkClickedEventHandler(this.ColorPicker_Link_LinkClicked);
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
            this.DefaultBrowser_cb.Location = new Point(140, 10);
            this.DefaultBrowser_cb.Margin = new Padding(4);
            this.DefaultBrowser_cb.Name = "DefaultBrowser_cb";
            this.DefaultBrowser_cb.Size = new Size(160, 24);
            this.DefaultBrowser_cb.TabIndex = 1;
            this.DefaultBrowser_cb.SelectedIndexChanged += new EventHandler(this.DefaultBrowser_cb_SelectedIndexChanged);
            // 
            // defaultBrowser_label
            // 
            this.defaultBrowser_label.AutoSize = true;
            this.defaultBrowser_label.Location = new Point(23, 13);
            this.defaultBrowser_label.Margin = new Padding(4, 0, 4, 0);
            this.defaultBrowser_label.Name = "defaultBrowser_label";
            this.defaultBrowser_label.Size = new Size(108, 17);
            this.defaultBrowser_label.TabIndex = 0;
            this.defaultBrowser_label.Text = "Default Browser";
            // 
            // UIToolTip
            // 
            this.UIToolTip.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.UIToolTip.ShowAlways = true;
            this.UIToolTip.ToolTipIcon = ToolTipIcon.Info;
            this.UIToolTip.ToolTipTitle = "What\'s this do?";
            this.UIToolTip.Popup += new PopupEventHandler(this.LaunchBrowser_tooltip_Popup);
            // 
            // DefaultUrl_tb
            // 
            this.DefaultUrl_tb.Location = new Point(140, 55);
            this.DefaultUrl_tb.Name = "DefaultUrl_tb";
            this.DefaultUrl_tb.Size = new Size(248, 22);
            this.DefaultUrl_tb.TabIndex = 5;
            this.DefaultUrl_tb.TextChanged += new EventHandler(this.DefaultUrl_tb_TextChanged);
            // 
            // Specter
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1005, 709);
            this.Controls.Add(this.MainTabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new Padding(3, 2, 3, 2);
            this.MaximumSize = new Size(1359, 1249);
            this.MinimumSize = new Size(999, 698);
            this.Name = "Specter";
            this.SizeGripStyle = SizeGripStyle.Show;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Specter, by ProtoTest";
            this.FormClosing += new FormClosingEventHandler(this.Specter_FormClosing);
            this.Load += new EventHandler(this.Specter_Load);
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
        private RichTextBox Elements_rtb;
        private Button BuildElement_button;
        private Button ClearElements_button;
        private Label label2;
        private Button CopyElementsToClipboard_button;
        private Button GetPageObjectButton;
        private Label label10;
        private TextBox DefaultUrl_tb;
    }
}

