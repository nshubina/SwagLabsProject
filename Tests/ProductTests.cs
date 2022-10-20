using NUnit.Framework;
using SwagLabsProject.Login;

namespace SwagLabsProject.Tests
{
    public class ProductTests : BasePO
    {
        [Test]
        public void When_ClickProduct_Expect_ProductDetails()
        {
            var loginPage = new LoginPO(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            var productName = productPage.GetProductName();

            var productDetailPage = productPage.ClickOnProduct();
            var detailProductName = productDetailPage.GetDetailProductName();

            Assert.AreEqual(productName, detailProductName);
        }

        [Test]
        public void When_ClickAddButton_Expect_ProductAddsToCard()
        {
            var loginPage = new LoginPO(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            productPage.AddToCard();

        }
    }
}
