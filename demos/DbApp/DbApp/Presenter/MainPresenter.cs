using DbApp.Core;
using DbApp.Model;
using DbApp.Services;
using DbApp.View;
using System.ComponentModel;

namespace DbApp.Presenter
{
    public class MainPresenter : Core.Presenter<IMainView>
    {
        public MainPresenter(IMainView mainView, ICustomersService customersService, IWindowManager windowManager)
            : base(mainView)
        {
            this.customersService = customersService;
            this.windowManager = windowManager;

            LoadData();
        }

        private ICustomersService customersService;
        private IWindowManager windowManager;
        private BindingList<Customer> customers;

        private async void LoadData()
        {
            this.customers = await customersService.GetCustomersAsync();
            this.view.Customers = this.customers;
        }

        public async void AddNewCustomer()
        {
            Model.Customer newCustomer = this.customersService.CreateNewCustomer();
            var result = await this.windowManager.NavigateToModal(DbApp.View.CustomerDetailsForm.ViewName, newCustomer);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                customers.Add(newCustomer);
                await this.customersService.Save();
            }
        }

        public void DeleteCustomer(Model.Customer customer)
        {
            this.customers.Remove(customer);
            this.customersService.Save();
        }

        public async void EditCustomer(Model.Customer customer)
        {
            var result = await this.windowManager.NavigateToModal(DbApp.View.CustomerDetailsForm.ViewName, customer);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                await this.customersService.Save();
            }
        }

        public void ShowOrderedProductsDetails(Model.Customer customer)
        {
            this.windowManager.NavigateTo(DbApp.View.CustomerProductsForm.ViewName, customer);
        }
    }
}
