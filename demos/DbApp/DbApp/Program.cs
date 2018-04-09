using System;
using System.Windows.Forms;

namespace DbApp
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

            Services.CustomersService customersService = new Services.CustomersService();
            Core.IWindowManager windowManager = new Core.WindowManager();

            // MVP wire-up
            windowManager.RegisterView(View.CustomerDetailsForm.ViewName, () =>
            {
                View.CustomerDetailsForm view = new View.CustomerDetailsForm();
                Presenter.CustomerDetailsPresenter presenter = new Presenter.CustomerDetailsPresenter(view);
                view.Presenter = presenter;
                return view;
            });
            windowManager.RegisterView(View.CustomerProductsForm.ViewName, () =>
            {
                View.CustomerProductsForm view = new View.CustomerProductsForm();
                Presenter.CustomerProductsPresenter presenter = new Presenter.CustomerProductsPresenter(view, customersService);
                view.Presenter = presenter;
                return view;
            });            

            View.MainForm mainView = new View.MainForm();
            Presenter.MainPresenter customerPresenter = new Presenter.MainPresenter(mainView, customersService, windowManager);
            mainView.Presenter = customerPresenter;

            Application.Run(mainView);
        }
    }
}