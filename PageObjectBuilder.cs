using System.Collections.Generic;
using System.Text;

namespace ProtoTest.XpathBuilder
{
    public class PageObjectBuilder
    {
        private readonly StringBuilder builder;
        public string category;
        public List<GolemElementBuilder> elements;
        public string name;
        private string output;

        public PageObjectBuilder(string name, string category, List<GolemElementBuilder> elements)
        {
            this.name = name;
            this.category = category;
            this.elements = elements;
            builder = new StringBuilder();
        }

        public string GetPageObjectCode()
        {
            builder.AppendLine("using OpenQA.Selenium;");
            builder.AppendLine("using ProtoTest.Golem.WebDriver;");
            builder.AppendLine("");
            builder.AppendLine(string.Format("namespace ProtoTest.Golem.PageObjects.{0}", category));
            builder.AppendLine("{");
            builder.AppendLine(string.Format("    public class {0} : BasePageObject", name));
            builder.AppendLine("    {");
            foreach (GolemElementBuilder ele in elements)
            {
                builder.AppendLine(string.Format("        {0}", ele.GetGolemElement()));
            }
            builder.AppendLine("");
            builder.AppendLine("        public override WaitForElements()");
            builder.AppendLine("        {");
            foreach (GolemElementBuilder ele in elements)
            {
                builder.AppendLine(string.Format("            {0}.Verify().Present();", ele.ElementName));
            }
            builder.AppendLine("        }");
            builder.AppendLine("    }");
            builder.AppendLine("}");

            return builder.ToString();
        }
    }
}