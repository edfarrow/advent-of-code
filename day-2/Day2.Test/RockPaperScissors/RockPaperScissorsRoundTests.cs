using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2.RockPaperScissors;
using FluentAssertions.Execution;

namespace Day2.Test.RockPaperScissors
{
    public class RockPaperScissorsRoundTests
    {
        [TestCaseSource(nameof(GetRoundData))]
        public void GivenARound_WhenScored_ThenPlayersReceiveCorrectPoints(RockPaperScissorsRoundTestData roundData)
        {
            var round = roundData.RoundData;

            round.CalculateScores();

            using var _ = new AssertionScope();
            round.Entry1Score.Should().Be(roundData.Player1ExpectedScore);
            round.Entry2Score.Should().Be(roundData.Player2ExpectedScore);
        }

        private static List<RockPaperScissorsRoundTestData> GetRoundData()
        {
            return new List<RockPaperScissorsRoundTestData>
            {
                new RockPaperScissorsRoundTestData(RockPaperScissorsMove.Rock, RockPaperScissorsMove.Scissors, 7, 3),
                new RockPaperScissorsRoundTestData(RockPaperScissorsMove.Scissors, RockPaperScissorsMove.Paper, 9, 2),
                new RockPaperScissorsRoundTestData(RockPaperScissorsMove.Paper, RockPaperScissorsMove.Rock, 8, 1),
                new RockPaperScissorsRoundTestData(RockPaperScissorsMove.Rock, RockPaperScissorsMove.Paper, 1, 8),
                new RockPaperScissorsRoundTestData(RockPaperScissorsMove.Paper, RockPaperScissorsMove.Scissors, 2, 9),
                new RockPaperScissorsRoundTestData(RockPaperScissorsMove.Scissors, RockPaperScissorsMove.Rock, 3, 7),
                new RockPaperScissorsRoundTestData(RockPaperScissorsMove.Rock, RockPaperScissorsMove.Rock, 4, 4),
                new RockPaperScissorsRoundTestData(RockPaperScissorsMove.Scissors, RockPaperScissorsMove.Scissors, 6, 6),
                new RockPaperScissorsRoundTestData(RockPaperScissorsMove.Paper, RockPaperScissorsMove.Paper, 5, 5)
            };
        }
    }
}
