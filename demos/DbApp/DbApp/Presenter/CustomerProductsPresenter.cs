using DbApp.View;

namespace DbApp.Presenter
{
    public class CustomerProductsPresenter : Core.Presenter<View.ICustomerProductsView>
    {
        public CustomerProductsPresenter(ICustomerProductsView view, Services.ICustomersService service)
            : base(view)
        {
            this.service = service;
        }

        private Services.ICustomersService service;

        public override void Init(object data)
        {
            Model.Customer customer = (Model.Customer)data;
            var report = this.service.CreateCustomerProductReports(customer);
            this.view.Title = customer.CustomerID;
            this.view.CustomerProductReports = report;
        }
    }
}
