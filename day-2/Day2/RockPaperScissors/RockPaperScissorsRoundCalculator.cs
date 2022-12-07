using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2.Exceptions;

namespace Day2.RockPaperScissors
{
    public static class RockPaperScissorsRoundCalculator
    {
        public static RockPaperScissorsResult CalculateResult(RockPaperScissorsMove player1Move, RockPaperScissorsMove player2Move)
        {
            ValidateMoves(player1Move, player2Move);

            if (player1Move == RockPaperScissorsMove.Rock && player2Move == RockPaperScissorsMove.Scissors)
            {
                return RockPaperScissorsResult.Player1Win;
            }
            else if (player2Move == RockPaperScissorsMove.Rock && player1Move == RockPaperScissorsMove.Scissors)
            {
                return RockPaperScissorsResult.Player2Win;
            }
            else if (player1Move < player2Move)
            {
                return RockPaperScissorsResult.Player2Win;
            }
            else if (player1Move == player2Move)
            {
                return RockPaperScissorsResult.Draw;
            }
            else
            {
                return RockPaperScissorsResult.Player1Win;
            }
        }

        private static bool IsValidMove(this RockPaperScissorsMove move)
        {
            return Enum.IsDefined(move) && move != RockPaperScissorsMove.Unset;
        }

        private static void ValidateMoves(RockPaperScissorsMove player1Move, RockPaperScissorsMove player2Move)
        {
            var isPlayer1MoveValid = player1Move.IsValidMove();
            var isPlayer2MoveValid = player2Move.IsValidMove();

            if (!isPlayer1MoveValid && !isPlayer2MoveValid)
            {
                throw new RockPaperScissorsInvalidMoveException(player1Move, player2Move);
            }
            else if (!isPlayer1MoveValid)
            {
                throw new RockPaperScissorsInvalidMoveException(player1Move);
            }
            else if (!isPlayer2MoveValid)
            {
                throw new RockPaperScissorsInvalidMoveException(player2Move);
            }
        }
    }
}
