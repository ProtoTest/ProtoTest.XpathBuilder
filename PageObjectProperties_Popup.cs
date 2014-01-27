using System;
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
<<<<<<< HEAD
           Program.specter.SetElementText(pageObject.GetPageObjectCode());
            this.Dispose();
=======
            Program.specter.ShowElementText(pageObject.GetPageObjectCode());
            Dispose();
>>>>>>> Resharper code cleanup
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void PageName_tb_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
