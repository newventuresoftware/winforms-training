using DbApp.Core;
using DbApp.Model;
using DbApp.Presenter;
using System.Collections.Generic;

namespace DbApp.View
{
    public partial class CustomerProductsForm : Telerik.WinControls.UI.RadForm, ICustomerProductsView
    {
        public CustomerProductsForm()
        {
            InitializeComponent();
        }

        public static string ViewName => "CustomerProductsView";

        public CustomerProductsPresenter Presenter { get; set; }
        public string Title { get => this.Text; set => this.Text = value; }
        public IList<ProductReport> CustomerProductReports
        {
            get => (IList<ProductReport>)this.radChartView1.DataSource;
            set => this.radChartView1.DataSource = value;
        }

        public IPresenter GetPresenter() => this.Presenter;
    }

    public interface ICustomerProductsView : Core.IView
    {
        CustomerProductsPresenter Presenter { get; set; }

        string Title { get; set; }
        IList<ProductReport> CustomerProductReports { get; set; }
    }
}
