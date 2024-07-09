namespace WindowsFormsTheme
{
    partial class Form1
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
            this.title_lbl = new System.Windows.Forms.Label();
            this.rbDark = new System.Windows.Forms.RadioButton();
            this.selectTheme_lbl = new System.Windows.Forms.Label();
            this.rdLight = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel_UC = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Location = new System.Drawing.Point(73, 67);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(56, 13);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Title Label";
            // 
            // rbDark
            // 
            this.rbDark.AutoSize = true;
            this.rbDark.Location = new System.Drawing.Point(76, 146);
            this.rbDark.Name = "rbDark";
            this.rbDark.Size = new System.Drawing.Size(48, 17);
            this.rbDark.TabIndex = 1;
            this.rbDark.TabStop = true;
            this.rbDark.Text = "Dark";
            this.rbDark.UseVisualStyleBackColor = true;
            // 
            // selectTheme_lbl
            // 
            this.selectTheme_lbl.AutoSize = true;
            this.selectTheme_lbl.Location = new System.Drawing.Point(73, 120);
            this.selectTheme_lbl.Name = "selectTheme_lbl";
            this.selectTheme_lbl.Size = new System.Drawing.Size(69, 13);
            this.selectTheme_lbl.TabIndex = 2;
            this.selectTheme_lbl.Text = "Select theme";
            // 
            // rdLight
            // 
            this.rdLight.AutoSize = true;
            this.rdLight.Location = new System.Drawing.Point(76, 169);
            this.rdLight.Name = "rdLight";
            this.rdLight.Size = new System.Drawing.Size(48, 17);
            this.rdLight.TabIndex = 3;
            this.rdLight.TabStop = true;
            this.rdLight.Text = "Light";
            this.rdLight.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(299, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(154, 110);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // panel_UC
            // 
            this.panel_UC.Location = new System.Drawing.Point(393, 49);
            this.panel_UC.Name = "panel_UC";
            this.panel_UC.Size = new System.Drawing.Size(97, 223);
            this.panel_UC.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 290);
            this.Controls.Add(this.panel_UC);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdLight);
            this.Controls.Add(this.selectTheme_lbl);
            this.Controls.Add(this.rbDark);
            this.Controls.Add(this.title_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.RadioButton rbDark;
        private System.Windows.Forms.Label selectTheme_lbl;
        private System.Windows.Forms.RadioButton rdLight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel_UC;
    }
}

