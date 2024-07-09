using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;


namespace WindowsFormsTheme
{
    class ThemeManager
    {
        private Dictionary<string, Theme> _themes;
        private Theme _currentTheme;

        public ThemeManager()
        {
            LoadThemes();
        }

        private void LoadThemes()
        {
            // Load themes from resources or configuration files
            _themes = new Dictionary<string, Theme>
            {
                { "Light", new Theme { BackgroundColor = System.Drawing.Color.White, ForegroundColor = System.Drawing.Color.Black, Font = new System.Drawing.Font("Arial", 10),image=Properties.Resources.light, Themename= "Light" } },
                { "Dark", new Theme { BackgroundColor = System.Drawing.Color.Black, ForegroundColor = System.Drawing.Color.White, Font = new System.Drawing.Font("Arial", 10),image=Properties.Resources.dark,Themename= "Dark"  }}
            };
        }

        public void ApplyTheme(string themeName)
        {
            if (_themes.ContainsKey(themeName))
            {
                _currentTheme = _themes[themeName];
                OnThemeChanged();
            }
        }

        private void OnThemeChanged()
        {
            if (ThemeChanged != null)
            {
                ThemeChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler ThemeChanged;
        public Theme CurrentTheme
        {
            get { return _currentTheme; }
        }
    }
}
