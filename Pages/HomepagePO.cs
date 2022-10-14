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

        public HomepagePO(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
