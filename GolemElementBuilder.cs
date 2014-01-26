using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProtoTest.XpathBuilder
{
    public class GolemElementBuilder
    {
        private string baseGolemElementSting = "public Element {0} = new Element(\"{1}\", By.XPath(\"{2}\"));";
        private string GolemElement;
        public string ElementName { get; set; }
        public string ElementLocator { get; set; }

        public GolemElementBuilder(){}
        

        public string GetGolemElement()
        {
            if (ElementName != null && ElementLocator != null)
            {
                GolemElement = string.Format(baseGolemElementSting, ElementName, ElementName, ElementLocator);
            }
            return GolemElement;
        }
    }
}
