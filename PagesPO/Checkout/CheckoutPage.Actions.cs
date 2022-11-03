using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.PagesPO.Checkout
{
    public partial class CheckoutPage
    {
        private IWebDriver _driver;

        public CheckoutPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

    }
}
