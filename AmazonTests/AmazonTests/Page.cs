using OpenQA.Selenium;

namespace Pages
{
    public abstract class Page
    {
        protected IWebDriver driver;

        protected string url;
    }
}
