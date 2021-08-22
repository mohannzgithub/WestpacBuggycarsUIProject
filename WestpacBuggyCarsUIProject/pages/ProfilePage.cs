using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestpacBuggyCarsUIProject.DataModel;
using WestpacBuggyCarsUIProject.pages;

namespace WestpacBuggyCarsUIProject.Pages
{
   public class ProfilePage : GenericPage
    {
        private ProfilePage _profilePage;
        private static readonly By _profilePageFirstName = By.XPath("//input[@id='firstName']");
        private static readonly By _profilePagelastName = By.XPath("//input[@id='lastName']");
        private static readonly By _profilePageUpdateButton = By.XPath("//button[text()='Save']");
        public ProfilePage(ContextObject contextobj) : base(contextobj)
        {
        }

        public void updateProfile(string firstName, string lastName)
        {
            waitForElement(_profilePageFirstName, 60);
            contextObj.Driver.FindElement(_profilePageFirstName).SendKeys(firstName);
            contextObj.Driver.FindElement(_profilePageFirstName).SendKeys(lastName);
            contextObj.Driver.FindElement(_profilePageUpdateButton).Click();
        }

        public void ValidateProfileMessage(string expectedProfileSuccess)
        {
           //var actualProfileSuccess= contextObj.Driver.FindElement()
           //Assert.
        }
    }
}
