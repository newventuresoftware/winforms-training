using DbApp.Data;
using DbApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DbApp.Services
{
    public interface ICustomersService
    {
        Task<BindingList<Customer>> GetCustomersAsync();
        Task<int> Save();

        Customer CreateNewCustomer();
        IList<ProductReport> CreateCustomerProductReports(Customer customer);
    }

    public class CustomersService : ICustomersService
    {
        public CustomersService()
        {
            this.context = new NorthwindEntities();
        }

        private NorthwindEntities context;

        public Customer CreateNewCustomer()
        {
            var newCustomerDto = this.context.Customers.Create();
            return new Customer(newCustomerDto);
        }

        public async Task<BindingList<Customer>> GetCustomersAsync()
        {
            await context.Customers.LoadAsync();
            return new CustomerBindingList(context.Customers);
        }

        public Task<int> Save()
        {
            return this.context.SaveChangesAsync();
        }

        public IList<ProductReport> CreateCustomerProductReports(Customer customer)
        {
            var dto = customer.ToDto();
            var query = dto.Orders
                .SelectMany(c => c.Order_Details)
                .GroupBy(c => c.Products.ProductName)
                .Select(item => new ProductReport()
                {
                    Product = item.Key,
                    TotalQuantity = item.Sum(c => c.Quantity),
                    TotalSpent = item.Sum(c => c.Quantity * (c.UnitPrice * Convert.ToDecimal(1 - c.Discount)))
                })
                .OrderBy(c => c.TotalSpent);
            return query.ToArray();
        }

        private class CustomerBindingList : BindingList<Customer>
        {
            public CustomerBindingList(DbSet<CustomerDTO> customers)
                : base(customers.Local.Select(dto => new Customer(dto)).ToList())
            {
                this.customers = customers;
            }

            private DbSet<CustomerDTO> customers;

            protected override void ClearItems()
            {
                customers.Local.Clear();

                base.ClearItems();
            }

            protected override void InsertItem(int index, Customer customer)
            {
                var dto = customer.ToDto();
                this.customers.Add(dto);

                base.InsertItem(index, customer);
            }

            protected override void RemoveItem(int index)
            {
                var dto = this[index].ToDto();
                dto.Orders.Clear();
                this.customers.Remove(dto);

                base.RemoveItem(index);
            }
        }
    }
}
