using NUnit.Framework;
using SwagLabsProject.Login;

namespace SwagLabsProject.Tests
{
    public class ProductDetailsTests : BasePO
    {
        [Test]
        public void When_ClickAddToCartButtonOnProductDetailsPage_ShouldItemAddToCart()
        {
            var loginPage = new LoginPO(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            var productDetailsPage = productPage.ClickOnProduct();
            productDetailsPage.AddToCart();

            int cartIndex = productDetailsPage.CardIndexChanged();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(productPage.GetRemoveButtonText(), "REMOVE");
                Assert.Greater(cartIndex, 0);
            });
        }

    }
}
