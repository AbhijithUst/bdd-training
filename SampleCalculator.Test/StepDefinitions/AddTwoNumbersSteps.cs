using SampleCalculator.API.Services;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace SampleCalculator.Test.StepDefinitions
{
    [Binding]
    public class AddTwoNumbersSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IBasicCalculationService _basicCalculationService;

        int number1 = 0;
        int number2 = 0;
        int result = 0;

        public AddTwoNumbersSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _basicCalculationService = new BasicCalculationService();
        }

        [Given(@"the first number (.*)")]
        public void GivenTheFirstNumber(int p0)
        {
            number1 = p0;
        }
        
        [Given(@"the second nimber (.*)")]
        public void GivenTheSecondNimber(int p0)
        {
            number2 = p0;
        }
        
        [When(@"the two numbers added")]
        public void WhenTheTwoNumbersAdded()
        {
            result = _basicCalculationService.Add(number1, number2);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, result);
        }
    }
}
