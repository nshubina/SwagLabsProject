using NUnit.Framework;

namespace SwagLabsProject.PagesPO.Products
{
    public partial class ProductsPage
    {
        public ProductsPage ElementsAreAqualAssert(string firstElement, string secondElement)
        {
            Assert.AreEqual(firstElement, secondElement);
            return this;
        }
        /*
                public void AppearRemoveButton()
                {
                    Assert.AreEqual(true, _btnRemoveProduct.Displayed);
                }
        */

    }
}
