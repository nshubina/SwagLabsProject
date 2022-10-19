using OpenQA.Selenium;
using SwagLabsProject.Initials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsProject.Pages
{
    public class ProductDetailPO : PageBase
    {
        private By _productTitle = By.XPath("//*[@id='inventory_item_container']/div/div/div[2]/div[1]");

        public ProductDetailPO(IWebDriver driver) : base(driver)
        {

        }

        public string GetDetailProductName()
        {
            return GetText(_productTitle);
        }

    }
}
