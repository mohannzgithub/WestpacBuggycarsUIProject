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
            _landingPage = new LandingPage(ContextObj);
        }

        [Given(@"User navigates to Buggy car with '(.*)' And '(.*)'")]
        public void GivenUserNavigatesToBuggyCarWithAnd(string userName, string password)
        {
            _landingPage.EnterLoginCredentials(userName, password);
        }

        [When(@"User Clicks on Login button")]
        public void WhenClickOnLoginButton()
        {
            _landingPage.ClickLoginButton();
        }

        [Then(@"User should able to see error message '(.*)'")]
        public void ThenUserShouldAbleToSeeErrorMessage(string expectedErrorMessage)
        {
            Assert.AreEqual(_landingPage.GetLoginErrorMessage(),expectedErrorMessage,"Invalid login error message");
        }

    }
}
