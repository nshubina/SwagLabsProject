using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.Pages_PO.Products
{
    public partial class ProductsPage
    {
        [FindsBy(How = How.CssSelector, Using = ".header_secondary_container .title")]
        private IWebElement _titleCategory;

        [FindsBy(How = How.Id, Using = "item_0_title_link")]
        private IWebElement _nameProduct;

        [FindsBy(How = How.Id, Using = "remove-sauce-labs-bike-light")]
        private IWebElement _btnRemoveProduct;

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-bike-light")]
        private IWebElement _btnAddToCart;

        [FindsBy(How = How.ClassName, Using = "shopping_cart_link")]
        private IWebElement _btnCartIcon;
    }
}