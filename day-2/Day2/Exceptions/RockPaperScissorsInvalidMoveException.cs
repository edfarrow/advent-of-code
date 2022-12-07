using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2.RockPaperScissors;

namespace Day2.Exceptions
{
    public class RockPaperScissorsInvalidMoveException : Exception
    {
        internal RockPaperScissorsInvalidMoveException(RockPaperScissorsMove move) : base($"Move {move} is invalid") { }

        internal RockPaperScissorsInvalidMoveException(RockPaperScissorsMove move1, RockPaperScissorsMove move2)
            : base($"Move {move1} and move {move2} are invalid") { }
    }
}
