using NUnit.Framework;
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
            //loginPage.AssertElementsAreEqual(productsPage.GetCategoryTitle(), "PRODUCTS");

            productsPage.AddProductToCard();
            //  productPage.ElementsAreAqualAssert(productPage.GetRemoveButtonText(), "REMOVE");

            var cartPage = productsPage.ClickOnCartIcon();
            var checkoutPage = cartPage.ClickCheckout()
                //.AssertUserIsNavigatedToCheckoutPage();

                .SetFirstName("Mike")
                .SetLastName("Smith")
                .SetZip(757557);
            var overviewPage = checkoutPage.PressContinue();
            var completePage = overviewPage.PressFinish();
            completePage.PressBackHomeButton();








        }
    }
}
