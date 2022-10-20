using OpenQA.Selenium;
using SwagLabsProject.Initials;

namespace SwagLabsProject.Pages
{
    public class ProductPO : PageBase
    {
        private By _categoryTitle = By.CssSelector(".header_secondary_container .title");
        private By _productName = By.Id("item_4_title_link");
        private By _addToCardBtn = By.Id("add-to-cart-sauce-labs-bike-light");

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

        public ProductDetailPO ClickOnProduct()
        {
            Click(_productName);
            return new ProductDetailPO(Driver);
        }

        public void AddToCard()
        {
            Click(_addToCardBtn);
        }


    }
}
