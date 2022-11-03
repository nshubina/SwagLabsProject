using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SwagLabsProject.PagesPO.Products;

namespace SwagLabsProject.PagesPO.Login
{
    public partial class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public LoginPage SetUsername(string uName)
        {
            _fldUsername.Click();
            _fldUsername.Clear();
            _fldUsername.SendKeys(uName);
            return this;
        }

        public LoginPage SetPassword(string password)
        {
            _fldPassword.Click();
            _fldPassword.Clear();
            _fldPassword.SendKeys(password);
            return this;
        }

        public LoginPage PressLoginButton()
        {
            _btnLogin.Click();
            return this;
        }

        public ProductsPage LoginWithCreds(string uName, string password)
        {
            SetUsername(uName);
            SetPassword(password);
            PressLoginButton();
            return new ProductsPage(_driver);
        }

        public string GetErrorMessage()
        {
            return _errorLogin.Text;
        }
    }
}
