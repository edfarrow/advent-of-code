using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Test
{
    public class InputParserTests
    {
        private static InputParser _parser = new InputParser();

        [Test]
        public void GivenASingleElfInput_WhenParsed_ThenASingleElfIsReturned()
        {
            var input = "1\r\n2\r\n3";
            var result = _parser.Parse(input);

            result.Should().BeEquivalentTo(new List<Elf> { new Elf { LoadCarried = 6 } });
        }

        [Test]
        public void GivenTwoElfInputs_WhenParsed_ThenTwoElvesAreReturned()
        {
            var input = "1\r\n2\r\n3\r\n\r\n1\r\n2\r\n300";

            var result = _parser.Parse(input);

            result.Should().BeEquivalentTo(new List<Elf>
            {
                new Elf { LoadCarried = 6 },
                new Elf { LoadCarried = 303 }
            });
        }
    }
}
