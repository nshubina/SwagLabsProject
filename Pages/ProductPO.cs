﻿using OpenQA.Selenium;
using SwagLabsProject.Initials;

namespace SwagLabsProject.Pages
{
    public class ProductPO : PageBase
    {
        private By _categoryTitle = By.CssSelector(".header_secondary_container .title");
        private By _productName = By.Id("item_4_title_link");
        private By _addToCardBtn = By.Id("add-to-cart-sauce-labs-bike-light");
        private By _removeProductBtn = By.Id("remove-sauce-labs-bike-light");
        private By _cardIconBtn = By.ClassName("shopping_cart_link");
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

        public ProductDetailPO ClickOnProduct()
        {
            Click(_productName);
            return new ProductDetailPO(Driver);
        }

        public void AddProductToCard()
        {
            Click(_addToCardBtn);
        }

        public void RemoveProduct()
        {
            Click(_removeProductBtn);
        }

        public string getButtonText()
        {
            return GetText(_removeProductBtn);
        }

        public int CardIndexChanged()
        {
            return Count(_cardIconBtn);
        }
    }
}
