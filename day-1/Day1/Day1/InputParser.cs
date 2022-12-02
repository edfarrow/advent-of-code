using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class InputParser
    {
        public List<Elf> Parse(string input)
        {
            var inputPerElf = SplitInputIntoInputsForIndividualElves(input);
            
            return inputPerElf
                .Select(input => ParseElfInput(input))
                .Select(load => AssembleElfFromInput(load))
                .ToList();
        }

        private List<string> SplitInputIntoInputsForIndividualElves(string input)
        {
            return input
                .Split("\r\n\r\n")
                .ToList();
        }

        private List<int> ParseElfInput(string input)
        {
            return input
                .Split("\r\n")
                .Select(str => int.Parse(str))
                .ToList();
        }

        private Elf AssembleElfFromInput(List<int> input)
        {
            var elf = new Elf();
            input.ForEach(load => elf.AddLoad(load));
            return elf;
        }
    }
}
