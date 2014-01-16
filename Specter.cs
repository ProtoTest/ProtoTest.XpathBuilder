using System;
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
using System.Threading;
using ProtoTest.XpathBuilder;

namespace ProtoTest.Specter
{
    public partial class Specter : Form
    {
        public IWebElement element;
        public string urlString;
        public string browserString;
        public string hostString = "localhost";
        public string elementLocator;
        public string currentXpath;
        public List<string> xpaths;
        private BackgroundWorker bw;
        public IWebDriver driver;
        public static int minimumXpaths = 3;
        public static int maximumXpathAttempts = 100;
        public static bool splitAttributes = true;
        public static bool useContains = true;
        public static string skipAttributeString = "";
        public static int refreshMs = 2000;
        public static int maxAttLength = 50;
        public static bool useDoubleQuotes = true;
        public static bool useText = false;
        public static bool updateElement = false;
        public static bool checkSelf = true;
        public static bool checkAncestors = true;
        public static bool checkChildren = true;
        public static bool checkCousins = true;
        public static bool checkSiblings = true;
        public static string relativeXpath;
 
        public Specter()
        {
            //Start Splash Screen
            Thread time = new Thread(new ThreadStart(RunSpecterSplash));
            time.Start();
            while(!SpecterSplash.done)
                Thread.Sleep(10);  //Time length for Splash Screen to display
            InitializeComponent(); //Initialize Specter
            time.Abort();
            //End Splash Screen

            this.XpathsDropdown.TextChanged += XpathsDropdown_TextChanged;
            WebDriverCommandDropdown.SelectedIndex = 0;
            BrowserDropdown.SelectedIndex = 0; //Set default browser for startup
            //LaunchBrowserButton_Click(null, null); //Launch browser at startup
        }

        public void RunSpecterSplash()
        {
            Application.Run(new SpecterSplash());
        }


        //SCREEN ELEMENTS

        //General Settings
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
        private void HidePanelButton_Click(object sender, EventArgs e)
        {
            driver.DisableDTVEPanel();
        }
        
