using OpenQA.Selenium;

namespace DemoWebShopTests.Pages
{
    public class ShoppingCartPage : BasePage
    {
        public ShoppingCartPage(IWebDriver driver, string baseUrl) : base(driver, baseUrl) 
        { 
        
        }

        public void SelectCountry(string country)
        {
            driver.FindElement(By.Id("CountryId")).SendKeys(country);
        }

        public void EnterZipCode(string zipCode)
        {
            driver.FindElement(By.Id("ZipPostalCode")).SendKeys(zipCode);
        }

        public void AgreeToTerms()
        {
            driver.FindElement(By.Id("termsofservice")).Click();
        }

        public void ClickCheckoutButton()
        {
            driver.FindElement(By.Id("checkout")).Click();
        }
    }
}
