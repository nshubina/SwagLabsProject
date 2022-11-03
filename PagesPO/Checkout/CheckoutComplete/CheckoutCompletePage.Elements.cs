using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.PagesPO.Checkout.CheckoutComplete
{
    public partial class CheckoutCompletePage
    {
        [FindsBy(How = How.Id, Using = "back-to-products")]
        private IWebElement _btnBackHome;
    }
}
