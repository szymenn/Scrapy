namespace Scrapy.Core.Interfaces.PageObjects
{
    public interface IHomePage
    {
        void GoToPage();
        ISearchResultPage Search(string movie);
    }
}