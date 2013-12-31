using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using ProtoTest.Specter;
using Attribute = ProtoTest.Specter.Attribute;

namespace ProtoTest.Specter
{
    public class XpathCreater
    {
        private IWebElement element;
        private string xpath;
        private int currentXpathAttempts = 0;

        private string xpathFormatString
        {
            get
            {
                return Specter.useContains ? "//{0}[contains({1},\"{2}\")]" : "//{0}[{1}=\"{2}\"]";
                
            }
        }
        public string source;
        public List<Attribute> attributes;
        public List<string> invalidXpaths;
        public List<string> uniqueXpaths;
        public List<string> duplicateXpaths;
        public List<string> elementUniqueXpaths;
        public List<string> elementDuplicateXpaths;

        private IWebDriver driver
        {
            get { return ((IWrapsDriver) element).WrappedDriver; }
        }
        
        public XpathCreater(IWebElement element)
        {
            this.element = element;
            source = driver.PageSource;
            attributes = new AttributeBuilder(element).attributes;
            invalidXpaths = new List<string>();
            uniqueXpaths= new List<string>();
            duplicateXpaths= new List<string>();
            elementUniqueXpaths= new List<string>();
            elementDuplicateXpaths= new List<string>();
            GetXpaths();
        }

        public void CheckXpath()
        {
            currentXpathAttempts++;
            var eles = driver.FindElements(By.XPath(xpath));
            var count = eles.Count;
            if (count == 0)
            {
                invalidXpaths.Add(xpath);
            }
            if ((count == 1) && (eles[0].Location == element.Location))
            {
                uniqueXpaths.Add(xpath);
            }
            if (count > 1)
            {
                duplicateXpaths.Add(xpath);
            }

            Program.builder.Log(string.Format("({0}) Xpath {1} had {2} elements", currentXpathAttempts, xpath, count));
        }

