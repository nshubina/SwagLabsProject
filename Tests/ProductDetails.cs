using NUnit.Framework;
using SwagLabsProject.Login;

namespace SwagLabsProject.Tests
{
    public class ProductDetails : BasePO
    {
        [Test]
        public void When_ClickAddToCartButtonOnProductDetailsPage_ShouldItemAddToCart()
        {
            var loginPage = new LoginPage(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            var productDetailsPage = productPage.ClickOnProduct();
            productDetailsPage.AddToCart();
            productPage.ElementsAreAqualAssert(productPage.GetRemoveButtonText(), "REMOVE");
        }
    }
}
