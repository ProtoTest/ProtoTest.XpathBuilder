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
    public partial class PageObjectProperties_Popup : Form
    {
        public PageObjectProperties_Popup()
        {
            InitializeComponent();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            var pageObject = new PageObjectBuilder(PageName_tb.Text, Namespace_tb.Text, Program.elements);
           Program.specter.ShowElementText(pageObject.GetPageObjectCode());
            this.Dispose();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
          
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PageName_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
