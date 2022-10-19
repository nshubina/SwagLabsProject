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
        private By _categoryTitle = By.CssSelector(".header_secondary_container .title");
        private By _productName = By.Id("item_4_title_link");

        public ProductPO(IWebDriver driver) : base(driver)
        {
        }

        public string GetCategoryTitle()
        {
            return GetText(_categoryTitle);
        }

        public string GetProductName()
        {
            string itemName = GetText(_productName);
            return itemName;
        }

        public ProductDetailPO SelectProduct()
        {
            Click(_productName);
            return new ProductDetailPO(Driver);
        }

    }
}
