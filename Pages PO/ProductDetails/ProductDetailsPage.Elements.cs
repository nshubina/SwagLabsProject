using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.Pages_PO.ProductDetails
{
    public partial class ProductDetailsPage
    {
        /* [FindsBy(How.CssSelector, Using = ".header_secondary_container .title")]
         private IWebDriver _titleCategory;*/

        [FindsBy(How = How.Id, Using = "item_0_title_link")]
        private IWebElement _productName;

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-bike-light")]
        private IWebElement _btnAddToCart;

        [FindsBy(How = How.Id, Using = "remove-sauce-labs-bike-light")]
        private IWebElement _btnRemoveProduct;

        [FindsBy(How = How.Id, Using = "shopping_cart_link")]
        private IWebElement _btnCartIconBtn;
    }
}
