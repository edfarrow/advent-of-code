using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2.RockPaperScissors;

namespace Day2
{
    public static class OptimalMoveCalculator
    {
        public static RockPaperScissorsMove DetermineOptimalMove(RockPaperScissorsMove opponentMove, IntendedOutcome intendedResult)
        {
            if (intendedResult == IntendedOutcome.Win)
            {
                return DetermineWinningMove(opponentMove);
            }
            else if (intendedResult == IntendedOutcome.Lose)
            {
                return DetermineLosingMove(opponentMove);
            }
            return DetermineDrawMove(opponentMove);
        }

        private static RockPaperScissorsMove DetermineWinningMove(RockPaperScissorsMove opponentMove)
        {
            return opponentMove switch
            {
                RockPaperScissorsMove.Paper => RockPaperScissorsMove.Scissors,
                RockPaperScissorsMove.Scissors => RockPaperScissorsMove.Rock,
                RockPaperScissorsMove.Rock => RockPaperScissorsMove.Paper,
                _ => RockPaperScissorsMove.Unset
            };
        }

        private static RockPaperScissorsMove DetermineLosingMove(RockPaperScissorsMove opponentMove)
        {
            return opponentMove switch
            {
                RockPaperScissorsMove.Paper => RockPaperScissorsMove.Rock,
                RockPaperScissorsMove.Scissors => RockPaperScissorsMove.Paper,
                RockPaperScissorsMove.Rock => RockPaperScissorsMove.Scissors,
                _ => RockPaperScissorsMove.Unset
            };
        }

        private static RockPaperScissorsMove DetermineDrawMove(RockPaperScissorsMove opponentMove)
        {
            return opponentMove switch
            {
                RockPaperScissorsMove.Paper => RockPaperScissorsMove.Paper,
                RockPaperScissorsMove.Scissors => RockPaperScissorsMove.Scissors,
                RockPaperScissorsMove.Rock => RockPaperScissorsMove.Rock,
                _ => RockPaperScissorsMove.Unset
            };
        }
    }
}
