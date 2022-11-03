using NUnit.Framework;
using SwagLabsProject.PagesPO.Login;

namespace SwagLabsProject.Tests
{
    public class CartPageTests : BasePO
    {
        [Test]
        [Description("User is navigated to checkout page when click 'Checkout' btn")]
        public void WhenClickCheckoutButtonExpectNavigateToCheckoutPage()
        {
            var loginPage = new LoginPage(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce")
                .AddProductToCard();
            var cartPage = productPage.ClickOnCartIcon();
            var checkoutPage = cartPage.ClickCheckout()
                .AssertUserIsNavigatedToCheckoutPage();



        }
    }
}