        public int TryGetXpathCount()
        {
            try
            {
                return driver.FindElements(By.XPath(xpath)).Count;
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public  List<string> GetNonUniqueXpaths(IWebElement thisElement)
        {
            var atts = new AttributeBuilder(thisElement).attributes;
            List<string> xPaths = new List<string>();
            foreach (var att in atts)
            {

                string xpath = string.Format(xpathFormatString, thisElement.TagName, att.name, att.value);
                xPaths.Add(xpath);
            }
            return xPaths;
        }

        public bool CheckSelf()
        {
            xpath =  "//" + element.TagName;
            CheckXpath();
            foreach (var att in attributes)
            {
                xpath = string.Format(xpathFormatString, element.TagName, att.name, att.value);
                CheckXpath();
                if (HaveEnough()) return true;
            }
            Program.Log("Checked all xpaths for element. Unique : " + uniqueXpaths.Count);
            elementUniqueXpaths.AddRange(uniqueXpaths);
            elementDuplicateXpaths.AddRange(duplicateXpaths);
            return false;
        }

        public bool CheckParent()
        {
            var parent = element.GetParent();
            List<string> parentXpaths = GetNonUniqueXpaths(parent);
            for (var i = 0; i < parentXpaths.Count; i++)
            {
                for (var j = 0; j < elementDuplicateXpaths.Count; j++)
                {
                    xpath = parentXpaths[i] + elementDuplicateXpaths[j];
                    CheckXpath();
                    if (HaveEnough()) return true;
                }
            }
            Program.Log("Checked the parent, unique xpaths : " + uniqueXpaths.Count);
            return false;

        }

        public bool CheckAncestors()
        {
             var ancestor = element.GetParent();

            for (var i = 0; i < 20; i++)
            {
                ancestor = ancestor.GetParent();//start with the grandparent
                if (ancestor.TagName == "html" || ancestor.TagName == "body")
                {
                    break;
                }
                Program.Log("Getting the ancestor xpaths for " + ancestor.TagName);
                var xpaths = GetNonUniqueXpaths(ancestor);
                for (var j = 0; j < xpaths.Count; j++)
                {
                    for (var k = 0; k < elementDuplicateXpaths.Count; k++)
                    {
                        xpath = xpaths[j] + elementDuplicateXpaths[k];
                        CheckXpath();
                        if (HaveEnough()) return true;
                    }
                }
                
            }

            Program.Log("Checked the ancestors, unique xpaths : " + uniqueXpaths.Count);
            return false;


        }

        public bool CheckSiblings()
        {
            var parentXpaths = GetNonUniqueXpaths(element.GetParent());
            foreach (var sibling in element.GetSiblingElements())
            {
                Program.Log("Getting the sibling xpaths");
                List<string> xpaths = GetNonUniqueXpaths(sibling);
                for (var k = 0; k < parentXpaths.Count; k++)
                {
                    for (var j = 0; j < xpaths.Count; j++)
                    {
                        for (var i = 0; i < elementDuplicateXpaths.Count; i++)
                        {
                            xpath = string.Format("{0}[.{1}]{2}",parentXpaths[k], xpaths[j],elementDuplicateXpaths[i]);
                            CheckXpath();
                            if (HaveEnough()) return true;
                        }
                    }    
                }
                
            }
            Program.Log("Checked the siblings, unique xpaths : " + uniqueXpaths.Count);
            return false;
        }

        public bool CheckChildren()
        {
            Program.Log("Getting the child xpaths");
            foreach (var child in element.FindElements(By.XPath("child::*")))
            {  
                List<string> xpaths = GetNonUniqueXpaths(child);
                for (var j = 0; j < xpaths.Count; j++)
                {
                    for (var i = 0; i < elementDuplicateXpaths.Count; i++)
                    {
                        xpath = string.Format("{0}[.{1}]", elementDuplicateXpaths[i], xpaths[j]);
                        CheckXpath();
                        if (HaveEnough()) return true;
                    }
                }
            }
            Program.Log("Checked the children, unique xpaths : " + uniqueXpaths.Count);
            return false;
        }

        public IWebElement GetNextElement(IWebElement thisElement)
        {
            try
            {
                var siblings = thisElement.FindElements(By.XPath("following-sibling::*"));
                if (siblings.Count == 0)
                {
                    var parent = thisElement.GetParent();
                    return parent;
                }
                return siblings[0];

            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public bool CheckRelatives()
        {
            var relative = element.GetParent().GetChild();
            var ancestor = relative.GetAncestor(element);
            List<string> ancestorXpaths = GetNonUniqueXpaths(ancestor);

            while (relative != null&&relative.TagName!="html"&&relative.TagName!="body")
            {
                List<string> relativeXpaths = GetNonUniqueXpaths(relative);
                for (var k = 0; k < ancestorXpaths.Count; k++)
                {
                    for (var j = 0; j < relativeXpaths.Count; j++)
                    {
                        for (var i = 0; i < elementDuplicateXpaths.Count; i++)
                        {
                            xpath = string.Format("{0}[.{1}]{2}", ancestorXpaths[k], relativeXpaths[j], elementDuplicateXpaths[i]);
                            CheckXpath();
                            if (HaveEnough()) return true;
                        }
                    }
                }
                
                relative = GetNextElement(relative);
                ancestor = relative.GetAncestor(element);
            }
            return false;
        }

        public bool HaveEnough()
        {
            if ((uniqueXpaths.Count >= Specter.minimumXpaths) || (currentXpathAttempts >= Specter.maximumXpathAttempts))
                return true;
            return false;
        }

        public void GetXpaths()
        {
            if (element == null)
            {
                return;
            }
            if (CheckSelf()) return;
            Program.builder.Log("Did not find enough Xpaths. Getting parent xpaths");
            if (CheckParent()) return;
            Program.builder.Log("Did not find enough Xpaths. Getting ancestor xpaths");
            if (CheckAncestors()) return;
            Program.builder.Log("Still can't find a unique xpath, trying siblings");
            if (CheckSiblings()) return;
            Program.builder.Log("Still can't find a unique xpath, trying children");
            if (CheckChildren()) return;
            Program.builder.Log("Still can't find a unique xpath, trying all relatives");
            if (CheckRelatives()) return;

        }

    }
}
