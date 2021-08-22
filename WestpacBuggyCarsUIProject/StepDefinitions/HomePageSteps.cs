using BoDi;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WestpacBuggyCarsUIProject.DataModel;
using WestpacBuggyCarsUIProject.pages;

namespace WestpacBuggyCarsUIProject.StepDefinitions
{
    [Binding]
    public class HomePageSteps : BaseSteps
    {
        private HomePage _homePage;

        public HomePageSteps(ContextObject context, IObjectContainer container) : base(context, container.Resolve<ScenarioContext>())
        {
            ContextObj = context;
            _homePage = new HomePage(ContextObj);
        }

        [Then(@"User should able to see Home Page")]
        public void ThenUserShouldAbleToSeeHomePage()
        {
            Assert.IsTrue(_homePage.IsDisplayHomePage(), "Unable to login");
        }

        [When(@"User Navigates to profile Page")]
        [Given(@"User Navigates to profile Page")]
        public void GivenUserNavigatesToProfilePage()
        {
            _homePage.ClickOnProfile();
        }

    }
}
