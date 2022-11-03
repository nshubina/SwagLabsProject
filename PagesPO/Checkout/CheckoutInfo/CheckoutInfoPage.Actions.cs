using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SwagLabsProject.PagesPO.Checkout.CheckoutOverview;

namespace SwagLabsProject.PagesPO.Checkout.CheckoutInfo
{
    public partial class CheckoutInfoPage
    {
        private IWebDriver _driver;

        public CheckoutInfoPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public CheckoutInfoPage SetFirstName(string firstName)
        {
            _inputFirstName.SendKeys(firstName);
            return this;
        }
        public CheckoutInfoPage SetLastName(string lastName)
        {
            _inputLastName.SendKeys(lastName);
            return this;
        }

        public CheckoutInfoPage SetZip(int zip)
        {
            string zip1 = zip.ToString();
            _inputZip.SendKeys(zip1);
            return this;
        }

        public CheckoutOverviewPage PressContinue()
        {
            _btnContinue.Click();
            return new CheckoutOverviewPage(_driver);
        }

    }
}
