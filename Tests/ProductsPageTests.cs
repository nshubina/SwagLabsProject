using NUnit.Framework;
using SwagLabsProject.PagesPO.Login;

namespace SwagLabsProject.Tests
{
    [TestFixture]
    public class ProductsPageTests : BasePO
    {
        [Test]
        [Description("User is navigated to the Product Details page, when click on product name")]
        public void WhenClickProductNameExpectProductDetails()
        {
            var loginPage = new LoginPage(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            var productName = productPage.GetProductName();

            var productDetailPage = productPage.ClickOnProduct();
            var openedProductName = productDetailPage.GetDetailProductName();

            productPage.ElementsAreAqualAssert(productName, openedProductName);
        }

        [Test]
        [Description("Product adds to cart after click on the 'Add to cart' btn")]
        public void WhenClickAddToCartBtnOnProductExpectProductAddsToCard()
        {
            var loginPage = new LoginPage(Driver);
            var productsPage = loginPage.LoginWithCreds("standard_user", "secret_sauce")
                .AddProductToCard();

            productsPage.ElementsAreAqualAssert(productsPage.GetRemoveButtonText(), "REMOVE");
        }

        [Test]
        [Description("The added product is removed from the cart after clicking the 'remove from cart' button")]
        public void WhenClickRemoveButtonOnProductExpectProductIsRemovedFromCart()
        {
            var loginPage = new LoginPage(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce")
                .AddProductToCard()
                .RemoveProduct();

            productPage.ElementsAreAqualAssert(productPage.GetAddToCartButtonText(), "ADD TO CART");
        }

        [Test]
        [Description("The cart page is opened after click on cart icon")]
        public void WhenAddItemAndClickOnCartIconShouldOpenCartPage()
        {
            var loginPage = new LoginPage(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce")
                .AddProductToCard();

            productPage.ClickOnCartIcon()
                .AssertAddedProductIsEqualToProductInTheCart(productPage._nameProduct.Text);
        }
    }
}


