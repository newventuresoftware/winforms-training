using System.ComponentModel;

namespace DbApp.Model
{
    public class Customer
    {
        public Customer(Data.CustomerDTO dto)
        {
            this.dto = dto;
        }

        private Data.CustomerDTO dto;

        [DisplayName("Customer ID")]
        public string CustomerID { get => this.dto.CustomerID; set => this.dto.CustomerID = value; }

        [DisplayName("Company Name")]
        public string CompanyName { get => this.dto.CompanyName; set => this.dto.CompanyName = value; }

        [DisplayName("Contact Name")]
        public string ContactName { get => this.dto.ContactName; set => this.dto.ContactName = value; }

        [DisplayName("Contact Title")]
        public string ContactTitle { get => this.dto.ContactTitle; set => this.dto.ContactTitle = value; }

        public string Address { get => this.dto.Address; set => this.dto.Address = value; }

        public string City { get => this.dto.City; set => this.dto.City = value; }

        public string Region { get => this.dto.Region; set => this.dto.Region = value; }

        public string PostalCode { get => this.dto.PostalCode; set => this.dto.PostalCode = value; }

        public string Country { get => this.dto.Country; set => this.dto.Country = value; }

        public string Phone { get => this.dto.Phone; set => this.dto.Phone = value; }

        public string Fax { get => this.dto.Fax; set => this.dto.Fax = value; }

        public Data.CustomerDTO ToDto() => this.dto;
    }
}
