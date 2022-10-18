using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsProject.Pages
{
    public class HomepagePO
    {
        protected IWebDriver Driver;

        private By _productTitle = By.CssSelector(".header_secondary_container .title");


        public HomepagePO(IWebDriver driver)
        {
            Driver = driver;
        }

        public string getTitle()
        {
            return Driver.FindElement(_productTitle).Text;           
        }
    }
}
