using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SwagLabsProject.Pages;

namespace SwagLabsProject.Login
{
    public partial class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void SetUsername(string uName)
        {

            _fldUsername.Click();
            _fldUsername.Clear();
            _fldUsername.SendKeys(uName); ;
        }

        public void SetPassword(string password)
        {
            _fldPassword.Click();
            _fldPassword.Clear();
            _fldPassword.SendKeys(password);
        }

        public ProductPO LoginWithCreds(string uName, string password)
        {
            SetUsername(uName);
            SetPassword(password);
            _btnLogin.Click();
            return new ProductPO(driver);
        }

        public string GetErrorMessage()
        {
            return _errorLogin.Text;
        }
    }
}
