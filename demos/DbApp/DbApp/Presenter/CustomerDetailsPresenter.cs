using DbApp.Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DbApp.Presenter
{
    public class CustomerDetailsPresenter : Core.Presenter<View.ICustomerDetailsView>
    {
        public CustomerDetailsPresenter(View.ICustomerDetailsView view)
            : base(view)
        { }

        public override void Init(object data)
        {
            base.Init(data);
            Model.Customer customer = (Model.Customer)data;
            this.view.Title = string.IsNullOrEmpty(customer.CustomerID) ?
                "New Customer" : $"Edit {customer.CustomerID}";
            this.view.Customer = customer;
        }

        public IDictionary<string, string> Validate()
        {
            var errors = new Dictionary<string, string>();
            Customer customer = this.view.Customer;

            // CustomerID validation
            if (customer.CustomerID == null || !Regex.IsMatch(customer.CustomerID, "^[A-Z]{5}$"))
            {
                errors.Add(nameof(customer.CustomerID),
                    "<html><size=10><b><color= Red>Customer ID : </b><color= Black>Customer ID must be exactly 5 uppercase symbols long.");
            }

            // CompanyName validation
            if (string.IsNullOrEmpty(customer.CompanyName))
            {
                errors.Add(nameof(customer.CompanyName),
                    "<html><size=10><b><color= Red>Company Name : </b><color= Black>Company name is required.");
            }

            return errors;
        }
    }
}
