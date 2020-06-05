using BoDi;
using ClassLibrary1.ApiModels;
using ClassLibrary1.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer objectContainer;
        public Hooks(IObjectContainer container)
        {
            objectContainer = container;
        }
        


        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            var client = new GoRestApiClient ();
            objectContainer.RegisterInstanceAs<IGoRestApiClient>(client);



            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
