using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProtoTest.XpathBuilder
{
    public partial class SpecterSplash : Form
    {
        public SpecterSplash()
        {
            InitializeComponent();
        }

        //Progress Bar Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1); //Internal last set to 50
            if (progressBar1.Value == 100) //Time length maximum (units of above)
            {
                this.SpecterSplashTimer.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SpecterSplash_Load(object sender, EventArgs e)
        {
            SpecterSplashTimer.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
