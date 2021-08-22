using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestpacBuggyCarsUIProject.DataModel;

namespace WestpacBuggyCarsUIProject.pages
{
    public class LandingPage : GenericPage
    {
        private static readonly By _userName= By.Name("login");
        private static readonly By _password = By.Name("password");
        private static readonly By _loginButton = By.XPath("//button[text()='Login']");
        private static readonly By _loginErrortext = By.XPath("//form/div/span"); 
        public LandingPage(ContextObject contextobj) : base(contextobj)
        {
        }
        public void EnterLoginCredentials(string username, string password)
        {
            contextObj.Driver.FindElement(_userName).SendKeys(username);
            contextObj.Driver.FindElement(_password).SendKeys(password);        
        }
        public void ClickLoginButton()
        {
            WaitForElement(_loginButton, 60);
            contextObj.Driver.FindElement(_loginButton).Click();
        }
        public string GetLoginErrorMessage()
        {
            WaitForElement(_loginErrortext, 60);
            return contextObj.Driver.FindElement(_loginErrortext).Text;
            
        }
    }
}
