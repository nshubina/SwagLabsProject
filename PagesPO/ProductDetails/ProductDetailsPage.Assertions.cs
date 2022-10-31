using NUnit.Framework;

namespace SwagLabsProject.PagesPO.ProductDetails
{
    public partial class ProductDetailsPage
    {
        public void ElementsAreAqualAssert(string firstElement, string secondElement)
        {
            Assert.AreEqual(firstElement, secondElement);
        }
    }
}
