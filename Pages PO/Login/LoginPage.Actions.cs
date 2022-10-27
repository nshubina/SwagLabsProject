using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SwagLabsProject.Pages_PO.Products;

namespace SwagLabsProject.Login
{
    public partial class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
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

        public ProductsPage LoginWithCreds(string uName, string password)
        {
            SetUsername(uName);
            SetPassword(password);
            _btnLogin.Click();
            return new ProductsPage(_driver);
        }

        public string GetErrorMessage()
        {
            return _errorLogin.Text;
        }
    }
}
