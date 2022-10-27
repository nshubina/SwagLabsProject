using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SwagLabsProject.Login;
using System;

namespace SwagLabsProject.Tests
{
    public class LoginPageTest : BasePO
    {
        [Test]
        public void LogInWithUseValidAndExistCredsShouldUserIsLogedIn()
        {
            var loginPage = new LoginPage(Driver);
            var productsPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            loginPage.AssertHeadersAreEqual(productsPage.GetCategoryTitle(), "PRODUCTS");
        }

        [Test]
        public void LogInWithUseInvalidUserNameAndValidPasswordShouldAppearErrorMsg()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.LoginWithCreds("testuser12", "secret_sauce");

            var waiter = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            waiter.Until(ExpectedConditions.ElementIsVisible(By.ClassName("error-button")));

            var errorMsg = "Epic sadface: Username and password do not match any user in this service";
            loginPage.AssertElementsAreEqual(loginPage.GetErrorMessage(), errorMsg);
        }

        [Test]
        public void LogInWithEmptyRequiredFieldsShouldAppearErrorMsg()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.LoginWithCreds("", "");

            var waiter = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            waiter.Until(ExpectedConditions.ElementIsVisible(By.ClassName("error-button")));

            var errorMsg = "Epic sadface: Username is required";
            loginPage.AssertElementsAreEqual(loginPage.GetErrorMessage(), errorMsg);
        }
    }
}

