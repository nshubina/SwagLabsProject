using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SwagLabsProject.Pages_PO.ProductDetails;

namespace SwagLabsProject.Pages_PO.Products
{
    public partial class ProductsPage
    {
        private IWebDriver _driver;

        public ProductsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string GetCategoryTitle()
        {
            return _titleCategory.Text;
        }

        public string GetProductName()
        {
            string itemName = _nameProduct.Text;
            return itemName;
        }

        public ProductDetailsPage ClickOnProduct()
        {
            _nameProduct.Click();
            return new ProductDetailsPage(_driver);
        }

        public void AddProductToCard()
        {
            _btnAddToCart.Click();
        }

        public void RemoveProduct()
        {
            _btnRemoveProduct.Click();
        }

        public string GetAddToCartButtonText()
        {
            return _btnAddToCart.Text;
        }

        public string GetRemoveButtonText()
        {
            return _btnRemoveProduct.Text;
        }
    }
}
