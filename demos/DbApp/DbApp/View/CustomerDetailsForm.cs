using DbApp.Core;
using DbApp.Presenter;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Telerik.WinControls.UI;
using System.Drawing;

namespace DbApp.View
{
    public partial class CustomerDetailsForm : Telerik.WinControls.UI.RadForm, ICustomerDetailsView
    {
        static CustomerDetailsForm()
        {
            customerPropertyMap = new Dictionary<string, string>();
            var properties = typeof(Model.Customer).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (var prop in properties)
            {
                var attr = prop.GetCustomAttributes(typeof(System.ComponentModel.DisplayNameAttribute), false).Cast<System.ComponentModel.DisplayNameAttribute>();
                string displayName = prop.Name;
                if (attr != null && attr.Any())
                    displayName = attr.First().DisplayName; 
                customerPropertyMap.Add(displayName, prop.Name);
            }
        }

        public CustomerDetailsForm()
        {
            InitializeComponent();
            this.radDataEntry1.ShowValidationPanel = true;
        }

        public static string ViewName => "CustomerDetailsView";
        private static Dictionary<string, string> customerPropertyMap;

        public CustomerDetailsPresenter Presenter { get; set; }
        public string Title { get => this.Text; set => this.Text = value; }
        public Model.Customer Customer
        {
            get => (Model.Customer)this.radDataEntry1.DataSource;
            set => this.radDataEntry1.DataSource = value;
        }

        public IPresenter GetPresenter() => this.Presenter;

        private void OnItemValidated(object sender, Telerik.WinControls.UI.ItemValidatedEventArgs e)
        {
            var errors = this.Presenter.Validate();
            string propName = customerPropertyMap[e.Label.Text];
            if (errors.TryGetValue(propName, out string error))
            {
                e.ErrorProvider.SetError(sender as Control, error);
                DisplayValidationError(propName, error);
            }
            else
            {
                e.ErrorProvider.Clear();
                this.radDataEntry1.ValidationPanel.PanelContainer.Controls.RemoveByKey(propName);
            }
        }

        private void OnOkButtonClick(object sender, System.EventArgs e)
        {
            var errors = this.Presenter.Validate();
            if (errors.Count == 0)
            {
                this.DialogResult = DialogResult.OK;
                return;
            }

            this.radDataEntry1.ValidationPanel.PanelContainer.Controls.Clear();
            foreach (var item in errors)
            {
                DisplayValidationError(item.Key, item.Value);
            }
        }

        private void DisplayValidationError(string propName, string error)
        {
            if (this.radDataEntry1.ValidationPanel.PanelContainer.Controls.ContainsKey(propName))
                return;
            RadLabel label = new RadLabel();
            label.Name = propName;
            label.Text = error;
            label.Dock = DockStyle.Top;
            label.AutoSize = false;
            label.BackColor = Color.Transparent;
            this.radDataEntry1.ValidationPanel.PanelContainer.Controls.Add(label);
        }
    }

    public interface ICustomerDetailsView : Core.IView
    {
        Presenter.CustomerDetailsPresenter Presenter { get; set; }

        string Title { get; set; }
        Model.Customer Customer { get; set; }
    }
}
