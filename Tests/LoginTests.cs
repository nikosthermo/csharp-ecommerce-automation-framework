using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class LoginTests
{
    private IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
    }

    [Test]
    public void TestSuccessfulLogin()
    {
        var loginPage = new LoginPage(driver);
        loginPage.EnterUsername("standard_user");
        loginPage.EnterPassword("secret_sauce");
        loginPage.ClickLogin();
        
        Assert.IsTrue(loginPage.IsLoginSuccessful(), "User should be logged in successfully.");
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}