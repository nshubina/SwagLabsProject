using NUnit.Framework;
using OpenQA.Selenium;
using SwagLabsProject.Login;

namespace SwagLabsProject.Tests
{
    [TestFixture]
    public class LoginTests:BasePO
    {
      
        [Test]
        public void LogIn_UseValidAndExistCreds_UserIsLogedIn()
        {
            LoginPO loginPage = new LoginPO(_driver);

            loginPage.LogInWithCreds("standard_user", "secret_sauce");
            loginPage.CheckThatUserIsLoggedIn("https://www.saucedemo.com/inventory.html");

        }

    }
}
