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
        public void LogIn_WithUseValidAndExistCreds_ShouldUserIsLogedIn()
        {
            var loginPage = new LoginPO(Driver);

            var productsPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");
          
            Assert.AreEqual(productsPage.GetCategoryTitle(), "PRODUCTS");
        } 

        [Test]
        public void LogIn_WithUseInvalidUserNameAndValidPassword_ShouldAppearErrorMsg()
        {
            var loginPage = new LoginPO(Driver);         
            loginPage.LoginWithCreds("testuser12", "secret_sauce");

            var waiter = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            waiter.Until(ExpectedConditions.ElementIsVisible(By.ClassName("error-button")));

            var errorMsg = "Epic sadface: Username and password do not match any user in this service";
            Assert.AreEqual(loginPage.GetErrorMessage(), errorMsg);
        }

        [Test]
        public void LogIn_WithEmptyRequiredFields_ShouldAppearErrorMsg()
        {
            var loginPage = new LoginPO(Driver);
            loginPage.LoginWithCreds("", "");

            var waiter = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            waiter.Until(ExpectedConditions.ElementIsVisible(By.ClassName("error-button")));

            var errorMsg = "Epic sadface: Username is required";
            Assert.AreEqual(loginPage.GetErrorMessage(), errorMsg);
        }
    }
}
