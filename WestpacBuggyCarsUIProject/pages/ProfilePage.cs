using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WestpacBuggyCarsUIProject.DataModel;
using WestpacBuggyCarsUIProject.pages;

namespace WestpacBuggyCarsUIProject.Pages
{
   public class ProfilePage : GenericPage
    {
        private ProfilePage _profilePage;
        private static readonly By _profilePageFirstName = By.XPath("//input[@id='firstName']");
        private static readonly By _profilePageLastName = By.XPath("//input[@id='lastName']");
        private static readonly By _profilePageUpdateButton = By.XPath("//button[text()='Save']");
        private static readonly By _profilePageSaveButton = By.XPath("//button[@type='submit']");
        private static readonly By _profilePageSuccessMessage = By.CssSelector("div[class*='result alert alert-success']");
        public ProfilePage(ContextObject contextobj) : base(contextobj)
        {
        }

        public void updateProfile(string firstName, string lastName)
        {
            WaitForElement(_profilePageFirstName, 60);
            contextObj.Driver.FindElement(_profilePageFirstName).SendKeys(firstName);
            contextObj.Driver.FindElement(_profilePageLastName).SendKeys(lastName);
            contextObj.Driver.FindElement(_profilePageUpdateButton).Click();
        }

        public void ClearFirstName()
        {
            WaitForElement(_profilePageFirstName, 60);
            contextObj.Driver.FindElement(_profilePageFirstName).Clear();
        }

        public void ClearLastName()
        {
            contextObj.Driver.FindElement(_profilePageLastName).Clear();
        }

        public bool IsDisableSaveButton()
        {
            return contextObj.Driver.FindElement(_profilePageSaveButton).Enabled;
        }

        public string GetSuccessMessage()
        {
            WaitForElement(_profilePageSuccessMessage, 60);
             return contextObj.Driver.FindElement(_profilePageSuccessMessage).Text;
        }
    }
}
