using NUnit.Framework;
using OpenQA.Selenium;
using SwagLabsProject.Initials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsProject.Login
{
    public class LoginPO: PageBase
    {
        private By _usernameField = By.Id("user-name");
        private By _passwordField = By.Id("password");
        private By _loginBtn = By.Id("login-button");
        

        public LoginPO (IWebDriver _driver) : base(_driver)
        {
            
        }

        public void SetUsername(string uName)
        {
            Click(_usernameField);
            Clear(_usernameField);
            SendKeys(_usernameField, uName);
        }

        public void SetPassword(string password)
        {
            Click(_passwordField);
            Clear(_passwordField);

            SendKeys(_passwordField, password);
        }

        public void LogInWithCreds(string uName, string password)
        {
            SetUsername(uName);
            SetPassword(password);
            Click(_loginBtn);
        }

        public void CheckThatUserIsLoggedIn(string url)
        {
            string currentUrl = Driver.Url;
            Assert.AreEqual(url, currentUrl);
            
        }

    }
}
