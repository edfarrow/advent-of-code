using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2.RockPaperScissors;

namespace Day2
{
    public static class InputParser
    {
        public static List<RockPaperScissorsRound> ParseInput(string input, bool treatPlayerInputAsStrategyGuide)
        {
            var result = new List<RockPaperScissorsRound>();

            var splitRounds = input.Split("\r\n");

            foreach (var rawRound in splitRounds)
            {
                if (treatPlayerInputAsStrategyGuide)
                {
                    result.Add(ParseInputWithPlayerStrategy(rawRound));
                }
                else
                {
                    result.Add(ParseInputWithPlayerEntries(rawRound));
                }

            }

            return result;
        }

        private static RockPaperScissorsRound ParseInputWithPlayerEntries(string input)
        {
            var moves = input.Split(" ");

            return new RockPaperScissorsRound(ParseMove(moves[0]), ParseMove(moves[1]));
        }


        private static RockPaperScissorsRound ParseInputWithPlayerStrategy(string input)
        {
            var moves = input.Split(" ");

            var opponentMove = ParseMove(moves[0]);
            var playerStrategy = ParseIntendedOutcome(moves[1]);
            var playerMove = OptimalMoveCalculator.DetermineOptimalMove(opponentMove, playerStrategy);

            return new RockPaperScissorsRound(opponentMove, playerMove);
        }

        private static RockPaperScissorsMove ParseMove(string input)
        {
            if (input.Equals("A") || input.Equals("X"))
            {
                return RockPaperScissorsMove.Rock;
            }
            else if (input.Equals("B") || input.Equals("Y"))
            {
                return RockPaperScissorsMove.Paper;
            }
            else if (input.Equals("C") || input.Equals("Z")) 
            {
                return RockPaperScissorsMove.Scissors;
            }
            else
            {
                return RockPaperScissorsMove.Unset;
            }
        }

        private static IntendedOutcome ParseIntendedOutcome(string input)
        {
            if (input.Equals("X"))
            {
                return IntendedOutcome.Lose;
            }
            else if (input.Equals("Y"))
            {
                return IntendedOutcome.Draw;
            }
            else if (input.Equals("Z"))
            {
                return IntendedOutcome.Win;
            }
            else
            {
                return IntendedOutcome.Unset;
            }
        }
    }
}
