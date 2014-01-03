using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Golem.Framework.Specter;
using OpenQA.Selenium;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Interactions;

namespace ProtoTest.Specter
{
    public static class WebDriverExtensions
    {
        public static string originalElementBorder;
        public static void ShowOverlay(this IWebDriver driver)
        {
            string overlayCode = "var overlay = document.createElement(\"div\");overlay.setAttribute(\"id\",\"overlay\");overlay.setAttribute(\"class\", \"overlay\");overlay.setAttribute(\"style\",\"background-color: #000;opacity:.7;filter: alpha(opacity=70);position: absolute; top: 0; left: 0;width: 100%; height: 100%;z-index: 10;\");document.body.appendChild(overlay);";
            driver.ExecuteJavascript(overlayCode);
        }
        public static void DisableOverlay(this IWebDriver driver)
        {
            string overlayCode = "document.body.removeChild(document.getElementById(\"overlay\"));";
            driver.ExecuteJavascript(overlayCode);

        }

        public static void MouseOver(this IWebElement element)
        {
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();
        }


        public static void ExecuteCommandByString(this IWebDriver driver, string command, string value)
        {
            switch (command)
            {
                case "Navigate":
                    driver.Navigate().GoToUrl(value);
                    break;
                case "Count":
                    Program.Log("Found " + driver.FindElements(By.XPath(value)).Count + " elements using xpath : " + value);                    
                    break;
                default:                   
                    break;
            }
        }

        public static void ExecuteCommandByString(this IWebElement element,string command, string text)
        {
            switch (command)
            {
                case "Click":
                    element.Flash();
                    element.Click();
                    break;
                case "Find":
                    element.Flash();
                    break;
                case "MouseOver":
                    element.Flash();
                    element.MouseOver();
                    break;
                case "Type":
                    element.Flash();
                    element.SendKeys(text);
                    break;
                case "Count":
                    IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
                    var elements = driver.FindElements(By.XPath(Program.specter.currentXpath));
                    Program.Log(string.Format("Found {0} elements with xpath {1}", elements.Count, Program.specter.currentXpath));
                    break;
                default:
                    element.Flash();
                    break;
            }
        }

        public static void RegisterClickEvent(this IWebDriver driver)
        {
            driver.ExecuteJavascript("var elementTarget;");
            string listener = "document.addEventListener('click', function(e) { e = e || window.event; window.elementTarget=e.target;}, false); return;";
            driver.ExecuteJavascript(listener);
        }

        public static void RegisterHighlightOnMouseOver(this IWebDriver driver)
        {
            string var = "var lastBorder;";
            string mouseOverListener = "document.addEventListener('mouseover', function(e) { e = e || window.event; window.lastBorder=e.target.style.border; e.target.style.border='3px solid blue'}, false); return;";
            string mouseOutListener = "document.addEventListener('mouseout', function(e) { e = e || window.event; e.target.style.border=''}, false); return;";
            //string touchMoveListener = "document.addEventListener('touchmove', function(e) { e = e || window.event; e.target.style.border=''}, false); return;";
            driver.ExecuteJavascript(var);
            driver.ExecuteJavascript(mouseOverListener);
            driver.ExecuteJavascript(mouseOutListener);
        }

        public static void DisableMouseOver(this IWebDriver driver)
        {
            string all = "document.mouseover = function() { return false; };document.mouseout = function() { return false; };return;";
            driver.ExecuteJavascript(all);
        }


        public static void DisableClicks(this IWebDriver driver)
        {
            driver.ExecuteJavascript("var elementTarget;");
            //string links = "var anchors = document.getElementsByTagName(\"a\"); for (var i = 0; i < anchors.length; i++) { anchors[i].href = '';}; return;";
            string all = "document.onclick = function() { return false; };";
            driver.ExecuteJavascript(all);
        }

        public static void DisableDTVEPanel(this IWebDriver driver)
        {

                driver.ExecuteJavascript("document.getElementById(\"topnav-mobile-account-menu\").style.visibility='hidden';return;");

            
        }

        public static object ExecuteJavascript(this IWebDriver driver, string js)
        {
            try
            {
                var jsDriver = ((IJavaScriptExecutor)driver);
                return jsDriver.ExecuteScript(js);
            }
            catch (Exception err)
            {
                Program.Error("Error executing javascript : " + js + err.Message);
                return null;
            }

        }

        public static object ExecuteJavascript(this IWebDriver driver, string js, params object[] args)
        {
            try
            {
                var jsDriver = ((IJavaScriptExecutor)driver);
                return jsDriver.ExecuteScript(js,args);
            }
            catch (Exception err)
            {
                Program.Error("Error executing javascript : " + js + err.Message);
                return null;
            }

        }

