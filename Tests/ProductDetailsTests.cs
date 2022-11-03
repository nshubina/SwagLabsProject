using NUnit.Framework;
using SwagLabsProject.PagesPO.Login;

namespace SwagLabsProject.Tests
{
    public class ProductDetailsTests : BasePO
    {
        [Test]
        public void When_ClickAddToCartButtonOnProductDetailsPage_ShouldItemAddToCart()
        {
            var loginPage = new LoginPage(Driver);
            var productsPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            var productDetailsPage = productsPage.ClickOnProduct();
            productDetailsPage.AddToCart();

            productDetailsPage.ElementsAreAqualAssert(productsPage.GetRemoveButtonText(), "REMOVE");
        }

    }
}
