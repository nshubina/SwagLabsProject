using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SwagLabsProject.PagesPO.Products;

namespace SwagLabsProject.PagesPO.Checkout.CheckoutComplete
{
    public partial class CheckoutCompletePage
    {
        private IWebDriver _driver;

        public CheckoutCompletePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public ProductsPage PressBackHomeButton()
        {
            _btnBackHome.Click();
            return new ProductsPage(_driver);
        }
    }
}
