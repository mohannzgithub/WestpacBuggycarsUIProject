using BoDi;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using WestpacBuggyCarsUIProject.DataModel;
using WestpacBuggyCarsUIProject.pages;

namespace WestpacBuggyCarsUIProject.StepDefinitions
{
    [Binding]
    public class LandingPageSteps : BaseSteps
    {
        private LandingPage _landingPage;
        private HomePage _homePage;

        public LandingPageSteps(ContextObject context, IObjectContainer container) : base(context, container.Resolve<ScenarioContext>())
        {
            ContextObj = context;
        }
        
        [Given(@"User navigates to Buggy cars website")]
        public void GivenUserNavigatesToBuggyCarsWebsite()
        {
            _landingPage = new LandingPage(ContextObj);
        }

        [Given(@"User Enter the '(.*)' And '(.*)'")]
        [When(@"User Enter the '(.*)' And '(.*)'")]
        public void WhenUserEnterTheAnd(string username, string password)
        {
            _landingPage.EnterLoginCredentials(username, password);
        }

        [When(@"User Clicks on Login button")]
        public void WhenClickOnLoginButton()
        {
            _landingPage.clickLoginButton();
        }

        [Then(@"User should able to see error message '(.*)'")]
        public void ThenUserShouldAbleToSeeErrorMessage(string expectedErrorMessage)
        {
            Assert.AreEqual(_landingPage.GetLoginErrorMessage(),expectedErrorMessage,"Invalid login error message");
        }


        [Given(@"User Navigates to profile Page")]
        public void GivenUserNavigatesToProfilePage()
        {
            _homePage.clickOnProfile();
        }




    }
}
