using System;
using System.Windows.Forms;

namespace TPFHello
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void OnHelloClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Telerik Presentation Foundation!");
        }
    }
}
