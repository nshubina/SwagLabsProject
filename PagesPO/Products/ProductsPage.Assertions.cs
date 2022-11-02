using NUnit.Framework;

namespace SwagLabsProject.PagesPO.Products
{
    public partial class ProductsPage
    {
        public void ElementsAreAqualAssert(string firstElement, string secondElement)
        {
            Assert.AreEqual(firstElement, secondElement);
        }

        public void AppearRemoveButton()
        {
            Assert.AreEqual(true, _btnRemoveProduct.Displayed);
        }

    }
}
