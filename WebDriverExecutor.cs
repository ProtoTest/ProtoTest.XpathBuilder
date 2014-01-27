using System.ComponentModel;
using OpenQA.Selenium;
using ProtoTest.Specter;

namespace Golem.Framework.Specter
{
    public class WebDriverExecutor
    {
        private readonly BackgroundWorker worker;
        public string command;
        public IWebDriver driver;
        public string param;
        public string xpath;

        public WebDriverExecutor(IWebDriver driver, string xpath, string command, string param)
        {
            this.driver = driver;
            this.command = command;
            this.xpath = xpath;
            this.param = param;
            worker = new BackgroundWorker();
        }

        public void Execute()
        {
            worker.DoWork += ExecuteCommand;
            worker.RunWorkerAsync();
        }

        private void ExecuteCommand(object sender, DoWorkEventArgs e)
        {
            Program.Log(command + " " + param + ": " + xpath);
            driver.FindElement(By.XPath(xpath)).ExecuteCommandByString(command, param);
        }
    }
}