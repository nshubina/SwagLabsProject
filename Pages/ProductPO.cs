using OpenQA.Selenium;
using SwagLabsProject.Initials;
using SwagLabsProject.Login;
using SwagLabsProject.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsProject.Pages
{
    public class ProductPO : PageBase
    {
        protected IWebDriver Driver;

        private By _productTitle = By.CssSelector(".header_secondary_container .title");
        private By _itemName = By.Id("item_4_title_link");

        public ProductPO(IWebDriver driver) : base(driver)
        {
        }

        public string getTitle()
        {
            return GetText(_productTitle);
        }

        public string getItemName()
        {
            return GetText(_itemName);
        }
/*
        public ProductDetailPO selectProduct()
        {
            Click(_itemName);
            Driver.FindElement(product)
            return new ProductDetailPO(Driver);
        }
   */
    }
}
