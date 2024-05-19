using NUnit.Framework;
using SauceDemoTests.Pages;
using SauceDemoTests.Utilities;

namespace SauceDemoTests.Tests
{
    public class CartTests : TestBase
    {
        [Test]
        public void CheckoutTest()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Login("standard_user", "secret_sauce");

            var productsPage = new ProductsPage(Driver);
            productsPage.AddFirstProductToCart();
            productsPage.OpenCart();

            var cartPage = new CartPage(Driver);
            cartPage.Checkout();

            Assert.That(Driver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-step-one.html"));
        }
    }
}
