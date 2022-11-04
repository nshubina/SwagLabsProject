using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SwagLabsProject.PagesPO.Login;

namespace SwagLabsProject.PagesPO.BurgerMenu
{
    public partial class Menu
    {
        private IWebDriver _driver;
        public Menu(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public LoginPage ClickLogout()
        {
            _btnLogout.Click();
            return new LoginPage(_driver);
        }
    }
}
