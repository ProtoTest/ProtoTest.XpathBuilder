using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Golem.Framework.XpathBuilder;
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
                case "ClickOffSet":
                    element.Flash();
                    OpenQA.Selenium.Interactions.Actions action = new Actions(((IWrapsDriver)element).WrappedDriver);
                    var coords = text.Split(',');
                    action.MoveToElement(element,int.Parse(coords[0]),int.Parse(coords[1])).Click().Build().Perform();
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
            System.Threading.Thread.Sleep(100);
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
                    if (!key.Contains("style"))
                    {
                        attributes.Add("@" + key,value);
                    }
                        
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

        public static void CheckXpath(this IWebDriver driver, string xpath, ref List<string> invalidXpaths, ref List<string> uniqueXpaths, ref List<string> duplicateXpaths)
        {
            XpathBuilder.currentXpathAttempts++;
            var eles = driver.FindElements(By.XPath(xpath));
            var count = eles.Count;
            if (count == 0)
            {
                invalidXpaths.Add(xpath);
            }
            if ((count == 1)&&(eles[0].Location==Program.builder.element.Location))
            {
                uniqueXpaths.Add(xpath);
            }
            if (count > 1)
            {
                duplicateXpaths.Add(xpath);
            }
            
            Program.builder.Log(string.Format("({0}) Xpath {1} had {2} elements", XpathBuilder.currentXpathAttempts,xpath, count));
        }

        public static List<string> GetNonUniqueXpaths(this IWebElement element)
        {
            if (element == null)
            {
                return new List<string>();
            }
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            string source = driver.PageSource;
            var attributes = element.GetAllAttributes();
            List<string> xPaths = new List<string>();
            foreach (var att in attributes)
            {
                if (att.Value.Contains(" "))
                {
                    var attValue = att.Value.Trim(' ');
                    if (att.Key == "text()")
                    {

                        string xpath = string.Format("//{0}[contains({1},\"{2}\")]", element.TagName, att.Key, attValue);
                        xPaths.Add(xpath);
                    }
                    else
                    {
                        foreach (var val in attValue.Split(' '))
                        {
                            if ((val != "") || (val != " "))
                            {
                                string xpath = string.Format("//{0}[contains({1},\"{2}\")]", element.TagName, att.Key, val);
                                xPaths.Add(xpath);
                            }

                        }
                    }  
                }
                else
                {
                    string xpath = string.Format("//{0}[{1}=\"{2}\"]", element.TagName, att.Key, att.Value);
                    xPaths.Add(xpath);
                }
                
                
                
            }
            return xPaths;

        }

        public static List<string> GetXpaths(this IWebElement element, int minimum=1,int max=10)
        {
           
           // Program.Log("Building Xpaths for " + element);
            if (element == null)
            {
                return new List<string>();
            }
            IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
            string source = driver.PageSource;
            var attributes = element.GetAllAttributes();
           // Program.builder.Log("Found " + attributes.Count + " attributes for " + element.TagName);
            List<string> uniqueXpaths = new List<string>();
            List<string> duplicateXpaths = new List<string>();
            List<string> invalidXpaths = new List<string>();
            List<string> elementNonUniqueXpaths = new List<string>();

            //first we try //tagName
            string tagPath = "//"+element.TagName;
           driver.CheckXpath(tagPath,ref invalidXpaths,ref uniqueXpaths,ref duplicateXpaths);
            if ((uniqueXpaths.Count >= minimum)||(XpathBuilder.currentXpathAttempts>=XpathBuilder.maximumXpathAttempts))
                return uniqueXpaths;

            //now we try //tagName[@attribute='value']
            foreach (var att in attributes)
            {
                string xpath = string.Format("//{0}[{1}=\"{2}\"]", element.TagName, att.Key, att.Value);
                driver.CheckXpath(xpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
            }
            Program.Log("Checked all xpaths for element. Unique : " + uniqueXpaths.Count);
            elementNonUniqueXpaths.AddRange(duplicateXpaths);
            if ((uniqueXpaths.Count >= minimum)||(XpathBuilder.currentXpathAttempts>=XpathBuilder.maximumXpathAttempts))
                return uniqueXpaths;
            
            Program.builder.Log("Did not find enough Xpaths. Getting parent xpaths");
            List<string> parentXpaths = element.GetParent().GetNonUniqueXpaths();
            Program.builder.Log("Parent xpaths : " + parentXpaths.Count);
            for (var i = 0; i < parentXpaths.Count; i++)
            {
                for (var j = 0; j < uniqueXpaths.Count; j++)
                {
                    string newXpath = parentXpaths[i] + uniqueXpaths[j];
                    //Program.builder.Log("Trying parent-based unique xpath : " + newXpath);
                    driver.CheckXpath(newXpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
                    if ((uniqueXpaths.Count >= minimum) || (XpathBuilder.currentXpathAttempts >= XpathBuilder.maximumXpathAttempts))
                        return uniqueXpaths;
                }
                for (var j = 0; j < elementNonUniqueXpaths.Count; j++)
                {
                    string newXpath = parentXpaths[i] + elementNonUniqueXpaths[j];
                    //Program.builder.Log("Trying parent-based duplicate xpath : " + newXpath);
                    driver.CheckXpath(newXpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
                    if ((uniqueXpaths.Count >= minimum) || (XpathBuilder.currentXpathAttempts >= XpathBuilder.maximumXpathAttempts))
                        return uniqueXpaths;
                }
            }
            Program.Log("Checked the parent, unique xpaths : " + uniqueXpaths.Count);
            if ((uniqueXpaths.Count >= minimum)||(XpathBuilder.currentXpathAttempts>=XpathBuilder.maximumXpathAttempts))
                return uniqueXpaths;

            var ancestor = element.GetParent().GetParent();

            for (var i = 0; i < 20; i++)
            {
                if (ancestor.TagName == "html" || ancestor.TagName == "body")
                {
                    break;
                }
                Program.Log("Getting the ancestor xpaths for " + ancestor.TagName);
                var xpaths = ancestor.GetNonUniqueXpaths();
                for (var j = 0; j < xpaths.Count; j++)
                {
                    for (var k = 0; k < uniqueXpaths.Count; k++)
                    {
                        string ancestorXpath = string.Format("{0}{1}", xpaths[j], uniqueXpaths[k]);
                        driver.CheckXpath(ancestorXpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
                        if ((uniqueXpaths.Count >= minimum) ||
                            (XpathBuilder.currentXpathAttempts >= XpathBuilder.maximumXpathAttempts))
                            return uniqueXpaths;
                    }
                    for (var k = 0; k < elementNonUniqueXpaths.Count; k++)
                    {
                        string ancestorXpath = string.Format("{0}{1}", xpaths[j], elementNonUniqueXpaths[k]);
                        driver.CheckXpath(ancestorXpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
                        if ((uniqueXpaths.Count >= minimum) ||
                            (XpathBuilder.currentXpathAttempts >= XpathBuilder.maximumXpathAttempts))
                            return uniqueXpaths;
                    } 
                }
                    
                ancestor = ancestor.GetParent();
            }

            Program.Log("Checked the ancestors, unique xpaths : " + uniqueXpaths.Count);
            if ((uniqueXpaths.Count >= minimum) || (XpathBuilder.currentXpathAttempts >= XpathBuilder.maximumXpathAttempts))
                return uniqueXpaths;



            Program.builder.Log("Still can't find a unique xpath, trying siblings");
            foreach (var sibling in element.GetSiblingElements())
            {
                Program.Log("Getting the sibling xpaths");
                List<string> xpaths = sibling.GetNonUniqueXpaths();
                //Program.builder.Log("Sibling had " + xpaths.Count + " unique paths");
                for (var j = 0; j < xpaths.Count; j++)
                {
                    for (var i = 0; i < uniqueXpaths.Count; i++)
                    {
                        string siblingXpath = string.Format("//{0}[.{1}]{2}", element.GetParent().TagName, xpaths[j], uniqueXpaths[i]);
                        //Program.builder.Log("Trying new sibling-based xpath : " + siblingXpath);
                        driver.CheckXpath(siblingXpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
                        if ((uniqueXpaths.Count >= minimum) || (XpathBuilder.currentXpathAttempts >= XpathBuilder.maximumXpathAttempts))
                            return uniqueXpaths;
                    }
                    for (var i = 0; i < elementNonUniqueXpaths.Count; i++)
                    {
                        string siblingXpath = string.Format("//{0}[.{1}]{2}", element.GetParent().TagName, xpaths[j],
                            elementNonUniqueXpaths[i]);
                        driver.CheckXpath(siblingXpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
                        if ((uniqueXpaths.Count >= minimum) || (XpathBuilder.currentXpathAttempts >= XpathBuilder.maximumXpathAttempts))
                            return uniqueXpaths;
                    }
                }
            }
            Program.Log("Checked the siblings, unique xpaths : " + uniqueXpaths.Count);
            if ((uniqueXpaths.Count >= minimum)||(XpathBuilder.currentXpathAttempts>=XpathBuilder.maximumXpathAttempts))
                return uniqueXpaths;
            foreach (var child in element.FindElements(By.XPath("*")))
            {
                Program.Log("Getting the child xpaths");
                List<string> xpaths = child.GetNonUniqueXpaths();
                for (var j = 0; j < xpaths.Count; j++)
                {
                    for (var i = 0; i < uniqueXpaths.Count; i++)
                    {
                        string childXpath = string.Format("{0}[.{1}]", uniqueXpaths[i], xpaths[j]);
                        driver.CheckXpath(childXpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
                        if ((uniqueXpaths.Count >= minimum) ||
                            (XpathBuilder.currentXpathAttempts >= XpathBuilder.maximumXpathAttempts))
                            return uniqueXpaths;
                    }

                    for (var i = 0; i < elementNonUniqueXpaths.Count; i++)
                    {
                        string childXpath = string.Format("{0}[.{1}]", elementNonUniqueXpaths[i], xpaths[j]);
                        driver.CheckXpath(childXpath, ref invalidXpaths, ref uniqueXpaths, ref duplicateXpaths);
                        if ((uniqueXpaths.Count >= minimum) || (XpathBuilder.currentXpathAttempts >= XpathBuilder.maximumXpathAttempts))
                            return uniqueXpaths;
                    }
                }
            }
            Program.Log("Checked the children, unique xpaths : " + uniqueXpaths.Count);
            return uniqueXpaths;
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
