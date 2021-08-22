using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestpacBuggyCarsUIProject.DataModel;

namespace WestpacBuggyCarsUIProject.pages
{
    public class HomePage : GenericPage
    {
        private static readonly By _logout = By.XPath("//a[text()='Logout']");
        private static readonly By _profileLink = By.XPath("//a[text()='Profile']");
        public HomePage(ContextObject contextobj) : base(contextobj)
        {
        }
          public void ClickOnProfile()
        {
            WebDriverWait wait = new WebDriverWait(contextObj.Driver,System.TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(_profileLink));
            WaitForElement(_profileLink, 60);
            ClickElement(_profileLink);
        }

        public bool IsDisplayHomePage()
        {
            WaitForElement(_logout, 60);
            return contextObj.Driver.FindElement(_logout).Displayed;
        }
    }  
}
