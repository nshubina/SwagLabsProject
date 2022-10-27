using NUnit.Framework;

namespace SwagLabsProject.Pages_PO.ProductDetails
{
    public partial class ProductDetailsPage
    {
        public void ElementsAreAqualAssert(string firstElement, string secondElement)
        {
            Assert.AreEqual(firstElement, secondElement);
        }
    }
}
