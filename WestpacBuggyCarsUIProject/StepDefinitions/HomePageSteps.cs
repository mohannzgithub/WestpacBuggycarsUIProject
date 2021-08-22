using BoDi;
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
        }

        [Then(@"User should able to see Home Page")]
        public void ThenUserShouldAbleToSeeHomePage()
        {
            _homePage = new HomePage(ContextObj);
            _homePage.ValidateHomePage();
        }

    }
}
