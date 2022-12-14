using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2.Test.InputParserTest;
using FluentAssertions.Execution;

namespace Day2.Test.IntegrationTest
{
    public class IntegrationTest
    {
        [TestCaseSource(nameof(GetTestDataForPlayerInput))]
        public void GivenPlayerInputIsMoves_WhenAnInputStringIsProcessed_ThenCorrectScoresAreCalculated(IntegrationTestData testData)
        {
            var result = new RockPaperScissorsScoreAggregator();
            result.AddRoundData(testData.Input, treatPlayerInputAsStrategyGuide: false);
            result.CalculateTotalScores();

            using var _ = new AssertionScope();
            result.TotalElfScore.Should().Be(testData.ExpectedElfScore);
            result.TotalHumanScore.Should().Be(testData.ExpectedHumanScore);
        }

        [TestCaseSource(nameof(GetTestDataForPlayerStrategy))]
        public void GivenPlayerInputIsStrategy_WhenAnInputStringIsProcessed_ThenCorrectScoresAreCalculated(IntegrationTestData testData)
        {
            var result = new RockPaperScissorsScoreAggregator();
            result.AddRoundData(testData.Input, treatPlayerInputAsStrategyGuide: true);
            result.CalculateTotalScores();

            using var _ = new AssertionScope();
            result.TotalElfScore.Should().Be(testData.ExpectedElfScore);
            result.TotalHumanScore.Should().Be(testData.ExpectedHumanScore);
        }

        private static List<IntegrationTestData> GetTestDataForPlayerInput()
        {
            return new List<IntegrationTestData>
            {
                new IntegrationTestData
                {
                    Input = "A X",
                    ExpectedElfScore = 4,
                    ExpectedHumanScore = 4,
                },
                new IntegrationTestData
                {
                    Input = "A Y\r\nB X\r\nC Z",
                    ExpectedElfScore = 15,
                    ExpectedHumanScore = 15,
                }
            };
        }

        private static List<IntegrationTestData> GetTestDataForPlayerStrategy()
        {
            return new List<IntegrationTestData>
            {
                new IntegrationTestData
                {
                    Input = "A X",
                    ExpectedElfScore = 7,
                    ExpectedHumanScore = 3,
                },
                new IntegrationTestData
                {
                    Input = "A Y\r\nB X\r\nC Z",
                    ExpectedElfScore = 15,
                    ExpectedHumanScore = 12,
                }
            };
        }
    }
}
