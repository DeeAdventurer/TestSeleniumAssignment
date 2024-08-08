using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using DemoWebShopTests.Pages;
using System.IO;
using Newtonsoft.Json.Linq;

namespace DemoWebShopTests
{
    [TestFixture]
    public class DemoWebShopTests
    {
        private IWebDriver driver;
        private string baseUrl;
        private string email;
        private string password;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            var config = JObject.Parse(File.ReadAllText("appsettings.json"));
            baseUrl = config["baseUrl"].ToString();
            email = config["login"]["email"].ToString();
            password = config["login"]["password"].ToString();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestLoginAndJewelryPurchase()
        {
            var homePage = new HomePage(driver, baseUrl);
            var loginPage = new LoginPage(driver, baseUrl);
            var jewelryPage = new JewelryPage(driver, baseUrl);
            var createYourOwnJewelryPage = new CreateYourOwnJewelryPage(driver, baseUrl);
            var shoppingCartPage = new ShoppingCartPage(driver, baseUrl);

            homePage.GoTo();
            Assert.IsTrue(homePage.GetTitle().Contains("Demo Web Shop"));

            homePage.ClickLogin();
            Assert.AreEqual("Returning Customer", loginPage.GetReturningCustomerHeader());

            loginPage.EnterEmail(email);
            loginPage.EnterPassword(password);
            loginPage.ClickLoginButton();

            Assert.AreEqual(email, homePage.GetLoggedInUserEmail());

            homePage.ClickJewelryCategory();
            Assert.IsTrue(driver.Url.Contains("jewelry"));

            jewelryPage.SelectListView();
            jewelryPage.SelectCreateYourOwnJewelry();

            createYourOwnJewelryPage.SelectMaterial("Gold (1mm)");
            createYourOwnJewelryPage.EnterLength("30");
            createYourOwnJewelryPage.SelectPendant("17");
            createYourOwnJewelryPage.IncreaseQuantity(2);
            createYourOwnJewelryPage.ClickAddToCart();

            homePage.GoTo();
            homePage.ClickLogout();
        }
    }
}