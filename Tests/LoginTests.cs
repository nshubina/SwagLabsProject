using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SwagLabsProject.Login;
using System;

namespace SwagLabsProject.Tests
{
    [TestFixture]
    public class LoginTests:BasePO
    {
      
        [Test]
        public void LogIn_UseValidAndExistCreds_UserIsLogedIn()
        {
            var loginPage = new LoginPO(Driver);

            var homePage = loginPage.LoginWithCreds("standard_user", "secret_sauce");
          
            Assert.AreEqual(homePage.getTitle(), "PRODUCTS");

        }

        [Test]
        public void LogIn_UseInvalidUserNameAndValidPassword_AppearErrorMsg()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            string ErrorMsg = "Epic sadface: Username and password do not match any user in this service";

            LoginPO loginPage = new LoginPO(Driver);
            
            loginPage.LoginWithCreds("testuser12", "secret_sauce");
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("error-button")));

            Assert.AreEqual(loginPage.GetErrorMessage(), ErrorMsg);

        }



    }
}
