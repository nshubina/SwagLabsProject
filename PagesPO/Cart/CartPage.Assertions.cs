using NUnit.Framework;

namespace SwagLabsProject.PagesPO.Cart
{
    public partial class CartPage
    {
        public CartPage AssertAddedProductIsEqualToProductInTheCart(string addedProductName)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(_headerTitle.Text, "YOUR CART");
                Assert.AreEqual(addedProductName, _addedNameProduct.Text);
            });
            return this;
        }
    }
}
