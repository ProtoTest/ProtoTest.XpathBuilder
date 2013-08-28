using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Golem.Framework.XpathBuilder
{
    public class XpathCreater
    {
        private IWebElement element;
        private string xpath;
        
        public XpathCreater(IWebElement element)
        {
            this.element = element;
        }


    }
}
