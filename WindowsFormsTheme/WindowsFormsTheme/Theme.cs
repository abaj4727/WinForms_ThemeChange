using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsTheme
{
    public class Theme
    {
        public System.Drawing.Color BackgroundColor { get; set; }
        public System.Drawing.Color ForegroundColor { get; set; }
        public System.Drawing.Font Font { get; set; }
        public System.Drawing.Image image{get;set;}
        public string Themename { get; set; }
        // Other style properties
    }
}
