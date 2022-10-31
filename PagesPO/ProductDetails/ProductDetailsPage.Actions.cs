using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.PagesPO.ProductDetails
{
    public partial class ProductDetailsPage
    {
        private IWebDriver _driver;

        public ProductDetailsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string GetDetailProductName()
        {
            return _productTitle.Text;
        }

        public void AddToCart()
        {
            _addToCart.Click();
        }
    }
}
