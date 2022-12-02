namespace Day1
{
    public class ElfCalculator
    {
        private readonly List<Elf> _elves = new List<Elf>();

        public ElfCalculator(List<Elf> elves)
        {
            _elves = elves;
        }

        public int CalculateHeaviestWeightCarried()
        {
            var maxLoadSeen = 0;

            for(var i = 0; i < _elves.Count; i++)
            {
                if (_elves[i].LoadCarried > maxLoadSeen)
                {
                    maxLoadSeen = _elves[i].LoadCarried;
                }
            }

            return maxLoadSeen;
        }

        public int CalculateSumOfTopThreeHeaviestWeightsCarried()
        {
            return _elves
                .OrderByDescending(elf => elf.LoadCarried)
                .Take(3)
                .Sum(elf => elf.LoadCarried);
        }
    }
}