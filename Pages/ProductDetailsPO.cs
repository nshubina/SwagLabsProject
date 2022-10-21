using OpenQA.Selenium;
using SwagLabsProject.Initials;

namespace SwagLabsProject.Pages
{
    public class ProductDetailsPO : PageBase
    {
        private By _productTitle = By.XPath("//*[@id='inventory_item_container']/div/div/div[2]/div[1]");
        private By _addToCart = By.Id("add-to-cart-sauce-labs-bike-light");
        private By _cartLink = By.ClassName("shopping_cart_link");
        public ProductDetailsPO(IWebDriver driver) : base(driver)
        {

        }

        public string GetDetailProductName()
        {
            return GetText(_productTitle);
        }

        public void AddToCart()
        {
            Click(_addToCart);
        }

        public int CardIndexChanged()
        {
            return Count(_cartLink);
        }
    }
}
