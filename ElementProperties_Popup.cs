using System;
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
<<<<<<< HEAD
                //This function gets called when the user changes tabs
                //This function gets called when the user changes tabs
                Program.specter.Elements_rtb.Clear();
                for (int x = 0; x < Program.elements.Count; x++)
                {
                    Program.specter.Elements_rtb.AppendText(Program.elements[x].GetGolemElement());
                    Program.specter.Elements_rtb.AppendText("\n");
                }
                this.Dispose();
=======
                Dispose();
>>>>>>> Resharper code cleanup
            }
            else
            {
                ErrorText_Label.Visible = true;
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Program.elements.RemoveAt(Program.elements.Count - 1);
            Dispose();
        }
    }
}
