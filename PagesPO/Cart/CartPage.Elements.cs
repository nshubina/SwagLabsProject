using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SwagLabsProject.PagesPO.Cart
{
    public partial class CartPage
    {
        [FindsBy(How = How.ClassName, Using = "header_secondary_container")]
        private IWebElement _headerTitle;

        [FindsBy(How = How.Id, Using = "item_4_title_link")]
        private IWebElement _addedNameProduct;

    }
}
