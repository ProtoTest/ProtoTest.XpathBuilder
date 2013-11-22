using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static void ExecuteCommandByString(this IWebElement element,string command, string text)
        {
            switch (command)
            {
                case "Click":
                    element.Click();
                    break;
                case "Highlight":
                    element.Flash();
                    break;
                case "MouseOver":
                    element.MouseOver();
                    break;
                case "Type":
                    element.SendKeys(text);
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

        public static void RegisterRightClickEvent(this IWebDriver driver)
        {
            driver.ExecuteJavascript("var elementTarget;");
            string longPress = "function onLongPress(node) {node.ontouchstart = nullEvent;node.ontouchend = nullEvent;node.ontouchcancel = nullEvent;node.ontouchmove = nullEvent;} function nullEvent(event) { var e = event || window.event; window.elementTarget=e.target; e.preventDefault && e.preventDefault(); e.stopPropagation && e.stopPropagation(); e.cancelBubble = true; e.returnValue = false; return false;}onLongPress(document); return;";
            string listener = "if (document.addEventListener) {document.addEventListener('contextmenu', function(e) {e = e || window.event; window.elementTarget=e.target;e.preventDefault();}, false);} else {document.attachEvent('oncontextmenu', function() {e = e || window.event; window.elementTarget=e.target;window.event.returnValue = false;});} return;";
            driver.ExecuteJavascript(listener);
            driver.ExecuteJavascript(longPress);
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
            System.Threading.Thread.Sleep(500);
            element.UnHighlight();
            element.Highlight();
            System.Threading.Thread.Sleep(500);
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
        public static IDictionary<string, string> GetAllAttributes(this IWebElement element)
        {
            Dictionary<string, string> attributes = new Dictionary<string, string>();
            if (element.Text != "")
            {
                attributes.Add("text()", element.Text);
            }
            string html = element.GetHtml();
            string nodeHtml = html.Split('>')[0];
            string[] elementParts = nodeHtml.Split(' ');
            string tag = elementParts[0];
            nodeHtml = nodeHtml.Replace(tag, "");
            string[] atts = Regex.Split(nodeHtml, "\" ");
            //ProtoTest.Specter.Program.builder.Log("Number of attributes : " + (atts.Length).ToString());
            if (atts[0].Contains("=\""))
            {
                //atts[0] = atts[0].Split(' ')[1];
                for (var i = 0; i < atts.Length; i++)
                {
                    string key = Regex.Split(atts[i], "=\"")[0].Replace("\"", "").Trim();
                    string value = Regex.Split(atts[i], "=\"")[1].Replace("\"", "");
                    if(!key.Contains("style"))
                        attributes.Add("@" + key, value);
                }
            }
            var items = from pair in attributes
                        orderby pair.Key.Length ascending
                        select pair;

            Dictionary<string, string> sortedAttributes = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> pair in items)
            {
                if((pair.Key!="")&&(pair.Value!=""))
                    sortedAttributes.Add(pair.Key, pair.Value);
            }

            return sortedAttributes;
        }

        public static IDictionary<string, string> GetUniqueAttributes(this IWebElement element)
        {
            var results = new Dictionary<string,string>();
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            var attributes = element.GetAllAttributes();
            foreach(var att in attributes)
            {
                string xpath = string.Format("//{0}[{1}=\"{2}\"]", element.TagName, att.Key, att.Value);
                if (driver.FindElements(By.XPath(xpath)).Count == 1)
                    results.Add(att.Key, att.Value);
            }

            return results;

        }

        public static IWebElement GetAncestor(this IWebElement element, IWebElement relative)
        {
            var elementAncestor = element;
            
            while (elementAncestor.TagName != "html")
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

        public static KeyValuePair<string, string> GetUniqueAttribute(this IWebElement element)
        {
            var results = new Dictionary<string, string>();
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            var attributes = element.GetAllAttributes();
            foreach (var att in attributes)
            {
                string xpath = string.Format("//{0}[{1}=\"{2}\"]", element.TagName, att.Key, att.Value);
                if (driver.FindElements(By.XPath(xpath)).Count == 1)
                    return new KeyValuePair<string,string>(att.Key, att.Value);
            }
            return new KeyValuePair<string, string>("", "");
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

        public static int TryGetXpathCount(this IWebDriver driver, string xpath)
        {
            try
            {
                return driver.FindElements(By.XPath(xpath)).Count;
            }
            catch(Exception)
            {
                return 0;
            }
        }

        public static string GetSimpleXpath(this IWebElement element)
        {
            var atts = element.GetUniqueAttribute();
            return string.Format("//{0}[{1}=\"{2}\"]",element.TagName,atts.Key,atts.Value);
        }

        public static void CheckXpath(this IWebDriver driver, string xpath, ref List<string> invalidXpaths, ref List<string> uniqueXpaths, ref List<string> duplicateXpaths)
        {
            var count = driver.TryGetXpathCount(xpath);
            if (count == 0)
            {
                //Program.builder.Log("Found an invalid xpath : " + xpath);
                invalidXpaths.Add(xpath);
            }
            if (count == 1)
            {
                //Program.builder.Log("Found a unique xpath : " + xpath);
                uniqueXpaths.Add(xpath);
            }
            if (count > 1)
            {
                duplicateXpaths.Add(xpath);
            }
            Program.builder.Log(string.Format("Xpath {0} had {1} xpaths", xpath, count));
        }

        public static List<string> GetXpaths(this IWebElement element, int minimum=1)
        {
           // Program.Log("Building Xpaths for " + element);
            if (element == null)
            {
                return new List<string>();
            }
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            Program.builder.Log("Trying to find unique xpath for : " + element.GetHtml());
            string source = driver.PageSource;
            var attributes = element.GetAllAttributes();
           // Program.builder.Log("Found " + attributes.Count + " attributes for " + element.TagName);
            List<string> uniqueXpaths = new List<string>();
            List<string> duplicateXpaths = new List<string>();
            List<string> invalidXpaths = new List<string>();

            //first we try //tagName
            string tagPath = "//"+element.TagName;
           driver.CheckXpath(tagPath,ref invalidXpaths,ref uniqueXpaths,ref duplicateXpaths);
            if (uniqueXpaths.Count >= minimum)
                return uniqueXpaths;
            //now we try //tagName[@attribute='value']
            foreach (var att in attributes)
            {
                
                string xpath = string.Format("//{0}[contains({1},'{2}')]", element.TagName, att.Key, att.Value);
                driver.CheckXpath(xpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
            }
            Program.Log("Checked all xpaths for element. Unique : " + uniqueXpaths.Count);
            if (uniqueXpaths.Count >= minimum)
                return uniqueXpaths;
            //ProtoTest.Specter.Program.builder.Log("Could not find unique xpath for : " + element.GetHtml());'
            Program.builder.Log("Did not find enough Xpaths. Getting parent xpaths");
            List<string> parentXpaths = element.GetParent().GetXpaths(1);
            Program.builder.Log("Parent xpaths : " + parentXpaths.Count);
            for (var i = 0; i < parentXpaths.Count; i++)
            {
                for (var j = 0; j < uniqueXpaths.Count; j++)
                {
                    string newXpath = parentXpaths[i] + uniqueXpaths[j];
                    Program.builder.Log("Trying parent-based unique xpath : " + newXpath);
                    driver.CheckXpath(newXpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
                }
                for (var j = 0; j < duplicateXpaths.Count; j++)
                {
                    string newXpath = parentXpaths[i] + duplicateXpaths[j];
                    Program.builder.Log("Trying parent-based duplicate xpath : " + newXpath);
                    driver.CheckXpath(newXpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
                }
            }
            Program.Log("Checked the parent, unique xpaths : " + uniqueXpaths.Count);
            if (uniqueXpaths.Count >= minimum)
                return uniqueXpaths;
            Program.builder.Log("Still can't find a unique xpath, trying siblings");
            foreach (var sibling in element.GetSiblingElements())
            {
                Program.Log("Getting the sibling xpaths");
                List<string> xpaths = sibling.GetXpaths(1);
                Program.builder.Log("Sibling had " + xpaths.Count + " unique paths");

                for (var i = 0; i < uniqueXpaths.Count; i++)
                {
                    string siblingXpath = string.Format("//{0}[.{1}]{2}", element.GetParent().TagName, xpaths[0], uniqueXpaths[i]);
                    Program.builder.Log("Trying new sibling-based xpath : " + siblingXpath);
                    driver.CheckXpath(siblingXpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
                }
                for (var i = 0; i < duplicateXpaths.Count; i++)
                {
                    string siblingXpath = string.Format("//{0}[.{1}]{2}", element.GetParent().TagName, xpaths[0], duplicateXpaths[i]);
                    Program.builder.Log("Trying new xpath : " + siblingXpath);
                    driver.CheckXpath(siblingXpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
                }
            }
            Program.Log("Checked the siblings, unique xpaths : " + uniqueXpaths.Count);
            if (uniqueXpaths.Count >= minimum)
                return uniqueXpaths;
            foreach (var child in element.FindElements(By.XPath("*")))
            {
                Program.Log("Getting the child xpaths");
                List<string> xpaths = child.GetXpaths(1);
                for (var i = 0; i < uniqueXpaths.Count; i++)
                {
                    string childXpath = string.Format("{0}[.{1}]", uniqueXpaths[i], xpaths[0]);
                    Program.builder.Log("Trying new xpath : " + childXpath);
                    if (driver.FindElements(By.XPath(childXpath)).Count == 1)
                    {
                        Program.builder.Log("Found a unique xpath : " + childXpath);
                        uniqueXpaths.Add(childXpath);
                        if (uniqueXpaths.Count >= minimum)
                            return uniqueXpaths;
                    }
                }
                for (var i = 0; i < duplicateXpaths.Count; i++)
                {
                    string childXpath = string.Format("{0}[.{1}]", duplicateXpaths[i], xpaths[0]);
                    Program.builder.Log("Trying new xpath : " + childXpath);
                    if (driver.FindElements(By.XPath(childXpath)).Count == 1)
                    {
                        Program.builder.Log("___Found a unique xpath : " + childXpath);
                        uniqueXpaths.Add(childXpath);
                        if (uniqueXpaths.Count >= minimum)
                            return uniqueXpaths;
                    }
                }
            }
            Program.Log("Checked the children, unique xpaths : " + uniqueXpaths.Count);
            if (uniqueXpaths.Count >= minimum)
                return uniqueXpaths;

            

            var ancestor = element.GetParent().GetParent();
                        
            for(var i=0;i<10;i++)
            {
                if(ancestor.TagName=="html"||ancestor.TagName=="body")
                    return uniqueXpaths;
                Program.Log("Getting the ancestor xpaths for " + ancestor.TagName);
                string xpath = ancestor.GetSimpleXpath();
                for (var k = 0; k < uniqueXpaths.Count; k++)
                {
                        string ancestorXpath = string.Format("{0}{1}", xpath, uniqueXpaths[k]);
                        int num = driver.FindElements(By.XPath(ancestorXpath)).Count;
                        if (num == 1)
                        {
                            uniqueXpaths.Add(ancestorXpath);
                            if (uniqueXpaths.Count > minimum)
                                return uniqueXpaths;
                        }
                }
                for (var k = 0; k < duplicateXpaths.Count; k++)
                {
                    string ancestorXpath = string.Format("{0}{1}", xpath, duplicateXpaths[k]);
                        int num = driver.FindElements(By.XPath(ancestorXpath)).Count;
                        if (num == 1)
                        {
                            uniqueXpaths.Add(ancestorXpath);
                            if (uniqueXpaths.Count > minimum)
                                return uniqueXpaths;
                        }
                }
                ancestor=ancestor.GetParent();
            }

            Program.Log("Checked the ancestors, unique xpaths : " + uniqueXpaths.Count);
        return uniqueXpaths;
        }
    }
}
