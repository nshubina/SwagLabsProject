using NUnit.Framework;

namespace SwagLabsProject.PagesPO.Checkout.CheckoutInfo
{
    public partial class CheckoutInfoPage
    {
        public CheckoutInfoPage AssertUserIsNavigatedToCheckoutPage()
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
