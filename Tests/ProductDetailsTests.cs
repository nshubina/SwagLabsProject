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
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            var productDetailsPage = productPage.ClickOnProduct();
            productDetailsPage.AddToCart();

            productDetailsPage.ElementsAreAqualAssert(productPage.GetRemoveButtonText(), "REMOVE");
        }

    }
}
