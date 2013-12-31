﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Golem.Framework.Specter;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Android;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Remote;
using System.Xml.Linq;
using System.Xml;
using Manoli.Utils.CSharpFormat;

namespace ProtoTest.Specter
{
    public partial class Specter : Form
    {
        public IWebElement element;
        public string urlString;
        public string browserString;
        public string hostString;
        public string elementLocator;
        public string currentXpath;
        public List<string> xpaths;
        private BackgroundWorker bw;
        public IWebDriver driver;
        public static int minimumXpaths = 3;
        public static int maximumXpathAttempts = 100;
        public static bool splitAttributes = true;
        public static bool useContains = true;
        public static string skipAttributeString = " ";
        public static int refreshMs = 2000;
        public static int maxAttLength = 50;
 
        public Specter()
        {
            InitializeComponent();
            this.XpathsDropdown.TextChanged += XpathsDropdown_TextChanged;
            WebDriverCommandDropdown.SelectedIndex = 0;
            BrowserDropdown.SelectedIndex = 0;
            LaunchBrowserButton_Click(null, null);
        }

 
        void XpathsDropdown_TextChanged(object sender, EventArgs e)
        {
            this.currentXpath = XpathsDropdown.Text;
          //  this.SelectedXpathTextBox.Text = this.currentXpath;
        }

        public void Error(string message)
        {
            int start = LogTextBox.TextLength;
            LogTextBox.AppendText(message + "\r\n");
            int end = LogTextBox.TextLength;
            LogTextBox.Select(start, end - start);
            {
                LogTextBox.SelectionColor = Color.Red;
            }
            LogTextBox.SelectionLength = 0;
        }

        private void UpdateLog(string message)
        {
            if (LogTextBox.Lines.Length >= 500)
            {
                LogTextBox.Select(0, LogTextBox.GetFirstCharIndexFromLine(1));
                LogTextBox.SelectedText = "";
            }
            LogTextBox.AppendText(message + "\r\n");
            LogTextBox.ScrollToCaret();
        }

        public void Log(string message)
        {
            if (LogTextBox.InvokeRequired)
            {
            LogTextBox.Invoke(new Action<string>(UpdateLog), message);
            return;
            }    
            UpdateLog(message);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BrowserDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

            browserString = (string)BrowserDropdown.SelectedItem;
            Log("Set browser to " + browserString);
        }

        private void LaunchBrowserButton_Click(object sender, EventArgs e)
        {
            try
            {
                Log("Launching browser : " + browserString);
                switch (browserString)
                {
                    case "Firefox":
                        driver = new FirefoxDriver();
                        break;
                    case "IE":
                        driver = new InternetExplorerDriver();
                        break;
                    case "Chrome":
                        driver = new ChromeDriver();
                        break;
                    case "Safari":
                        driver = new SafariDriver();
                        break;
                    case "Android":
                        Log("Launching android browser on host : " + hostString);
                        DesiredCapabilities capabilities = DesiredCapabilities.Android();
                        var remoteAddress = new Uri("http://" + hostString + ":8080/wd/hub");
                        driver = new RemoteWebDriver(remoteAddress, capabilities);
                        break;
                    default:
                        driver = new FirefoxDriver();
                        break;
                }
            }
            catch (Exception err)
            {
                Error("Could not launch browser : " + browserString + err.Message);
            }
       
        }

        private void HighlightElementButton_Click(object sender, EventArgs e)
        {
            try
            {
                element.Flash();
            }
            catch (Exception)
            {
                Error("Element not found, start over!");
            }
        }

