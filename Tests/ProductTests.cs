using NUnit.Framework;
using SwagLabsProject.Login;

namespace SwagLabsProject.Tests
{
    public class ProductTests : BasePO
    {
        [Test]
        public void When_ClickProductName_Expect_ProductDetails()
        {
            var loginPage = new LoginPO(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            var productName = productPage.GetProductName();

            var productDetailPage = productPage.ClickOnProduct();
            var detailProductName = productDetailPage.GetDetailProductName();

            Assert.AreEqual(productName, detailProductName);
        }

        [Test]
        public void When_ClickAddToCartBtnOnProduct_Expect_ProductAddsToCard()
        {
            var loginPage = new LoginPO(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            productPage.AddProductToCard();

            int c = productPage.CardIndexChanged();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(productPage.getButtonText(), "REMOVE");
                Assert.Greater(c, 0);
            });
        }

        [Test]
        public void When_ClickRemoveButtonOnProduct_Expect_ProductIsRemovedFromCart()
        {
            var loginPage = new LoginPO(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            productPage.AddProductToCard();
            productPage.RemoveProduct();


            int c = productPage.CardIndexChanged();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(productPage.getButtonText(), "ADD TO CARD");
                Assert.Greater(c, 0);
            });

        }
    }
}
