using GoogleSearch.Models;

namespace GoogleSearch.Factories
{
    public static class GoogleSearchFactory
    {
        public static GoogleModel Create()
        {
            return new GoogleModel
            {
                SearchInput = "Selenium"
            };
        }
    }
}
