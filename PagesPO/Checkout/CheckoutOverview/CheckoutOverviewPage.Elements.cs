using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.PagesPO.Checkout.CheckoutOverview
{
    public partial class CheckoutOverviewPage
    {
        [FindsBy(How = How.Id, Using = "finish")]
        private IWebElement _btnFinish;
    }
}
