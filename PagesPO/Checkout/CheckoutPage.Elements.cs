using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.PagesPO.Checkout
{
    public partial class CheckoutPage
    {
        [FindsBy(How = How.ClassName, Using = "header_secondary_container")]
        private IWebElement _headerYourInfo;


        [FindsBy(How = How.Id, Using = "first-name")]
        private IWebElement _inputFirstName;
    }
}