        private void GenerateXpathButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                Log(string.Format("Tryng to Generate {0} xpaths. Max attempts : {1}",minimumXpaths,maximumXpathAttempts));
                XpathsDropdown.Items.Clear();
                var creater = new XpathCreater(element);
                var xpaths = creater.uniqueXpaths;
                foreach (var xpath in xpaths)
                {
                    XpathsDropdown.Items.Add(xpath);
                }
                Log("Xpath Generation Complete, found " + xpaths.Count + " unique xpath expressions");
                if(XpathsDropdown.Items.Count>0)
                    XpathsDropdown.SelectedIndex = 0;
                
            }
            catch (Exception err)
            {
                Error("Could not generate xpath for element " + err.Message );
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ExecuteAndLogCommand(string xpath)
        {

            try
            {
                Log(WebDriverCommandDropdown.Text + " : " + xpath);
                driver.FindElement(By.XPath(currentXpath)).ExecuteCommandByString(WebDriverCommandDropdown.Text, WebDriverCommandText.Text);
            }
            catch (Exception)
            {
                Error("Could not execute command : " + WebDriverCommandDropdown.Text + " : " + xpath);
            }
        }

    
        void ExecuteCommand(object sender, DoWorkEventArgs e)
        {
            if (WebDriverCommandDropdown.InvokeRequired)
            {
                WebDriverCommandDropdown.Invoke(new Action<string>(ExecuteAndLogCommand),currentXpath);
                return;
            }
            ExecuteAndLogCommand(currentXpath);

           
            
        }
       

        private void ClickXpathButton_Click(object sender, EventArgs e)
        {
            try
            {
                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += ExecuteCommand;
                worker.RunWorkerAsync();
                
            }
            catch (Exception err)
            {
                Error("Could not execute command on element element : " + currentXpath + " : " + err.Message);
            }
           
        }

        private void HostTextBox_TextChanged(object sender, EventArgs e)
        {
            
            this.hostString = HostTextBox.Text;
        }

        private void XpathsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.currentXpath = (string)XpathsDropdown.SelectedItem;
           // this.SelectedXpathTextBox.Text = this.currentXpath;
        }

        public string FormatHtml(string input)
        {
            if (input != null)
            {
                int tabs = 0;
                var format = new HtmlFormat();
                format.EmbedStyleSheet = true;
                format.Alternate = true;
                var sb = new StringBuilder();
                //input = input.Replace("<", "\r\n<").Trim();
                string[] toks = input.Split('<');
                string previous="";
                foreach (string tok in toks)
                {
                    string output = "";
                    if (tok != "")
                    {
                        if (tok.StartsWith("/"))
                        {
                           for (var i = 1; i < tabs; i++)
                               output += "\t";
                           output += "<" + tok;
                                tabs--;
                        }
                        else
                        {
                            for (var i = 0; i < tabs; i++)
                                output += "\t";
                            output += "<" + tok;
                            tabs++;
                        }
                            sb.AppendLine(output);
                    }
                    previous = tok;
                }
                    return format.FormatCode(sb.ToString());
            }
            else
                return "";
        }

