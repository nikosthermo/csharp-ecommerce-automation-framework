using NUnit.Framework;
using SauceDemoTests.Pages;
using SauceDemoTests.Utilities;

namespace SauceDemoTests.Tests
{
    public class AuthenticationTests : TestBase
    {
        [Test]
        public void ValidLoginTest()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Login("standard_user", "secret_sauce");

            Assert.That(Driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }
    }
}
