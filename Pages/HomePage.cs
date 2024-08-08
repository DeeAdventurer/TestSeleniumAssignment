using OpenQA.Selenium;

namespace DemoWebShopTests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver, string baseUrl) : base(driver, baseUrl) { }

        public void GoTo()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public void ClickLogin()
        {
            driver.FindElement(By.LinkText("Log in")).Click();
        }

        public void ClickJewelryCategory()
        {
            driver.FindElement(By.LinkText("Jewelry")).Click();
        }

        public void ClickLogout()
        {
            driver.FindElement(By.LinkText("Log out")).Click();
        }

        public string GetLoggedInUserEmail()
        {
            return driver.FindElement(By.CssSelector("a.account")).Text;
        }
    }
}