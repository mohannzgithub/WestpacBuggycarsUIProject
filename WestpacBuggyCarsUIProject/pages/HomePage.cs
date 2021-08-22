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
    public class HomePage : GenericPage
    {
        private static readonly By _logout = By.XPath("//a[text()='Logout']");
        private static readonly By _profileLink = By.XPath("//a[text()='Profile']");
        public HomePage(ContextObject contextobj) : base(contextobj)
        {
        }
        public void ValidateHomePage()
        {
            waitForElement(_logout, 60);
            Assert.IsTrue(contextObj.Driver.FindElement(_logout).Displayed,"Login unsuccessful");
        }

        public void clickOnProfile()
        {
            waitForElement(_profileLink, 60);
            clickElement(_profileLink);
        }
    }  
}
