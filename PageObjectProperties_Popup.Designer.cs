namespace ProtoTest.XpathBuilder
{
    partial class PageObjectProperties_Popup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorText_Label = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Ok_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Namespace_tb = new System.Windows.Forms.TextBox();
            this.PageName_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PageName_tb);
            this.panel1.Controls.Add(this.ErrorText_Label);
            this.panel1.Controls.Add(this.Cancel_button);
            this.panel1.Controls.Add(this.Ok_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Namespace_tb);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 161);
            this.panel1.TabIndex = 0;
            // 
            // ErrorText_Label
            // 
            this.ErrorText_Label.AutoSize = true;
            this.ErrorText_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorText_Label.Location = new System.Drawing.Point(155, 94);
            this.ErrorText_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorText_Label.Name = "ErrorText_Label";
            this.ErrorText_Label.Size = new System.Drawing.Size(275, 17);
            this.ErrorText_Label.TabIndex = 6;
            this.ErrorText_Label.Text = "Values cannot be blank or contain spaces!";
            this.ErrorText_Label.Visible = false;
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_button.Location = new System.Drawing.Point(356, 118);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(83, 36);
            this.Cancel_button.TabIndex = 5;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Ok_button
            // 
            this.Ok_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok_button.Location = new System.Drawing.Point(447, 118);
            this.Ok_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(83, 36);
            this.Ok_button.TabIndex = 4;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = false;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Enter a Name and Namespace";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Page Name";
            // 
            // Namespace_tb
            // 
            this.Namespace_tb.Location = new System.Drawing.Point(203, 63);
            this.Namespace_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Namespace_tb.Name = "Namespace_tb";
            this.Namespace_tb.Size = new System.Drawing.Size(240, 22);
            this.Namespace_tb.TabIndex = 0;
            // 
            // PageName_tb
            // 
            this.PageName_tb.Location = new System.Drawing.Point(203, 33);
            this.PageName_tb.Margin = new System.Windows.Forms.Padding(4);
            this.PageName_tb.Name = "PageName_tb";
            this.PageName_tb.Size = new System.Drawing.Size(240, 22);
            this.PageName_tb.TabIndex = 7;
            this.PageName_tb.TextChanged += new System.EventHandler(this.PageName_tb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Namespace";
            // 
            // ElementProperties_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(547, 170);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElementProperties_Popup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Element Properties";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Ok_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Namespace_tb;
        private System.Windows.Forms.Label ErrorText_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PageName_tb;
    }
}