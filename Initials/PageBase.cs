using OpenQA.Selenium;


namespace SwagLabsProject.Initials
{
    public class PageBase
    {
        protected IWebDriver Driver;
        public PageBase(IWebDriver driver)
        {
            Driver = driver;   
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

       

    }
}
