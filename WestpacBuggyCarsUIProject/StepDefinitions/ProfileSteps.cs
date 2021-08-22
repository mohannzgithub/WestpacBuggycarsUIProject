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
        }

        [When(@"User updates '(.*)' And '(.*)'")]
        public void WhenUserUpdatesAnd(string firstName, string lastName)
        {
            _profilePage.updateProfile(firstName, lastName);
        }
        [Then(@"User can see '(.*)' message")]
        public void ThenUserCanSeeMessage(string expectedProfileSuccess)
        {
            _profilePage.ValidateProfileMessage(expectedProfileSuccess);
        }

    }
}
