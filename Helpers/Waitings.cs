using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace SwagLabsProject.Helpers
{
    public class Waitings
    {
        public static void WaitUntil(IWebDriver driver, IWebElement element, int second)
        {
            var waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
            try
            {
                waiter.Until(d =>
                {
                    if (element != null && element.Displayed)
                    {
                        return element;
                    }
                    else
                    {
                        return null;
                    }
                });
            }
            catch (Exception ex) { }
        }
    }
}
