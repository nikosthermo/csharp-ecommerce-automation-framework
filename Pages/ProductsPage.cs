using OpenQA.Selenium;

namespace SauceDemoTests.Pages
{
    public class ProductsPage
    {
        private readonly IWebDriver _driver;
        public ProductsPage(IWebDriver driver) => _driver = driver;

        private IWebElement ProductSortContainer => _driver.FindElement(By.ClassName("product_sort_container"));
        private IWebElement FirstProductAddToCartButton => _driver.FindElement(By.ClassName("btn_inventory"));

        public void AddFirstProductToCart()
        {
            FirstProductAddToCartButton.Click();
        }

        public void OpenCart()
        {
            _driver.FindElement(By.ClassName("shopping_cart_link")).Click();
        }
    }
}
