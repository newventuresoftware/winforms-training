using System;

namespace DbApp.Core
{
    public abstract class Presenter<TView> : IPresenter
        where TView : class, IView
    {
        public Presenter(TView view)
        {
            if (view == null)
                throw new ArgumentNullException();

            this.view = view;
        }

        protected readonly TView view;

        public IView View => this.view;

        public virtual void Init(object data)
        {
        }
    }
}
