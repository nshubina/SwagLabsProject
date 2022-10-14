using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SwagLabsProject
{
    public class BasePO
    {
        protected IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Close()
        {
            Driver.Quit();
        }


    }
}