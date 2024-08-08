using OpenQA.Selenium;

namespace DemoWebShopTests.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver, string baseUrl) : base(driver, baseUrl) 
        {

        }

        public string GetReturningCustomerHeader()
        {
            return driver.FindElement(By.CssSelector("div.returning-wrapper h2")).Text;
        }

        public void EnterEmail(string email)
        {
            driver.FindElement(By.Id("Email")).SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(By.Id("Password")).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(By.CssSelector("input.button-1.login-button")).Click();
        }
    }
}
