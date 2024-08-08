using OpenQA.Selenium;

namespace DemoWebShopTests.Pages
{
    public class JewelryPage : BasePage
    {
        public JewelryPage(IWebDriver driver, string baseUrl) : base(driver, baseUrl)
        { 


        }

        public void SelectListView()
        {
            driver.FindElement(By.Id("products-viewmode")).SendKeys("List");
        }

        public void SelectCreateYourOwnJewelry()
        {
            driver.FindElement(By.LinkText("Create Your Own Jewelry")).Click();
        }
    }
}
