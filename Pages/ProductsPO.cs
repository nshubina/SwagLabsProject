using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsProject.Pages
{
    public class ProductsPO
    {
        protected IWebDriver Driver;

        private By _productTitle = By.CssSelector(".header_secondary_container .title");


        public ProductsPO(IWebDriver driver)
        {
            Driver = driver;
        }

        public string getTitle()
        {
            return Driver.FindElement(_productTitle).Text;           
        }
    }
}
