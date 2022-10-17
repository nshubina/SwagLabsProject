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
            var loginPage = new LoginPO(Driver);

            var homePage = loginPage.LogInWithCreds("standard_user", "secret_sauce");
          
            Assert.AreEqual(homePage.getTitle(), "PRODUCTS");

            }

        [Test]
        public void LogIn_UseInvalidUserNameAndValidPassword_AppearErrorMsg()
        {
            LoginPO loginPage = new LoginPO(Driver);

            loginPage.LogInWithCreds("testuser12", "secret_sauce");

        }

    }
}
