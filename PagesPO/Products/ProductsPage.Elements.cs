using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.PagesPO.Products
{
    public partial class ProductsPage
    {
        [FindsBy(How = How.CssSelector, Using = ".header_secondary_container .title")]
        private IWebElement _titleCategory;

        [FindsBy(How = How.Id, Using = "item_4_title_link")]
        public IWebElement _nameProduct;

        [FindsBy(How = How.Id, Using = "remove-sauce-labs-backpack")]
        private IWebElement _btnRemoveProduct;

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-backpack")]
        private IWebElement _btnAddToCart;

        [FindsBy(How = How.ClassName, Using = "shopping_cart_link")]
        public IWebElement _btnCartIcon;
    }
}