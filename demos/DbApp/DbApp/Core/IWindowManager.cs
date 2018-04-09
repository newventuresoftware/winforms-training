using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbApp.Core
{
    public interface IWindowManager
    {
        void RegisterView(string view, Func<Form> formInit);
        void NavigateTo(string view, object data);
        Task<DialogResult> NavigateToModal(string view, object data);
    }

    public class WindowManager : IWindowManager
    {
        public WindowManager()
        {
            dict = new Dictionary<string, Func<Form>>();
        }

        private Dictionary<string, Func<Form>> dict;

        public void NavigateTo(string view, object data)
        {
            Form form = CreateView(view, data);
            form.Show();
        }

        public Task<DialogResult> NavigateToModal(string view, object data)
        {
            TaskCompletionSource<DialogResult> tcs = new TaskCompletionSource<DialogResult>();
            Form form = CreateView(view, data);
            form.FormClosed += (s, e) =>
            {
                tcs.SetResult((s as Form).DialogResult);
            };

            form.ShowDialog();

            return tcs.Task;
        }

        public void RegisterView(string view, Func<Form> formInit)
        {
            this.dict.Add(view, formInit);
        }

        private Form CreateView(string view, object data)
        {
            Form form = null;
            if (!this.dict.TryGetValue(view, out Func<Form> formInit))
                throw new InvalidOperationException($"View {view} not registered!");

            form = formInit();
            (form as IView)?.GetPresenter()?.Init(data);
            return form;
        }
    }
}
