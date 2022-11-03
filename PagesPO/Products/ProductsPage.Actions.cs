using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SwagLabsProject.PagesPO.Cart;
using SwagLabsProject.PagesPO.ProductDetails;

namespace SwagLabsProject.PagesPO.Products
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

        public ProductsPage AddProductToCard()
        {
            _btnAddToCart.Click();
            return this;
        }

        public ProductsPage RemoveProduct()
        {
            _btnRemoveProduct.Click();
            return this;
        }

        public string GetAddToCartButtonText()
        {
            return _btnAddToCart.Text;
        }

        public string GetRemoveButtonText()
        {
            return _btnRemoveProduct.Text;
        }

        public CartPage ClickOnCartIcon()
        {
            _btnCartIcon.Click();
            return new CartPage(_driver);
        }
    }
}
