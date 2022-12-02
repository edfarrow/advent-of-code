using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Test.AOC
{
    public class AocAnswer
    {
        [Test]
        public void FindAocAnswerToPart1()
        {
            var parser = new InputParser();

            var elves = parser.Parse(AocData.Data);
            var calculator = new ElfCalculator(elves);
            var result = calculator.CalculateHeaviestWeightCarried();

            TestContext.WriteLine(result);
        }

        [Test]
        public void FindAocAnswerToPart2()
        {
            var parser = new InputParser();

            var elves = parser.Parse(AocData.Data);
            var calculator = new ElfCalculator(elves);
            var result = calculator.CalculateSumOfTopThreeHeaviestWeightsCarried();

            TestContext.WriteLine(result);
        }
    }
}
