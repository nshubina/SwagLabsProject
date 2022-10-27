using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.Initials
{
    public class PageBase
    {
        protected IWebDriver Driver;
        public PageBase(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement Element(By by)
        {
            return Driver.FindElement(by);
        }

        public void Click(By by)
        {
            Element(by).Click();
        }

        public void Clear(By by)
        {
            Element(by).Clear();
        }

        public void SendKeys(By by, string txt)
        {
            Element(by).SendKeys(txt);
        }

        public string GetText(By by)
        {
            return Element(by).Text;
        }

        public int Count(By by)
        {
            return Driver.FindElements(by).Count;
        }
    }
}
