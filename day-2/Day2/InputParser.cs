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
        public static List<RockPaperScissorsRound> ParseInput(string input)
        {
            var result = new List<RockPaperScissorsRound>();

            var splitRounds = input.Split("\r\n");

            foreach (var rawRound in splitRounds)
            {
                result.Add(ParseRound(rawRound));
            }

            return result;
        }

        private static RockPaperScissorsRound ParseRound(string input)
        {
            var moves = input.Split(" ");

            return new RockPaperScissorsRound(ParseMove(moves[0]), ParseMove(moves[1]));
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
    }
}