        private void HtmlTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Specter_Load(object sender, EventArgs e)
        {

        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            LogTextBox.Text = "";
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UrlTextBox_TextChanged(object sender, EventArgs e)
        {
            this.urlString = UrlTextBox.Text;
        }

        private void GoToUrlButton_Click(object sender, EventArgs e)
        {
        try 
	    {	        
		if(!urlString.Contains("http"))
                urlString = "http://" + urlString;
            driver.Navigate().GoToUrl(urlString);
	    }
	    catch (Exception err)
	    {
		    Error("Could not navigate to url : " + urlString + err.Message);
	    }
            
        }

        //public int FindMyText(string txtToSearch, int searchStart, int searchEnd)
        //{
        //    int indexOfSearchText;
        //    // Set the return value to -1 by default.
        //    int retVal = -1;

        //    // A valid starting index should be specified.
        //    // if indexOfSearchText = -1, the end of search
        //    if (searchStart >= 0)
        //    {
        //        // A valid ending index
        //        if (searchEnd > searchStart || searchEnd == -1)
        //        {
        //            // Find the position of search string in RichTextBox
        //            indexOfSearchText = HtmlTextBox.Find(txtToSearch, searchStart, searchEnd, RichTextBoxFinds.None);
        //            retVal = indexOfSearchText;
        //        }
        //    }
        //    return retVal;
        //}

        //private void SearchHtmlTextBox_Click(object sender, EventArgs e)
        //{
        //    int resultIndex = 0;
        //    int searchLength = SearchHtmlTextBox.Text.Length;
        //    Log("Looking for string " + SearchHtmlTextBox.Text);
            
        //    if (SearchHtmlTextBox.Text.Length > 0)
        //    {
        //        resultIndex = FindMyText(SearchHtmlTextBox.Text.Trim(), startindex, HtmlTextBox.Text.Length);
        //    }
        //    // If string was found in the RichTextBox, highlight it
        //    if (resultIndex >= 0)
        //    {
        //        // Set the highlight color as red
        //        HtmlTextBox.SelectionColor = Color.Red;
        //        // Highlight the search string
        //        HtmlTextBox.Select(resultIndex, searchLength);
        //                        HtmlTextBox.ScrollToCaret();
        //        // mark the start position after the position of
        //        // last search string
        //        startindex = resultIndex + searchLength;

        //    }
        //    else
        //    {
        //        startindex = 0;
        //    }
        //}

        private void RegisterClickEventButton_Click(object sender, EventArgs e)
        {
            try
            {
                driver.RegisterClickEvent();
                driver.RegisterHighlightOnMouseOver();
            }
            catch (Exception err)
            {
                Error("Could not register click events : " + err.Message);
            }

        }

        private void GetClickedElementButton_Click(object sender, EventArgs e)
        {
            try
            {
                element = driver.GetElementClicked();

                if (element != null)
                {
                    element.UnHighlight();
                    string html = element.GetHtml();
                    WebText.DocumentText = FormatHtml(html);
                    element.Flash();
                }
                else
                {
                    Error("Element is null, has the page changed?");

                }
            }
            catch (Exception err )
            {
                Error("Could not get element, : " + err.Message);
            }

        }

        private void GetParentButton_Click(object sender, EventArgs e)
        {

            SelectElement(element.GetParent());
            string text = element.GetHtml();
            WebText.DocumentText = FormatHtml(text);
        }


        public void SelectElement(IWebElement newElement)
        {
            driver.SetClickedElement(newElement);
            element.UnHighlight();
            element = newElement;
            element.Flash();
            string text = element.GetHtml();
            WebText.DocumentText = FormatHtml(text);
        }

        private void RegisterRightClickButton_Click(object sender, EventArgs e)
        {
            try
            {

                driver.RegisterRightClickEvent();
                driver.RegisterHighlightOnMouseOver();
            }
            catch (Exception err)
            {
                Error("Could not register rick click : " + err.Message);
            }

        }

        private void HidePanelButton_Click(object sender, EventArgs e)
        {
            driver.DisableDTVEPanel();
        }

        private void ExecuteJS_Click(object sender, EventArgs e)
        {
            try
            {
                driver.ExecuteJavascript(JavscriptTextBox.Text);
            }
            catch (Exception err)
            {
                Error("Error executing js : " + err.Message);
            }
            
        }

        private void GetElementButton_Click(object sender, EventArgs e)
        {
            try
            {
                element = driver.FindElement(By.XPath(currentXpath));
                string html = element.GetHtml();
                WebText.DocumentText = FormatHtml(html);
                element.Flash();

            }
            catch (Exception err)
            {
                Error("Could not find element by xpath : " + currentXpath + err.Message);
            }
           
        }

        private void DisableMouseOverButton_Click(object sender, EventArgs e)
        {
            try
            {
                driver.DisableMouseOver();
            }
            catch (Exception err)
            {
                Error("Error trying to disable mouse over : " + err.Message);
            }
        }

        private void DisableOnClickButton_Click(object sender, EventArgs e)
        {
            try
            {
                driver.DisableClicks();
            }
            catch (Exception err)
            {
                Error("Error caught trying to disable clicks : " + err.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //public IWebElement GetUniqueRelative(IWebElement element)
        //{
        //    Log("GetUniqueRelative : " + element.TagName);
        //    var attributes = element.GetUniqueAttributes();
        //    if (attributes.Count > 0)
        //    {
        //       Log("GetUniqueRelative : I was unique");
        //      // this.xpaths.Add(relativeXpath);
        //       XpathsDropdown.Items.Add(relativeXpath);
        //       currentXpath = relativeXpath;
        //       XpathsDropdown.SelectedValue = relativeXpath;
        //        return element;
        //    }
        //    Log("GetUniqueRelative Getting next element");
        //    element = GetNextElementInTree(element);
            
        //    return GetUniqueRelative(element);
        //}

        public static string relativeXpath;

        //public IWebElement GetNextElementInTree(IWebElement currElement)
        //{
        //    var attributes = new Attribute();
        //    Log("GetNextElementInTree : " + currElement.TagName);
        //    if(currElement.FindElements(By.XPath("following-sibling::*")).Count>0)
        //    {
        //        currElement = currElement.FindElement(By.XPath("following-sibling::*"));
        //        if(currElement.FindElements(By.XPath("child::*")).Count>0)
        //        {
        //            Log("GetNextElementInTree Found a nephew");
        //            currElement = currElement.FindElement(By.XPath("child::*"));
        //            attributes = currElement.GetUniqueAttribute();
        //            relativeXpath = string.Format("//{0}[.//{1}[{2}=\"{3}\"]]//{4}", this.element.GetAncestor(currElement).TagName, currElement.TagName, attributes.name, attributes.value, this.element.TagName);
        //            return currElement;
        //        }
        //        Log("GetNextElementInTree Found a sibling ");
        //        attributes = currElement.GetUniqueAttribute();
        //        relativeXpath = string.Format("//{0}[.//{1}[{2}=\"{3}\"]]//{4}",this.element.GetAncestor(currElement).TagName,currElement.TagName,attributes.name,attributes.value,this.element.TagName);
        //        return currElement;
        //    }
        //    Log("GetNextElementInTree Found a parent");
        //    currElement = currElement.GetParent();
        //    attributes = currElement.GetUniqueAttribute();
        //    relativeXpath = string.Format("//{0}[{1}=\"{2}\"]//{3}", this.element.GetAncestor(currElement).TagName, attributes.name, attributes.value, this.element.TagName);
        //    return currElement.GetParent();
        //}

        //private void GetUniqueElementButton_Click(object sender, EventArgs e)
        //{
        //    relativeXpath = element.GetXpaths()[0];
        //    element = GetUniqueRelative(element);
            
        //    if (element != null)
        //    {
        //        element.UnHighlight();
        //        string html = element.GetHtml();
        //        WebText.DocumentText = FormatHtml(html);
        //        element.Flash();
        //    }
        //    else
        //    {
        //        Error("Element is null, has the page changed?");

        //    }
        //}

        private void WebDriverCommandDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void SelectedXpathTextBox_TextChanged(object sender, EventArgs e)
        {
        //    this.currentXpath = this.SelectedXpathTextBox.Text;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Specter.currentXpathAttempts = 0;
        //        Log("Generating additional xpaths via xpath");
        //        XpathsDropdown.Items.Clear();
        //        int num = int.Parse(MinimumXpathsTextBox.Text);
        //        element = driver.FindElement(By.XPath(this.currentXpath));
        //        var xpaths = element.GetXpaths(num);
        //        foreach (var xpath in xpaths)
        //        {
        //            XpathsDropdown.Items.Add(xpath);
        //            XpathsDropdown.SelectedIndex = 0;
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        Error("Could not generate xpath for element " + err.Message);
        //    }
        //}

        private void MinimumXpathsTextBox_TextChanged(object sender, EventArgs e)
        {
            minimumXpaths = int.Parse(this.MinimumXpathsTextBox.Text);
        }

        private void XPathGeneratorMaxAttempts_TextChanged(object sender, EventArgs e)
        {
            maximumXpathAttempts = int.Parse(this.XPathGeneratorMaxAttempts.Text);
        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void UpdateElement()
        {
            try
            {
                element = driver.GetElementClicked();

                if (element == null)
                {
                    WebText.DocumentText = "";
                } 
                else if (element.IsStale())
                {
                    WebText.DocumentText = "";
                }
                else
                {
                    element.UnHighlight();
                    string html = element.GetHtml();
                    WebText.DocumentText = FormatHtml(html);
                    element.Flash();
                }
            }
            catch (Exception err)
            {
                Error("Exception caught looking for element, : " + err.Message);
            }
        }

        public void UpdatePanels()
        {
            if (element.IsStale())
            {
                ElementPanel.BackColor = Color.Black;
            }
            else
                ElementPanel.BackColor = Color.DimGray;
            if (driver.IsWebDriverConnected())
            {
               // CommandPanel.BackColor = Color.DimGray;
                JavascriptPanel.BackColor = Color.DimGray;
                XpathPanel.BackColor = Color.DimGray;
            }
            else
            {
                //CommandPanel.BackColor = Color.Black;
                JavascriptPanel.BackColor = Color.Black;
                XpathPanel.BackColor = Color.Black;
            }
                
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //find child
            SelectElement(element.GetChild());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //find sibling
            SelectElement(element.GetSibling());

        }

        private void SplitAttributesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            splitAttributes = SplitAttributesCheckbox.Checked;
            if(SplitAttributesCheckbox.Checked)
                UseContainsCheckBox.Checked = true;
        }

        private void RefreshTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            refreshMs = int.Parse(RefreshTimeTextBox.Text);
        }

        private void UseContainsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            useContains = UseContainsCheckBox.Checked;
            if (!UseContainsCheckBox.Checked)
                SplitAttributesCheckbox.Checked = false;
        }

        private void SkipAttributeTextBox_TextChanged(object sender, EventArgs e)
        {
            skipAttributeString = SkipAttributeTextBox.Text;
        }

        private void MaxAttLength_TextChanged(object sender, EventArgs e)
        {
            maxAttLength = int.Parse(MaxAttLength.Text);
        }
    }
}