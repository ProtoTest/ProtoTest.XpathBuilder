namespace ProtoTest.XpathBuilder
{
    partial class SpecterSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecterSplash));
            this.SpecterSplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SpecterSplashTitle = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // SpecterSplashTimer
            // 
            this.SpecterSplashTimer.Enabled = true;
            this.SpecterSplashTimer.Interval = 50;
            this.SpecterSplashTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SpecterSplashTitle
            // 
            this.SpecterSplashTitle.AutoSize = true;
            this.SpecterSplashTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SpecterSplashTitle.Font = new System.Drawing.Font("Verb Ultra", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecterSplashTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.SpecterSplashTitle.Location = new System.Drawing.Point(71, 5);
            this.SpecterSplashTitle.Name = "SpecterSplashTitle";
            this.SpecterSplashTitle.Size = new System.Drawing.Size(144, 34);
            this.SpecterSplashTitle.TabIndex = 0;
            this.SpecterSplashTitle.Text = "SPECTER";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 440);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(258, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // SpecterSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(282, 475);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SpecterSplashTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpecterSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpecterSplash";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SpecterSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SpecterSplashTimer;
        private System.Windows.Forms.Label SpecterSplashTitle;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}