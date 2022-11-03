using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.PagesPO.Checkout.CheckoutInfo
{
    public partial class CheckoutInfoPage
    {
        [FindsBy(How = How.ClassName, Using = "header_secondary_container")]
        private IWebElement _headerYourInfo;

        [FindsBy(How = How.Id, Using = "first-name")]
        private IWebElement _inputFirstName;

        [FindsBy(How = How.Id, Using = "last-name")]
        private IWebElement _inputLastName;

        [FindsBy(How = How.Id, Using = "postal-code")]
        private IWebElement _inputZip;

        [FindsBy(How = How.Id, Using = "continue")]
        private IWebElement _btnContinue;
    }
}
