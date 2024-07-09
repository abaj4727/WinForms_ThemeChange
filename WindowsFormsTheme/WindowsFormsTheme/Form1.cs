using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsTheme
{
    public partial class Form1 : Form
    {
        //public Form1()
        //{
        //    InitializeComponent();
        //    AddUserControlToPanel();
        //}

        //private void AddUserControlToPanel()
        //{
        //    UserControl1 userControl = new UserControl1();
        //    userControl.Dock = DockStyle.Fill;
        //    panel_UC.Controls.Clear();
        //    panel_UC.Controls.Add(userControl);
        //}
        private ThemeManager _themeManager;

        public Form1()
        {
            InitializeComponent();
            AddUserControlToPanel();

            _themeManager = new ThemeManager();
            _themeManager.ThemeChanged += OnThemeChanged;

            // Subscribe to the CheckedChanged event of the radio buttons
            rbDark.CheckedChanged += RadioButton_CheckedChanged;
            rdLight.CheckedChanged += RadioButton_CheckedChanged;

            // Set initial theme
            if (rbDark.Checked)
                ChangeTheme("Dark");
            else if (rdLight.Checked)
                ChangeTheme("Light");
        }

        private void AddUserControlToPanel()
        {
            UserControl1 userControl = new UserControl1();
            userControl.Dock = DockStyle.Fill;
            panel_UC.Controls.Clear();
            panel_UC.Controls.Add(userControl);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDark.Checked)
                ChangeTheme("Dark");
            else if (rdLight.Checked)
                ChangeTheme("Light");
        }

        private void ChangeTheme(string themeName)
        {
            _themeManager.ApplyTheme(themeName);
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            ApplyCurrentTheme();
        }

        private void ApplyCurrentTheme()
        {
            var theme = _themeManager.CurrentTheme;

            this.BackColor = System.Drawing.Color.FromArgb(theme.BackgroundColor.ToArgb());
            this.ForeColor = System.Drawing.Color.FromArgb(theme.ForegroundColor.ToArgb());
            this.Font = theme.Font;
            foreach(Control  cntrl in this.Controls)
            {
                ApplyThemeToControl(cntrl, theme);
            }
            //ApplyThemeToControl(title_lbl, theme);
            //ApplyThemeToControl(selectTheme_lbl, theme);
            //ApplyThemeToControl(rbDark, theme);
            //ApplyThemeToControl(rdLight, theme);
            //ApplyThemeToControl(pictureBox1, theme);
            //ApplyThemeToControl(monthCalendar1, theme);
            if (panel_UC.Controls.Count > 0 && panel_UC.Controls[0] is UserControl1)
            {
                UserControl1 userControl = (UserControl1)panel_UC.Controls[0];
                userControl.ApplyTheme(theme);
            }
        }

        private void ApplyThemeToControl(Control control, Theme theme)
        {
            control.BackColor = System.Drawing.Color.FromArgb(theme.BackgroundColor.ToArgb());
            control.ForeColor = System.Drawing.Color.FromArgb(theme.ForegroundColor.ToArgb());
            control.Font = theme.Font;
            if (control is PictureBox)
            {
                pictureBox1.Image = theme.image;
            }
            if (control is Label)
            {
                title_lbl.Text = "Current Theme is " + theme.Themename;
                title_lbl.Font = new System.Drawing.Font("Arial", 18);
            }

        }


    }
}
