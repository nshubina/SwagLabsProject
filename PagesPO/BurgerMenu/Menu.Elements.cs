using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.PagesPO.BurgerMenu
{
    public partial class Menu
    {
        [FindsBy(How = How.Id, Using = "logout_sidebar_link")]
        private IWebElement _btnLogout;
    }
}
