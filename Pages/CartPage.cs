using OpenQA.Selenium;

namespace SauceDemoTests.Pages
{
    public class CartPage
    {
        private readonly IWebDriver _driver;
        public CartPage(IWebDriver driver) => _driver = driver;

        public void Checkout()
        {
            _driver.FindElement(By.Id("checkout")).Click();
        }
    }
}
