using OpenQA.Selenium;
using SwagLabsProject.Initials;

namespace SwagLabsProject.Pages
{
    public class ProductPO : PageBase
    {
        private By _categoryTitle = By.CssSelector(".header_secondary_container .title");
        private By _productName = By.Id("item_0_title_link");
        private By _addToCartBtn = By.Id("add-to-cart-sauce-labs-bike-light");
        private By _removeProductBtn = By.Id("remove-sauce-labs-bike-light");
        private By _cardIconBtn = By.ClassName("shopping_cart_link");
        public ProductPO(IWebDriver driver) : base(driver)
        {
        }

        public string GetCategoryTitle()
        {
            return GetText(_categoryTitle);
        }

        public string GetProductName()
        {
            string itemName = GetText(_productName);
            return itemName;
        }

        public ProductDetailsPO ClickOnProduct()
        {
            Click(_productName);
            return new ProductDetailsPO(Driver);
        }

        public void AddProductToCard()
        {
            Click(_addToCartBtn);
        }

        public void RemoveProduct()
        {
            Click(_removeProductBtn);
        }

        public string GetAddToCartButtonText()
        {
            return GetText(_addToCartBtn);
        }

        public string GetRemoveButtonText()
        {
            return GetText(_removeProductBtn);
        }

        public int CardIndexChanged()
        {
            return Count(_cardIconBtn);
        }
    }
}
