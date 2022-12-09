using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2.RockPaperScissors;

namespace Day2.Test.OptimalMoveCalculatorTests
{
    public class OptimalMoveCalculatorTest
    {
        [TestCaseSource(nameof(GetTestData))]
        public void GivenAnOpponentMoveAndAnIntendedResult_WhenDetermined_ThenCorrectResultIsReturned(OptimalMoveCalculatorTestData testData)
        {
            var result = OptimalMoveCalculator.DetermineOptimalMove(testData.OpponentMove, testData.IntendedOutcome);

            result.Should().Be(testData.ExpectedResult);
        }

        private static List<OptimalMoveCalculatorTestData> GetTestData()
        {
            return new List<OptimalMoveCalculatorTestData>
            {
                new OptimalMoveCalculatorTestData
                {
                    OpponentMove = RockPaperScissorsMove.Rock,
                    IntendedOutcome = IntendedOutcome.Draw,
                    ExpectedResult = RockPaperScissorsMove.Rock
                },
                new OptimalMoveCalculatorTestData
                {
                    OpponentMove = RockPaperScissorsMove.Paper,
                    IntendedOutcome = IntendedOutcome.Lose,
                    ExpectedResult = RockPaperScissorsMove.Rock
                },
                new OptimalMoveCalculatorTestData
                {
                    OpponentMove = RockPaperScissorsMove.Scissors,
                    IntendedOutcome = IntendedOutcome.Win,
                    ExpectedResult = RockPaperScissorsMove.Rock
                }
            };
        }
    }
}
