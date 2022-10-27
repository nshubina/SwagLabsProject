using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SwagLabsProject.Pages;

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

        public ProductDetailsPO ClickOnProduct()
        {
            _nameProduct.Click();
            return new ProductDetailsPO(_driver);
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

        /*
        public int CartIndexChanged()
        {
            var pageBase = new PageBase(_driver);

            return pageBase.Count(_btnCartIcon);
        }*/

    }
}
