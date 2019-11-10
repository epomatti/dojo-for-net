using FluentAssertions;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Steps
{
    [Binding]
    public class CalculadoraSteps
    {
        private int _soma;
        [Given(@"I have entered (.*) into the calculator")]
        public void DadoIHaveEnteredIntoTheCalculator(int p0)
        {
            _soma += p0;
        }
        
        [When(@"I press add")]
        public void QuandoIPressAdd()
        {
            
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void EntaoTheResultShouldBeOnTheScreen(int p0)
        {
            p0.Should().Be(_soma);
        }
    }
}