        public static void RegisterRightClickEvent(this IWebDriver driver)
        {
            driver.ExecuteJavascript("var elementTarget;");
            string longPress = "function onLongPress(node) {node.ontouchstart = nullEvent;node.ontouchend = nullEvent;node.ontouchcancel = nullEvent;node.ontouchmove = nullEvent;} function nullEvent(event) { var e = event || window.event; window.elementTarget=e.target; e.preventDefault && e.preventDefault(); e.stopPropagation && e.stopPropagation(); e.cancelBubble = true; e.returnValue = false; return false;}onLongPress(document); return;";
            string listener = "if (document.addEventListener) {document.addEventListener('contextmenu', function(e) {e = e || window.event; window.elementTarget=e.target;e.preventDefault();}, false);} else {document.attachEvent('oncontextmenu', function() {e = e || window.event; window.elementTarget=e.target;window.event.returnValue = false;});} return;";
            driver.ExecuteJavascript(listener);
            driver.ExecuteJavascript(longPress);
        }

        public static void SetClickedElement(this IWebDriver driver, IWebElement element)
        {
            driver.ExecuteJavascript("window.elementTarget=arguments[0]", element);
        }

        public static IWebElement GetElementClicked(this IWebDriver driver)
        {
            try
            {
                var jsDriver = ((IJavaScriptExecutor)driver);
                return (IWebElement)jsDriver.ExecuteScript("return window.elementTarget");
            }
            catch (Exception err)
            {
                Program.Error("Could not get element : " + err.Message);
                return driver.FindElement(By.XPath("//html"));
            }
            
        }
            
        public static void Highlight(this IWebElement element)
        {
            try
            {
                var driver = ((IWrapsDriver)element).WrappedDriver;
                var jsDriver = ((IJavaScriptExecutor)driver);
                originalElementBorder = (string)jsDriver.ExecuteScript("return arguments[0].style.border", element);
                jsDriver.ExecuteScript("arguments[0].style.border='3px solid red'", element);
            }
            catch (Exception)
            {
                Program.Error("Could not highlight element");
            }

        }

        

        public static void UnHighlight(this IWebElement element)
        {
            try
            {
                var driver = ((IWrapsDriver)element).WrappedDriver;
                var jsDriver = ((IJavaScriptExecutor)driver);
                jsDriver.ExecuteScript("arguments[0].style.border='" + originalElementBorder + "'", element);
            }
            catch (Exception)
            {
                Program.Error("Could not unhighlight element");
            }

        }
        public static void Flash(this IWebElement element)
        {
            element.Highlight();
            element.UnHighlight();
        }
        public static string GetHtml(this IWebElement element)
        {
            try
            {
                IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
                string html = (string)((IJavaScriptExecutor)driver).ExecuteScript("var f = document.createElement('div').appendChild(arguments[0].cloneNode(true)); return f.parentNode.innerHTML", element);
                return html;
            }
            catch (Exception)
            {
                Program.Error("COuld not get html");
                return "";
            }
          
        }

        public static IWebElement GetParent(this IWebElement element)
        {
            try
            {
                IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
                return (IWebElement)((IJavaScriptExecutor)driver).ExecuteScript(@"return arguments[0].parentNode;", element);
            }
            catch (Exception)
            {
                Program.Error("Could not get parent");
                return element;
            }

        }
        public static IWebElement FindSibling(this IWebElement element, By by)
        {
            return element.GetParent().FindElement(by);
        }

        public static void BG_Get(this IWebDriver driver, string urlString)
        {
            try
            {
                if (!urlString.Contains("http"))
                    urlString = "http://" + urlString;
                driver.Navigate().GoToUrl(urlString);
            }
            catch (Exception err)
            {
                Program.Log("Could not navigate to url : " + urlString + err.Message);
            }
           
        }
 
        public static IWebElement GetAncestor(this IWebElement element, IWebElement relative)
        {
            var elementAncestor = element;
            
            while (elementAncestor.TagName != "html"&&elementAncestor.TagName !="")
            {
                var relativeAncestor = relative;
                while (relativeAncestor.TagName != "html")
                {
                    if (elementAncestor.GetHtml() == relativeAncestor.GetHtml())
                        return relativeAncestor;
                    else
                        relativeAncestor = relativeAncestor.GetParent();
                }
                elementAncestor = elementAncestor.GetParent();
            }
            return null;
        }
     
        public static List<IWebElement> GetSiblingElements(this IWebElement element)
        {
            List<IWebElement> webelements = new List<IWebElement>();
            var html = element.GetHtml();
            var parent = element.GetParent();
            var elements = parent.FindElements(By.XPath("child::*"));
            foreach (var ele in elements)
            {
                if (ele.GetHtml() != html)
                    webelements.Add(ele);
            }
            return webelements;
        }

        public static IWebElement GetSibling(this IWebElement element)
        {
            return element.FindElement(By.XPath("following-sibling::*"));
        }

        public static IWebElement GetChild(this IWebElement element)
        {
            return element.FindElement(By.XPath("child::*"));
        }
   
        public static bool IsWebDriverConnected(this IWebDriver driver)
        {
            try
            {
               string source = driver.PageSource;
                return true;
            }
            catch (Exception)
            {
                return false;   
            }
        }

        public static bool IsStale(this IWebElement element)
        {
            try
            {
                return !element.Enabled;
            }
            catch (Exception)
            {
                return true;
            }
        }

        
    }
 
}
