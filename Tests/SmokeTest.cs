using NUnit.Framework;
using SwagLabsProject.Helpers;
using SwagLabsProject.PagesPO.Login;

namespace SwagLabsProject.Tests
{
    [TestFixture]

    public class SmokeTest : BasePO
    {
        [Test]
        [Description("Smoke Test")]
        public void PositiveSmokeFlow()
        {
            var loginPage = new LoginPage(Driver);

            var productsPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");
            productsPage.AddProductToCard();

            var cartPage = productsPage.ClickOnCartIcon();
            var checkoutPage = cartPage.ClickCheckout()
                .SetFirstName("Mike")
                .SetLastName("Smith")
                .SetZip(757557);

            var overviewPage = checkoutPage.PressContinue();
            var completePage = overviewPage.PressFinish();
            completePage.PressBackHomeButton();

            var menu = productsPage.ClickMenuBtn()
                .ClickLogout();
            Waitings.WaitUntil(Driver, loginPage.LogoLogin, 2);
            loginPage.AssertThatLoginFieldsAreDisplayed();
        }
    }
}
