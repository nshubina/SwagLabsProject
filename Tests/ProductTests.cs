using NUnit.Framework;
using SwagLabsProject.Login;
using SwagLabsProject.Pages;
using System;

namespace SwagLabsProject.Tests
{
    public class ProductTests:BasePO
    {
        [Test]
        public void When_ClickProduct_Expect_ProductDetails()
        {
            var loginPage = new LoginPO(Driver);
            var productPage = loginPage.LoginWithCreds("standard_user", "secret_sauce");

            var productName = productPage.getProductName();

            var productDetailPage = productPage.selectProduct();
            var detailProductName = productDetailPage.GetDetailProductName();
           
            Assert.AreEqual(productName, detailProductName);



        }




    }
}
