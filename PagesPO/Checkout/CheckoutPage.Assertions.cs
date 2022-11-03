using NUnit.Framework;

namespace SwagLabsProject.PagesPO.Checkout
{
    public partial class CheckoutPage
    {
        public CheckoutPage AssertUserIsNavigatedToCheckoutPage()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(_headerYourInfo.Text, "CHECKOUT: YOUR INFORMATION");
                Assert.That(_inputFirstName.Displayed);
            });
            return this;
        }
    }
}
