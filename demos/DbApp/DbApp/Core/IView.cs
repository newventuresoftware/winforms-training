namespace DbApp.Core
{
    public interface IView
    {
        IPresenter GetPresenter();
    }
}
