using BoDi;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using WestpacBuggyCarsUIProject.DataModel;
using WestpacBuggyCarsUIProject.Pages;

namespace WestpacBuggyCarsUIProject.StepDefinitions
{
    [Binding]
    public class ProfileSteps : BaseSteps
    {
        private ProfilePage _profilePage;

        public ProfileSteps(ContextObject context, IObjectContainer container) : base(context, container.Resolve<ScenarioContext>())
        {
            ContextObj = context;
            _profilePage = new ProfilePage(ContextObj);
        }

        [When(@"User updates '(.*)' And '(.*)'")]
        public void WhenUserUpdatesAnd(string firstName, string lastName)
        {
            
            _profilePage.ClearFirstName();
            _profilePage.ClearLastName();
            _profilePage.updateProfile(firstName, lastName);
        }
        [Then(@"User can see '(.*)' message")]
        public void ThenUserCanSeeMessage(string expectedProfileSuccess)
        {
            Assert.AreEqual(expectedProfileSuccess,_profilePage.GetSuccessMessage(), "Unable to update profile");
            
        }

        [When(@"User clears the FirstName And LastName")]
        public void WhenUserClearsTheFirstNameAndLastName()
        {
            _profilePage.ClearFirstName();
            _profilePage.ClearLastName();
        }

        [Then(@"User should not be able to Update Profile")]
        public void ThenUserShouldNotBeAbleToUpdateProfile()
        {
            Assert.IsTrue(_profilePage.IsDisableSaveButton(), "Save button should be disable");
        }


    }
}
