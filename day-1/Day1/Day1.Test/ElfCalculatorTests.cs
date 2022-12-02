using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Test
{
    public class ElfCalculatorTests
    {
        [Test]
        public void GivenASingleElf_WhenFindHeaviestWeightCarriedIsCalled_ThenCorrectResultIsReturned()
        {
            var elves = new List<Elf> { new Elf { LoadCarried = 1 } };
            var calculator = new ElfCalculator(elves);

            var result = calculator.CalculateHeaviestWeightCarried();

            result.Should().Be(1);
        }

        [Test]
        public void GivenMultipleElves_WhenFindHeaviestWeightCarriedIsCalled_ThenCorrectResultIsReturned()
        {
            var elves = new List<Elf> { new Elf { LoadCarried = 2 }, new Elf { LoadCarried = 2000 }, new Elf { LoadCarried = 40 } };
            var calculator = new ElfCalculator(elves);

            var result = calculator.CalculateHeaviestWeightCarried();

            result.Should().Be(2000);
        }

        [Test]
        public void GivenASingleElf_WhenCalculateSumOfTopThreeHeaviestWeightsCarriedIsCalled_ThenCorrectResultIsReturned()
        {
            var elves = new List<Elf> { new Elf { LoadCarried = 1 } };
            var calculator = new ElfCalculator(elves);

            var result = calculator.CalculateSumOfTopThreeHeaviestWeightsCarried();

            result.Should().Be(1);
        }

        [Test]
        public void GivenThreeElves_WhenCalculateSumOfTopThreeHeaviestWeightsCarriedIsCalled_ThenCorrectResultIsReturned()
        {
            var elves = new List<Elf> { new Elf { LoadCarried = 2 }, new Elf { LoadCarried = 2000 }, new Elf { LoadCarried = 40 } };
            var calculator = new ElfCalculator(elves);

            var result = calculator.CalculateSumOfTopThreeHeaviestWeightsCarried();

            result.Should().Be(2042);
        }

        [Test]
        public void GivenMoreThanThreeElves_WhenCalculateSumOfTopThreeHeaviestWeightsCarriedIsCalled_ThenCorrectResultIsReturned()
        {
            var elves = new List<Elf> { new Elf { LoadCarried = 2 }, new Elf { LoadCarried = 2000 }, new Elf { LoadCarried = 40 }, new Elf { LoadCarried = 200 } };
            var calculator = new ElfCalculator(elves);

            var result = calculator.CalculateSumOfTopThreeHeaviestWeightsCarried();

            result.Should().Be(2240);
        }
    }
}
