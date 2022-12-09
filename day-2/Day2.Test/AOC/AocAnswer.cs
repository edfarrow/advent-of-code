using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;

namespace Day2.Test.AOC
{
    public class AocAnswer
    {
        [Test]
        public void FindAocAnswerToPart1()
        {
            var result = new RockPaperScissorsScoreAggregator();
            result.AddRoundData(AocData.Data, treatPlayerInputAsStrategyGuide: false);
            result.CalculateTotalScores();

            TestContext.WriteLine(result.TotalHumanScore);
        }

        [Test]
        public void FindAocAnswerToPart2()
        {
            var result = new RockPaperScissorsScoreAggregator();
            result.AddRoundData(AocData.Data, treatPlayerInputAsStrategyGuide: true);
            result.CalculateTotalScores();

            TestContext.WriteLine(result.TotalHumanScore);
        }
    }
}
