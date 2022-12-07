using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2.RockPaperScissors;

namespace Day2.Test.RockPaperScissors
{
    public class RockPaperScissorsRoundTestData
    {
        public RockPaperScissorsRound RoundData;

        public int Player1ExpectedScore;

        public int Player2ExpectedScore;

        public RockPaperScissorsRoundTestData(RockPaperScissorsMove player1Move, RockPaperScissorsMove player2Move, int player1ExpectedScore, int player2ExpectedScore)
        {
            RoundData = new RockPaperScissorsRound(player1Move, player2Move);
            Player1ExpectedScore = player1ExpectedScore;
            Player2ExpectedScore = player2ExpectedScore;
        }
    }
}
