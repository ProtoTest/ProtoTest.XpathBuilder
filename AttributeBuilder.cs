using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Golem.Framework.Specter;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using ProtoTest.Specter;

namespace ProtoTest.Specter
{
    class AttributeBuilder
    {
 
        public string textString
        {
            get
            {
                return Specter.useText ? "text()" : ".";

            }
        }

        public IWebElement element;
        public List<Attribute> attributes;
        public WebDriverExecutor executor;
        public IWebDriver driver
        {
            get { return ((IWrapsDriver)element).WrappedDriver; }
        }
        public AttributeBuilder(IWebElement element)
        {
            this.element = element;
            attributes = GetAllAttributes();
        }

        public List<Attribute> SplitAttribute(Attribute att)
        {
            var atts = new List<Attribute>();
            var attValue = att.value.Trim(' ');

            foreach (var val in attValue.Split(' '))
            {
                if ((val != "") && (val != " "))
                {
                    atts.Add(new Attribute(att.name,val));
                }
            }
            return atts;
        }

        public Attribute GetUniqueAttribute()
        {
            var results = new List<Attribute>();
            foreach (var att in attributes)
            {
                string xpath = string.Format("//{0}[{1}=\"{2}\"]", element.TagName, att.name, att.value);
                if (driver.FindElements(By.XPath(xpath)).Count == 1)
                    return new Attribute(att.name, att.value);
            }
            return new Attribute("", "");
        }

        public string TrimText(string text)
        {
            if (text != "")
            {
                string finalText = text.Replace("\r\n", " ");
                if (finalText.Length > Specter.maxAttLength)
                {
                    finalText = finalText.Substring(0, Specter.maxAttLength);
                }
                return finalText;
            }
            return "";
        }

        public List<Attribute> GetAllAttributes()
        {
            attributes = new List<Attribute>();
            if (!Specter.skipAttributeString.Contains("text"))
            {
               
                    string text = TrimText(element.Text);
                    if (text != ""&&text!=" ")
                    {
                        attributes.Add(new Attribute(textString, text));
                    }
            }
            
            string html = element.GetHtml();
            string nodeHtml = html.Split('>')[0];
            string[] elementParts = nodeHtml.Split(' ');
            string tag = elementParts[0];
            nodeHtml = nodeHtml.Replace(tag, "");
            string[] atts = Regex.Split(nodeHtml, "\" ");
            if (atts[0].Contains("=\""))
            {
                for (var i = 0; i < atts.Length; i++)
                {
                    string key = Regex.Split(atts[i], "=\"")[0].Replace("\"", "").Trim();
                    string value = Regex.Split(atts[i], "=\"")[1].Replace("\"", "");
 
                    if (!key.Contains("style")&&!Specter.skipAttributeString.Contains(key))
                    {
                        if(key!=""&&value!="")
                        {
                             if (Specter.splitAttributes)
                            {
                                var splitatts = SplitAttribute(new Attribute("@" + key, TrimText(value)));
                                attributes.AddRange(splitatts);
                            }
                            else
                            {
                                attributes.Add(new Attribute("@" + key, TrimText(value)));
                            }   
                        }
                        
                        
                    }

                }
            }
            var items = from att in attributes 
                        orderby att.name.Length ascending
                        select att;

            return items.ToList();
        }

        public List<Attribute> GetUniqueAttributes()
        {
            var results = new List<Attribute>();
            foreach (var att in attributes)
            {
                string xpath = string.Format("//{0}[{1}=\"{2}\"]", element.TagName, att.name, att.value);
                if (driver.FindElements(By.XPath(xpath)).Count == 1)
                    results.Add(new Attribute(att.name, att.value));
            }

            return results;

        }

    }
}
