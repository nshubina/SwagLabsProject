using NUnit.Framework;
using OpenQA.Selenium;
using SwagLabsProject.Initials;
using SwagLabsProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsProject.Login
{
    public class LoginPO : PageBase
    {
        private By _usernameField = By.Id("user-name");
        private By _passwordField = By.Id("password");
        private By _loginBtn = By.Id("login-button");
        private By _loginErrorMsg = By.XPath("//form/div[3]/h3");

        public LoginPO(IWebDriver driver) : base(driver)
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
     
        public ProductsPO LoginWithCreds(string uName, string password)
        {
            SetUsername(uName);
            SetPassword(password);
            Click(_loginBtn);
            return new ProductsPO(Driver);
        }

        public string GetErrorMessage()
        {
            return Driver.FindElement(_loginErrorMsg).Text;
        }
    }

}

