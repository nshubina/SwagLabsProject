using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SwagLabsProject.PagesPO.Checkout;

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

        public CheckoutPage ClickCheckout()
        {
            _btnCheckout.Click();
            return new CheckoutPage(_driver);
        }

    }
}
