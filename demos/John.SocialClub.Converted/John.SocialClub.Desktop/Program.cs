using System;
using System.Windows.Forms;
using Telerik.WinControls.Themes;

namespace John.SocialClub.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainTheme = new VisualStudio2012DarkTheme();
            //var mainTheme = new TelerikMetroTheme();
            Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = mainTheme.ThemeName;

            string currentDataDirectory = System.IO.Path.Combine(Environment.CurrentDirectory, "data");
            AppDomain.CurrentDomain.SetData("DataDirectory", currentDataDirectory);

            DialogResult result;
            using (var loginForm = new Login())
                result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
                Application.Run(new Forms.Membership.Manage());
        }
    }
}
