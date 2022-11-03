using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SwagLabsProject.PagesPO.Checkout.CheckoutInfo;

namespace SwagLabsProject.PagesPO.Cart
{
    public partial class CartPage
    {
        private IWebDriver _driver;

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public CheckoutInfoPage ClickCheckout()
        {
            _btnCheckout.Click();
            return new CheckoutInfoPage(_driver);
        }
    }
}