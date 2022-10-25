using NUnit.Framework;
using SwagLabsProject.Login;
namespace SwagLabsProject.Tests
{
    public class LogTest : BasePO
    {
        [Test]

        public void ValidLogin()
        {
            LoginPage login = new LoginPage(Driver);
            var productsPage = login.LoginWithCreds("standard_user", "secret_sauce");

            login.AssertHeader();

        }



    }
}

