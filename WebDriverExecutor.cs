using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using ProtoTest.Specter;

namespace Golem.Framework.Specter
{
    public class WebDriverExecutor
    {
        public string command;
        public IWebDriver driver;
        private BackgroundWorker worker;
        public string xpath;
        public string param;
        public WebDriverExecutor(IWebDriver driver, string xpath, string command, string param)
        {
            this.driver = driver;
            this.command = command;
            this.xpath = xpath;
            this.param = param;
            this.worker = new BackgroundWorker();
           
        }
      
        public void Execute()
        {
            this.worker.DoWork += ExecuteCommand;
            this.worker.RunWorkerAsync();
        }

        private void ExecuteCommand(object sender, DoWorkEventArgs e)
        {
            Program.Log(command + " " + param + ": " + xpath);
            driver.FindElement(By.XPath(xpath)).ExecuteCommandByString(command, param);
        }
       
    }
}
