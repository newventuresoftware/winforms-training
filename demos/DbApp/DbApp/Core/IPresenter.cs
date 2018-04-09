namespace DbApp.Core
{
    public interface IPresenter
    {
        void Init(object data);

        IView View { get; }
    }
}
