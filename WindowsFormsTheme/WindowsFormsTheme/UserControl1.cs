using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsTheme
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void ApplyTheme(Theme theme)
        {
            this.BackColor = theme.BackgroundColor;
            this.ForeColor = theme.ForegroundColor;
            this.Font = theme.Font;
            label1.Text = "UserCntrl";

        }
    }
}
