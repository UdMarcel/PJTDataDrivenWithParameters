using OpenQA.Selenium;
using PJTDataDrivenWithParameters.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJTDataDrivenWithParameters.PageObject
{
    class DataDrivenPageObject
    {
       

        public DataDrivenPageObject()
        {
            datadrive = Hooks1.testdrive;

        }

        IWebDriver datadrive;

        IWebElement SignUp => datadrive.FindElement(By.XPath("//a[@class='nav-link active']"));
        IWebElement Username => datadrive.FindElement(By.XPath("//input[@placeholder='Username']"));
        
        IWebElement Email => datadrive.FindElement(By.XPath("//input[@type='email']"));

        IWebElement Password => datadrive.FindElement(By.XPath("//input[@type='password']"));

        IWebElement Login => datadrive.FindElement(By.CssSelector("button[type='submit']"));

        IWebElement NewArticle => datadrive.FindElement(By.CssSelector("a[class='nav-link active']"));



        public void NavigateToWebsite(string url)
        {
            datadrive.Navigate().GoToUrl(url);

        }
        public void ClickOnSignUP()
        {
            SignUp.Click();

        }

        public void EnterUsername(string username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys(username + randomInt);
        }

        public void EnterEmail(string email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys( randomInt + email);
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }
        public void Enterlogin()
        {
            Login.Click();
        }
        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }















    }
}
