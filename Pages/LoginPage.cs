using OpenQA.Selenium;

public class LoginPage
{
    private IWebDriver driver;
    private By usernameField = By.Id("user-name");
    private By passwordField = By.Id("password");
    private By loginButton = By.ClassName("btn_action");

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void EnterUsername(string username)
    {
        driver.FindElement(usernameField).SendKeys(username);
    }

    public void EnterPassword(string password)
    {
        driver.FindElement(passwordField).SendKeys(password);
    }

    public void ClickLogin()
    {
        driver.FindElement(loginButton).Click();
    }

    public bool IsLoginSuccessful()
    {
        try
        {
            // Synchronously get the current URL of the browser.
            string currentUrl = driver.Url;

            // Check if the URL contains the expected path indicating a successful login.
            if (currentUrl.Contains("/inventory.html"))
            {
                return true; // Login successful as the URL is as expected.
            }
        }
        catch (Exception ex)
        {
            // The following exception will be replaced by a proper logging framework.
            Console.WriteLine("Exception in IsLoginSuccessful: " + ex.Message);
        }

        return false; // Default to false if the URL check fails or an exception occurs.
    }

}