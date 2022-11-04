using NUnit.Framework;

namespace SwagLabsProject.PagesPO.Login
{
    public partial class LoginPage
    {
        public void AssertElementsAreEqual(string firstElement, string secondElement)
        {
            Assert.AreEqual(firstElement, secondElement);
        }

        public void AssertThatLoginFieldsAreDisplayed()
        {
            Assert.Multiple(() =>
            {
                Assert.That(LogoLogin.Displayed, Is.True, "The Logo is not displayed");
                Assert.That(_fldUsername.Displayed, Is.True, "The Username field is not displayed");
                Assert.That(_fldPassword.Displayed, Is.True, "The Password field is not displayed");
            });
        }
    }
}
