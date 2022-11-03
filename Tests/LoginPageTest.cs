using NUnit.Framework;
using SwagLabsProject.Helpers;
using SwagLabsProject.PagesPO.Login;


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
            var loginPage = new LoginPage(Driver)
                .SetPassword("testuser12")
                .SetPassword("secret_sause")
                .PressLoginButton();

            Waitings.WaitUntil(Driver, loginPage._xBtn, 5);

            loginPage.AssertElementsAreEqual(loginPage.GetErrorMessage(), "Epic sadface: Username and password do not match any user in this service");
        }

        [Test]
        public void LogInWithEmptyRequiredFieldsShouldAppearErrorMsg()
        {
            var loginPage = new LoginPage(Driver)
                .SetPassword("")
                .SetPassword(" ")
                .PressLoginButton();

            Waitings.WaitUntil(Driver, loginPage._xBtn, 5);

            loginPage.AssertElementsAreEqual(loginPage.GetErrorMessage(), "Epic sadface: Username is required");
        }
    }
}

