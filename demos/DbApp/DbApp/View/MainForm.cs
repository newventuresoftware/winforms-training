using DbApp.Core;
using DbApp.Model;
using System.ComponentModel;
using System.Linq;
using Telerik.WinControls.UI;

namespace DbApp.View
{
    public partial class MainForm : RadForm, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public Presenter.MainPresenter Presenter { get; set; }

        public BindingList<Customer> Customers
        {
            get => radGridView1.DataSource as BindingList<Customer>;
            set => radGridView1.DataSource = value;
        }

        public IPresenter GetPresenter() => this.Presenter;

        private void OnDeleteClick(object sender, System.EventArgs e)
        {
            Customer selectedCustomer = this.radGridView1.SelectedRows.FirstOrDefault()?.DataBoundItem as Customer;
            if (selectedCustomer != null)
                this.Presenter?.DeleteCustomer(selectedCustomer);
        }

        private void OnEditClick(object sender, System.EventArgs e)
        {
            Customer selectedCustomer = this.radGridView1.SelectedRows.FirstOrDefault()?.DataBoundItem as Customer;
            if (selectedCustomer != null)
                this.Presenter?.EditCustomer(selectedCustomer);
        }

        private void OnAddNewClick(object sender, System.EventArgs e)
        {
            this.Presenter?.AddNewCustomer();
        }

        private void OnCommandCellClick(object sender, GridViewCellEventArgs e)
        {
            GridCommandCellElement cell = sender as GridCommandCellElement;
            Customer customer = cell.RowElement.Data.DataBoundItem as Customer;
            this.Presenter?.ShowOrderedProductsDetails(customer);
        }
    }

    public interface IMainView : Core.IView
    {
        BindingList<Model.Customer> Customers { get; set; }

        Presenter.MainPresenter Presenter { get; set; }
    }
}
