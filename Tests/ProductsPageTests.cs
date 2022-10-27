using NUnit.Framework;
using SwagLabsProject.Login;

namespace SwagLabsProject.Tests
{
    public class ProdTest : BasePO
    {
        [Test]
        public void WhenClickProductNameExpectProductDetails()
        {
            var loginPage = new LoginPage(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            var productName = productPage.GetProductName();

            var productDetailPage = productPage.ClickOnProduct();
            var detailProductName = productDetailPage.GetDetailProductName();

            productPage.ElementsAreAqualAssert(productName, detailProductName);
        }

        [Test]
        public void WhenClickAddToCartBtnOnProductExpectProductAddsToCard()
        {
            var loginPage = new LoginPage(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            productPage.AddProductToCard();
            productPage.ElementsAreAqualAssert(productPage.GetRemoveButtonText(), "REMOVE");
        }

        [Test]
        public void WhenClickRemoveButtonOnProductExpectProductIsRemovedFromCart()
        {
            var loginPage = new LoginPage(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            productPage.AddProductToCard();
            productPage.RemoveProduct();

            productPage.ElementsAreAqualAssert(productPage.GetAddToCartButtonText(), "ADD TO CART");
        }
    }
}

