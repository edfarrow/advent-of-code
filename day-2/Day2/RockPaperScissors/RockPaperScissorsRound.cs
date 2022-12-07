using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Day2.Exceptions;

namespace Day2.RockPaperScissors
{
    public class RockPaperScissorsRound
    {
        private RockPaperScissorsMoveRoundScore _entry1 = new();
        private RockPaperScissorsMoveRoundScore _entry2 = new();

        public int Entry1Score => _entry1.RoundScore;
        public int Entry2Score => _entry2.RoundScore;

        public RockPaperScissorsRound(RockPaperScissorsMove entry1, RockPaperScissorsMove entry2)
        {
            _entry1.PlayerMove = entry1;
            _entry2.PlayerMove = entry2;
        }

        public void CalculateScores()
        {
            var roundResult = RockPaperScissorsRoundCalculator.CalculateResult(_entry1.PlayerMove, _entry2.PlayerMove);
            ScoreMoves(roundResult);
            ScoreShapes();
        }

        private void ScoreMoves(RockPaperScissorsResult result)
        {
            if (result == RockPaperScissorsResult.Player1Win)
            {
                _entry1.RoundScore += 6;
            }
            else if (result == RockPaperScissorsResult.Player2Win)
            {
                _entry2.RoundScore += 6;
            }
            else if (result == RockPaperScissorsResult.Draw)
            {
                _entry1.RoundScore += 3;
                _entry2.RoundScore += 3;
            }
        }

        private void ScoreShapes()
        {
            _entry1.RoundScore += ScoreShape(_entry1.PlayerMove);
            _entry2.RoundScore += ScoreShape(_entry2.PlayerMove);
        }

        private static int ScoreShape(RockPaperScissorsMove shape)
        {
            return (int)shape;
        }

    }
}
