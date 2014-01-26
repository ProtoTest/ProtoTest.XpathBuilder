using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProtoTest.Specter;

namespace ProtoTest.XpathBuilder
{
    public partial class ElementProperties_Popup : Form
    {
        public ElementProperties_Popup()
        {
            InitializeComponent();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            if (ElementName_tb.Text != "" && !ElementName_tb.Text.Contains(" "))
            {
                Program.elements[Program.elements.Count - 1].ElementName = ElementName_tb.Text;
                this.Dispose();
            }
            else
            {
                ErrorText_Label.Visible = true;
            }
            
            
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Program.elements.RemoveAt(Program.elements.Count - 1);
            this.Dispose();
        }
    }
}
