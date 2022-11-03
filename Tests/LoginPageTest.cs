using NUnit.Framework;
using SwagLabsProject.Helpers;
using SwagLabsProject.PagesPO.Login;


namespace SwagLabsProject.Tests
{
    public class LoginPageTest : BasePO
    {
        [Test]
        [Description("LogIn use valid and exist creds")]
        public void LogInWithUseValidAndExistCredsShouldUserIsLogedIn()
        {
            var loginPage = new LoginPage(Driver);
            var productsPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            loginPage.AssertElementsAreEqual(productsPage.GetCategoryTitle(), "PRODUCTS");
        }

        [Test]
        [Description("Appear error message when a user logs in with invalid creds")]

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
        [Description("Appear error message when a user logs in with empty creds")]

        public void LogInWithEmptyRequiredFieldsShouldAppearErrorMsg()
        {
            var loginPage = new LoginPage(Driver)
                .SetPassword("")
                .SetPassword("")
                .PressLoginButton();

            Waitings.WaitUntil(Driver, loginPage._xBtn, 5);

            loginPage.AssertElementsAreEqual(loginPage.GetErrorMessage(), "Epic sadface: Username is required");
        }
    }
}

