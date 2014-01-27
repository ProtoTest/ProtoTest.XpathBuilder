namespace ProtoTest.XpathBuilder
{
    public class GolemElementBuilder
    {
        private string GolemElement;
        private string baseGolemElementSting = "public Element {0} = new Element(\"{1}\", By.XPath(\"{2}\"));";
        public string ElementName { get; set; }
        public string ElementLocator { get; set; }


        public string GetGolemElement()
        {
            if (ElementName != null && ElementLocator != null)
            {
                GolemElement = string.Format(baseGolemElementSting, ElementName, ElementName,
                    ElementLocator.Replace("\"", "\\\""));
            }
            return GolemElement;
        }
    }
}