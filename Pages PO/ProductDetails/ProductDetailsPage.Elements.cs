using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.Pages_PO.ProductDetails
{
    public partial class ProductDetailsPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='inventory_item_container']/div/div/div[2]/div[1]")]
        private IWebElement _productTitle;

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-bike-light")]
        private IWebElement _addToCart;

        [FindsBy(How = How.ClassName, Using = "shopping_cart_link")]
        private IWebElement _cartLink;
    }
}
