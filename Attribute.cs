using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProtoTest.Specter
{
    public class Attribute
    {
        public string name;
        public string value;

        public Attribute(string name, string value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
