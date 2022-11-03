using NUnit.Framework;

namespace SwagLabsProject.PagesPO.Login
{
    public partial class LoginPage
    {
        public void AssertElementsAreEqual(string firstElement, string secondElement)
        {
            Assert.AreEqual(firstElement, secondElement);
        }
    }
}
