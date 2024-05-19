using NUnit.Framework;
using SauceDemoTests.Pages;
using SauceDemoTests.Utilities;

namespace SauceDemoTests.Tests
{
    public class ProductsTests : TestBase
    {
        [Test]
        public void AddProductToCartTest()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Login("standard_user", "secret_sauce");

            var productsPage = new ProductsPage(Driver);
            productsPage.AddFirstProductToCart();
            productsPage.OpenCart();

            Assert.That(Driver.Url, Is.EqualTo("https://www.saucedemo.com/cart.html"));
        }
    }
}