        //XPath Locator Building
        private void RegisterRightClickButton_Click(object sender, EventArgs e)
        {
            try
            {
                Specter.updateElement = true;
                driver.RegisterRightClickEvent();
                driver.RegisterHighlightOnMouseOver();
            }
            catch (Exception err)
            {
                Error("Could not register rick click : " + err.Message);
            }

        }
        private void RegisterLeftClickButton_Click(object sender, EventArgs e)
        {
            try
            {
                Specter.updateElement = true;
                driver.RegisterClickEvent();
                driver.RegisterHighlightOnMouseOver();
            }
            catch (Exception err)
            {
                Error("Could not register rick click : " + err.Message);
            }

        }
        private void RegisterClickEventButton_Click(object sender, EventArgs e)
        {
            try
            {
                Specter.updateElement = true;
                driver.RegisterClickEvent();
                driver.RegisterHighlightOnMouseOver();
            }
            catch (Exception err)
            {
                Error("Could not register click events : " + err.Message);
            }

        }
        private void RefreshTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            refreshMs = int.Parse(RefreshTimeTextBox.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var sibling = element.GetChild();
                SelectElement(sibling);
            }
            catch (Exception)
            {
                Error("Element did not have a child");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sibling = element.GetSibling();
                SelectElement(sibling);
            }
            catch (Exception)
            {
                Error("Element did not have a sibling");
            }



        }
        private void GenerateXpathButton_Click(object sender, EventArgs e)
        {
            try
            {
                Log(string.Format("Tryng to Generate {0} xpaths. Max attempts : {1}", minimumXpaths, maximumXpathAttempts));
                XpathsDropdown.Items.Clear();

                var xpathGetter = new BackgroundWorker();
                xpathGetter.DoWork += xpathGetter_DoWork;
                xpathGetter.RunWorkerAsync();


            }
            catch (Exception err)
            {
                Error("Could not generate xpath for element " + err.Message);
            }
        }
        private void MinimumXpathsTextBox_TextChanged(object sender, EventArgs e)
        {
            minimumXpaths = int.Parse(this.MinimumXpathsTextBox.Text);
        }
        private void XPathGeneratorMaxAttempts_TextChanged(object sender, EventArgs e)
        {
            maximumXpathAttempts = int.Parse(this.XPathGeneratorMaxAttempts.Text);
        }
        private void SplitAttributesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            splitAttributes = SplitAttributesCheckbox.Checked;
            if (SplitAttributesCheckbox.Checked)
                UseContainsCheckBox.Checked = true;
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
        private void UseQuotesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            useDoubleQuotes = UseQuotesCheckbox.Checked;
        }
        private void UseTextCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            useText = UseTextCheckbox.Checked;
        }
        private void CheckSelfCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            checkSelf = CheckSelfCheckbox.Checked;
        }
        private void CheckAncestorsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            checkAncestors = CheckAncestorsCheckbox.Checked;
        }
        private void CheckSiblingsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            checkSiblings = CheckSiblingsCheckbox.Checked;
        }
        private void CheckChildrenCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            checkChildren = CheckSiblingsCheckbox.Checked;
        }
        private void CheckCousinsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            checkCousins = CheckCousinsCheckbox.Checked;
        }
        
        //Launch Browser Options
        private void BrowserDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            browserString = (string)BrowserDropdown.SelectedItem;
        }
        private void HostTextBox_TextChanged(object sender, EventArgs e)
        {

            this.hostString = HostTextBox.Text;
        }
        private void UrlTextBox_TextChanged(object sender, EventArgs e)
        {
            this.urlString = UrlTextBox.Text;
        }
        private void LaunchBrowserButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Program.worker.RunWorkerAsync();
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += LauncHBrowser;
                bw.RunWorkerAsync();
            }
            catch (Exception err)
            {
                Error("Could not launch browser : " + browserString + err.Message);
            }

        }
        private void GoToUrlButton_Click(object sender, EventArgs e)
        {
            try
            {
                var bw = new BackgroundWorker();
                bw.DoWork += bw_DoWork;
                bw.RunWorkerAsync();
            }
            catch (Exception err)
            {
                Error("Could not navigate to url : " + urlString + err.Message);
            }

        }

        //Execute Javascript Options
        private void JavscriptTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Execute Webdriver Command Options
        private void WebDriverCommandDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Logging Options
        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            LogTextBox.Clear();
        }


        //RUNTIME OPERATIONS
        
        //Launch Browser Processes
        private void LaunchRemoteBrowser()
        {
            Log("Launching " + browserString + " browser on host : " + hostString);
            DesiredCapabilities capabilities;
            string port = "4444";
            switch (browserString)
            {
                case "Firefox":
                    capabilities = DesiredCapabilities.Firefox();
                    break;
                case "IE":
                    capabilities = DesiredCapabilities.InternetExplorer();
                    break;
                case "Chrome":
                    capabilities = DesiredCapabilities.Chrome();
                    break;
                case "Safari":
                    capabilities = DesiredCapabilities.Safari();
                    break;
                case "Android":
                    capabilities = DesiredCapabilities.Android();
                    port = "8080";
                    break;
                default:
                    capabilities = DesiredCapabilities.Firefox();
                    break;
            }
            var remoteAddress = new Uri(string.Format("http://{0}:{1}/wd/hub", hostString, port));
            driver = new RemoteWebDriver(remoteAddress, capabilities);
        }
        private void LaunchLocalBrowser()
        {
            Log("Launching " + browserString);
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
                    Error("Cannot launch android on localhost, please set to ip of phone");
                    break;
                default:
                    driver = new FirefoxDriver();
                    break;
            }
        }
        private void LauncHBrowser(object sender, DoWorkEventArgs e)
        {
            if (hostString == "localhost")
                LaunchLocalBrowser();
            else
                LaunchRemoteBrowser();

        }

        //XPath Locator Generation Processes
        void XpathsDropdown_TextChanged(object sender, EventArgs e)
        {
            this.currentXpath = XpathsDropdown.Text;
            //  this.SelectedXpathTextBox.Text = this.currentXpath;
        }
     
        //Logging Processes
        public void Log(string message)
        {
            if (LogTextBox.InvokeRequired)
            {
                LogTextBox.Invoke(new Action<string>(UpdateLog), message);
                return;
            }
            UpdateLog(message);
        }
        private void LogTextBox_TextChanged(object sender, EventArgs e)
        {

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

        private void UpdateXpaths(List<string> xpaths)
        {
            XpathsDropdown.Items.Clear();
            foreach (var xpath in xpaths)
            {
                XpathsDropdown.Items.Add(xpath);
            }
            if (XpathsDropdown.Items.Count > 0)
                XpathsDropdown.SelectedIndex = 0;
        }
      
        void xpathGetter_DoWork(object sender, DoWorkEventArgs e)
        {
            var creater = new XpathCreater(element);
            Log("Xpath Generation Complete, found " + creater.uniqueXpaths.Count + " unique xpath expressions");
            if (XpathsDropdown.InvokeRequired)
            {
                XpathsDropdown.Invoke(new Action<List<string>>(UpdateXpaths), creater.uniqueXpaths);
                return;
            }
            UpdateXpaths(creater.uniqueXpaths);
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Specter_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!urlString.Contains("http"))
                urlString = "http://" + urlString;
            driver.Navigate().GoToUrl(urlString);
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
                //Error("Exception caught looking for element, : " + err.Message);
            }
        }

        public void UpdatePanels()
        {
            if (element.IsStale())
            {
                //ElementPanel.BackColor = Color.Black;
            }
            else
                //ElementPanel.BackColor = Color.DimGray;
            if (driver.IsWebDriverConnected())
            {
                //CommandPanel.BackColor = Color.DimGray;
                //JavascriptPanel.BackColor = Color.DimGray;
                //XpathPanel.BackColor = Color.DimGray;
            }
            else
            {
                //CommandPanel.BackColor = Color.Black;
                //JavascriptPanel.BackColor = Color.Black;
                //XpathPanel.BackColor = Color.Black;
            }
                
                
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DisableOnClickButton_Click_1(object sender, EventArgs e)
        {

        }

        private void DisableMouseOverButton_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void JavscriptTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void HidePanelButton_Click_1(object sender, EventArgs e)
        {

        }

        private void LogTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CopyXPathToClipboard_Click(object sender, EventArgs e)
        {
            string locator = XpathsDropdown.Text.ToString();
            System.Windows.Forms.Clipboard.SetText(locator);
        }

        private void Help1Textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VerifyXPathLocatorOnPage_Click(object sender, EventArgs e)
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

    }
}
