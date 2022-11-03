using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SwagLabsProject.PagesPO.Checkout.CheckoutComplete;

namespace SwagLabsProject.PagesPO.Checkout.CheckoutOverview
{
    public partial class CheckoutOverviewPage
    {
        private IWebDriver _driver;

        public CheckoutOverviewPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        //return page
        public CheckoutCompletePage PressFinish()
        {
            _btnFinish.Click();
            return new CheckoutCompletePage(_driver);
        }

    }
}
