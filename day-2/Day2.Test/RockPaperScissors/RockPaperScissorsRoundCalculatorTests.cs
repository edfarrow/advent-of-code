using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2.Exceptions;
using Day2.RockPaperScissors;

namespace Day2.Test.RockPaperScissors
{
    public class RockPaperScissorsRoundCalculatorTests
    {
        [TestCaseSource(nameof(GetRoundTestData))]
        public void GivenValidPlayerMoves_WhenCalculateResultIsCalled_ThenCorrectResultIsReturned(RockPaperScissorsRoundCalculatorTestData roundData)
        {
            var result = RockPaperScissorsRoundCalculator.CalculateResult(roundData.player1Move, roundData.player2Move);

            result.Should().Be(roundData.expectedResult);
        }

        [TestCaseSource(nameof(GetRoundTestDataWithInvalidMoves))]
        public void GivenAnInvalidPlayerMove_WhenCalculateResultIsCalled_ThenRPSInvalidMoveExceptionIsThrown(RockPaperScissorsRoundCalculatorTestData roundData)
        {
            var result = () => RockPaperScissorsRoundCalculator.CalculateResult(roundData.player1Move, roundData.player2Move);

            result.Should().Throw<RockPaperScissorsInvalidMoveException>();
        }

        private static List<RockPaperScissorsRoundCalculatorTestData> GetRoundTestData()
        {
            return new List<RockPaperScissorsRoundCalculatorTestData>
            {
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Rock,
                    player2Move = RockPaperScissorsMove.Scissors,
                    expectedResult = RockPaperScissorsResult.Player1Win
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Paper,
                    player2Move = RockPaperScissorsMove.Scissors,
                    expectedResult = RockPaperScissorsResult.Player2Win
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Scissors,
                    player2Move = RockPaperScissorsMove.Scissors,
                    expectedResult = RockPaperScissorsResult.Draw
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Rock,
                    player2Move = RockPaperScissorsMove.Paper,
                    expectedResult = RockPaperScissorsResult.Player2Win
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Scissors,
                    player2Move = RockPaperScissorsMove.Paper,
                    expectedResult = RockPaperScissorsResult.Player1Win
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Paper,
                    player2Move = RockPaperScissorsMove.Paper,
                    expectedResult = RockPaperScissorsResult.Draw
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Rock,
                    player2Move = RockPaperScissorsMove.Rock,
                    expectedResult = RockPaperScissorsResult.Draw
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Scissors,
                    player2Move = RockPaperScissorsMove.Rock,
                    expectedResult = RockPaperScissorsResult.Player2Win
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Paper,
                    player2Move = RockPaperScissorsMove.Rock,
                    expectedResult = RockPaperScissorsResult.Player1Win
                }
            };
        }

        private static List<RockPaperScissorsRoundCalculatorTestData> GetRoundTestDataWithInvalidMoves()
        {
            return new List<RockPaperScissorsRoundCalculatorTestData>
            {
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = (RockPaperScissorsMove)1234,
                    player2Move = RockPaperScissorsMove.Rock
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Paper,
                    player2Move = (RockPaperScissorsMove)(-1)
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = (RockPaperScissorsMove)1234,
                    player2Move = (RockPaperScissorsMove)(-1)
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Unset,
                    player2Move = RockPaperScissorsMove.Rock
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Paper,
                    player2Move = RockPaperScissorsMove.Unset
                },
                new RockPaperScissorsRoundCalculatorTestData
                {
                    player1Move = RockPaperScissorsMove.Unset,
                    player2Move = RockPaperScissorsMove.Unset
                },
            };
        }
    }
}
