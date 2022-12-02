using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Test
{
    public class ElfTests
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(50)]
        [TestCase(50000)]
        public void GivenNoInitialLoad_WhenALoadAdded_ThenLoadCarriedIsCorrect(int loadToAdd)
        {
            var elf = new Elf();
            var expectedLoad = loadToAdd;

            elf.AddLoad(loadToAdd);

            elf.LoadCarried.Should().Be(expectedLoad);
        }

        [TestCase(9, 1)]
        [TestCase(1, 2)]
        [TestCase(4502, 3)]
        [TestCase(500, 50)]
        [TestCase(500, 50000)]
        public void GivenAnExistingLoad_WhenALoadIsAdded_ThenLoadCarriedIsCorrect(int existingLoad, int loadToAdd)
        {
            var elf = new Elf();
            elf.AddLoad(existingLoad);
            var expectedLoad = loadToAdd + existingLoad;

            elf.AddLoad(loadToAdd);

            elf.LoadCarried.Should().Be(expectedLoad);
        }
    }
}
