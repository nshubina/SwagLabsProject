using NUnit.Framework;
using SwagLabsProject.Pages;

namespace SwagLabsProject.Login
{
    public partial class LoginPage
    {
        public void AssertHeader()
        {
            ProductPO productsPage = new ProductPO(_driver);
            Assert.AreEqual(productsPage.GetCategoryTitle(), "PRODUCTS");
        }
    }
}
