using System;
using System.Linq;
using System.Windows.Forms;

namespace TPFHello
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

            bool res = Telerik.WinControls.ThemeResolutionService.LoadPackageResource("TPFHello.MyControlDefault.tssp");
            Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = "MyControlDefault";

            Application.Run(new RadForm1());
        }
    }
}