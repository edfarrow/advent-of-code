using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2.RockPaperScissors;

namespace Day2.Test.InputParserTest
{
    public class InputParserTests
    {
        [TestCaseSource(nameof(GetTestData))]
        public void GivenAValidInput_WhenParsed_ThenCorrectRoundDataIsSet(InputParserTestData inputData)
        {
            var result = InputParser.ParseInput(inputData.Input);

            result.Should().BeEquivalentTo(inputData.ExpectedResult);
        }

        private static List<InputParserTestData> GetTestData()
        {
            return new List<InputParserTestData>
            {
                new InputParserTestData
                {
                    Input = "A X",
                    ExpectedResult = new()
                    {
                        new RockPaperScissorsRound(RockPaperScissorsMove.Rock, RockPaperScissorsMove.Rock)
                    }
                },
                new InputParserTestData
                {
                    Input = "A Y\r\nB X\r\nC Z",
                    ExpectedResult = new()
                    {
                        new RockPaperScissorsRound(RockPaperScissorsMove.Rock, RockPaperScissorsMove.Paper),
                        new RockPaperScissorsRound(RockPaperScissorsMove.Paper, RockPaperScissorsMove.Rock),
                        new RockPaperScissorsRound(RockPaperScissorsMove.Scissors, RockPaperScissorsMove.Scissors)
                    }
                }
            };
        }
    }
}
