using OpenQA.Selenium;

namespace DemoWebShopTests.Pages
{
    public class CreateYourOwnJewelryPage : BasePage
    {
        public CreateYourOwnJewelryPage(IWebDriver driver, string baseUrl) : base(driver, baseUrl) { }

        public void SelectMaterial(string material)
        {
            driver.FindElement(By.Id("product_attribute_71_9_15")).SendKeys(material);
        }

        public void EnterLength(string length)
        {
            driver.FindElement(By.Id("product_attribute_71_10_16")).SendKeys(length);
        }

        public void SelectPendant(string pendant)
        {
            driver.FindElement(By.Id($"product_attribute_71_11_17_{pendant}")).Click();
        }

        public void IncreaseQuantity(int quantity)
        {
            var quantityElement = driver.FindElement(By.Id("addtocart_71_EnteredQuantity"));
            quantityElement.Clear();
            quantityElement.SendKeys(quantity.ToString());
        }

        public void ClickAddToCart()
        {
            driver.FindElement(By.Id("add-to-cart-button-71")).Click();
        }
    }
}