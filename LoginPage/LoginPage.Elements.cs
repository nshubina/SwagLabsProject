using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.LoginPage
{
    public partial class LoginPage
    {

        [FindsBy(How = How.Id, Using = "user-name")]
        private IWebElement _fldUsername;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement _fldPassword;

        [FindsBy(How = How.Id, Using = "login-button")]
        private IWebElement _btnLogin;

        [FindsBy(How = How.XPath, Using = "//form/div[3]/h3")]
        private IWebElement errorLogin;
    }
}
