﻿using NUnit.Framework;
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
            var loginPage = new LoginPO(Driver);         
            loginPage.LoginWithCreds("testuser12", "secret_sauce");

            var waiter = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            waiter.Until(ExpectedConditions.ElementIsVisible(By.ClassName("error-button")));

            var errorMsg = "Epic sadface: Username and password do not match any user in this service";
            Assert.AreEqual(loginPage.GetErrorMessage(), errorMsg);
        }
    }
}
