using OpenQA.Selenium;

namespace DemoWebShopTests.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected string baseUrl;

        public BasePage(IWebDriver driver, string baseUrl)
        {
            this.driver = driver;
            this.baseUrl = baseUrl;
        }
    }
}