using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WestpacBuggyCarsUIProject.DataModel;

namespace WestpacBuggyCarsUIProject.StepDefinitions
{
    [Binding]
    public class BaseSteps
    {
        protected ContextObject ContextObj;
        protected ScenarioContext ScenarioContext;
        public BaseSteps(ContextObject context, ScenarioContext scenarioContext)
        {
            ContextObj = context;
            ScenarioContext = scenarioContext;
        }
    }

}

