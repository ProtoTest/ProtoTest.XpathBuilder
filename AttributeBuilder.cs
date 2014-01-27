using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Golem.Framework.Specter;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;

namespace ProtoTest.Specter
{
    internal class AttributeBuilder
    {
        public List<Attribute> attributes;
        public IWebElement element;
        public WebDriverExecutor executor;

        public AttributeBuilder(IWebElement element)
        {
            this.element = element;
            attributes = GetAllAttributes();
        }

        public string textString
        {
            get { return Specter.useText ? "text()" : "."; }
        }

        public IWebDriver driver
        {
            get { return ((IWrapsDriver) element).WrappedDriver; }
        }

        public List<Attribute> SplitAttribute(Attribute att)
        {
            var atts = new List<Attribute>();
            string attValue = att.value.Trim(' ');

            foreach (string val in attValue.Split(' '))
            {
                if ((val != "") && (val != " "))
                {
                    atts.Add(new Attribute(att.name, val));
                }
            }
            return atts;
        }

        public Attribute GetUniqueAttribute()
        {
            var results = new List<Attribute>();
            foreach (Attribute att in attributes)
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
                if (text != "" && text != " ")
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
                for (int i = 0; i < atts.Length; i++)
                {
                    string key = Regex.Split(atts[i], "=\"")[0].Replace("\"", "").Trim();
                    string value = Regex.Split(atts[i], "=\"")[1].Replace("\"", "");

                    if (!key.Contains("style") && !Specter.skipAttributeString.Contains(key))
                    {
                        if (key != "" && value != "")
                        {
                            if (Specter.splitAttributes)
                            {
                                List<Attribute> splitatts = SplitAttribute(new Attribute("@" + key, TrimText(value)));
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
            IOrderedEnumerable<Attribute> items = from att in attributes
                orderby att.name.Length ascending
                select att;

            return items.ToList();
        }

        public List<Attribute> GetUniqueAttributes()
        {
            var results = new List<Attribute>();
            foreach (Attribute att in attributes)
            {
                string xpath = string.Format("//{0}[{1}=\"{2}\"]", element.TagName, att.name, att.value);
                if (driver.FindElements(By.XPath(xpath)).Count == 1)
                    results.Add(new Attribute(att.name, att.value));
            }

            return results;
        }
    }
}