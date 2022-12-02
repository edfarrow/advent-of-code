using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Console.Test.Integration
{
    public class IntegrationTest
    {
        [TestCaseSource(typeof(IntegrationTestConstants), nameof(IntegrationTestConstants.Input1))]
        public void GivenAnInputString_WhenProcessed_ThenCorrectOutputIsReturned(IntegrationTestSampleData data)
        {
            var parser = new InputParser();

            var elves = parser.Parse(data.Input);
            var calculator = new ElfCalculator(elves);
            var result = calculator.CalculateHeaviestWeightCarried();

            result.Should().Be(data.ExpectedOutput);
        }
    }
}
