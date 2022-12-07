using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2.RockPaperScissors;

namespace Day2
{
    public class RockPaperScissorsScoreAggregator
    {
        private readonly List<RockPaperScissorsRound> _rounds = new();

        public int TotalElfScore { get; private set; }
        public int TotalHumanScore { get; private set; }

        public RockPaperScissorsScoreAggregator() 
        {
        }

        public void AddRoundData(string input)
        {
            _rounds.AddRange(InputParser.ParseInput(input));
        }

        public void CalculateTotalScores()
        {
            foreach (var round in _rounds)
            {
                round.CalculateScores();
                TotalElfScore += round.Entry1Score;
                TotalHumanScore += round.Entry2Score;
            }
        }
    }
}
