using ClassLibrary1.Interface;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.StepDefinitions
{
    [Binding]
    public sealed class UsersSteps
    {
        public readonly IGoRestApiClient _client;
        private readonly ScenarioContext context;
        private readonly IGoRestApiClient client;
       
        public UsersSteps(ScenarioContext injectedContext, IGoRestApiClient _client)
        {
            context = injectedContext;
            _client = client;
        }


        [When(@"I have an array with registered user data")]
        [Obsolete]
        public void WhenIHaveAnArrayWithRegisteredUserData()
        {
            ScenarioContext.Current.Pending();
        }
    }

    //Top of the script
#pragma warning disable 0649 
}
