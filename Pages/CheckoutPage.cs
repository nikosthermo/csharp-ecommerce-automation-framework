using OpenQA.Selenium;

namespace SauceDemoTests.Pages
{
    public class CheckoutPage
    {
        private readonly IWebDriver _driver;
        public CheckoutPage(IWebDriver driver) => _driver = driver;

        public void EnterCheckoutInformation(string firstName, string lastName, string postalCode)
        {
            _driver.FindElement(By.Id("first-name")).SendKeys(firstName);
            _driver.FindElement(By.Id("last-name")).SendKeys(lastName);
            _driver.FindElement(By.Id("postal-code")).SendKeys(postalCode);
            _driver.FindElement(By.Id("continue")).Click();
        }

        public void FinishCheckout()
        {
            _driver.FindElement(By.Id("finish")).Click();
        }
    }
}
