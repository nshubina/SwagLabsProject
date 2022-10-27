using NUnit.Framework;

namespace SwagLabsProject.Login
{
    public partial class LoginPage
    {
        public void AssertHeadersAreEqual(string titleActual, string titleExpected)
        {
            Assert.AreEqual(titleActual, titleExpected);
        }

        public void AssertElementsAreEqual(string firstElement, string SecondElement)
        {
            Assert.AreEqual(firstElement, SecondElement);
        }
    }
}
