using System;
using System.Windows.Forms;

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
