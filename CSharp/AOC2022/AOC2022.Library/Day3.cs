using System.Linq;

namespace AOC2022.Library
{
    public static class Day3
    {
        private static readonly Dictionary<char, int> Scores = new()
        {
            {'a', 1 },
            {'b', 2 },
            {'c', 3 },
            {'d', 4 },
            {'e', 5 },
            {'f', 6 },
            {'g', 7 },
            {'h', 8 },
            {'i', 9 },
            {'j', 10 },
            {'k', 11 },
            {'l', 12 },
            {'m', 13 },
            {'n', 14 },
            {'o', 15 },
            {'p', 16 },
            {'q', 17 },
            {'r', 18 },
            {'s', 19 },
            {'t', 20 },
            {'u', 21 },
            {'v', 22 },
            {'w', 23 },
            {'x', 24 },
            {'y', 25 },
            {'z', 26 },
            {'A', 27 },
            {'B', 28 },
            {'C', 29 },
            {'D', 30 },
            {'E', 31 },
            {'F', 32 },
            {'G', 33 },
            {'H', 34 },
            {'I', 35 },
            {'J', 36 },
            {'K', 37 },
            {'L', 38 },
            {'M', 39 },
            {'N', 40 },
            {'O', 41 },
            {'P', 42 },
            {'Q', 43 },
            {'R', 44 },
            {'S', 45 },
            {'T', 46 },
            {'U', 47 },
            {'V', 48 },
            {'W', 49 },
            {'X', 50 },
            {'Y', 51 },
            {'Z', 52 },
        };

        public static int Part_One(List<string> inputData)
        {
            var ruckSacks = new List<RuckSack>();
            var existsInBothSacks = new List<Dictionary<char, int>>();

            foreach (var input in inputData)
            {
                ruckSacks.Add(new RuckSack(input));
            }

            ExistsInSack(ruckSacks, existsInBothSacks);

            return existsInBothSacks.Select(x => x.Sum(y => y.Value)).Sum();
        }

        private static void ExistsInSack(List<RuckSack> ruckSacks, List<Dictionary<char, int>> existsInBothSacks)
        {
            foreach (var (sack, existsInBoth) in from sack in ruckSacks
                                                 let existsInBoth = new Dictionary<char, int>()
                                                 select (sack, existsInBoth))
            {
                foreach (var item in sack.FirstPart)
                {
                    if (sack.SecondPart.Contains(item))
                    {
                        if (!existsInBoth.ContainsKey(item))
                        {
                            existsInBoth.Add(item, Scores[item]);
                        }
                    }
                }

                existsInBothSacks.Add(existsInBoth);
            }
        }

        public static int Part_Two(List<string> inputData)
        {
            var ruckSacks = new List<string>();
            var existsInAllThreeSacks = new List<Dictionary<char, int>>();

            foreach (var input in inputData)
            {
                ruckSacks.Add(input);
            }

            for (var i = 0; i <= ruckSacks.Count - 3; i += 3)
            {
                var sack = ruckSacks[i];
                var existsInThree = new Dictionary<char, int>();

                foreach(var item in sack)
                {
                    if (ruckSacks[i + 1].Contains(item) && ruckSacks[i + 2].Contains(item))
                    {
                        if (!existsInThree.ContainsKey(item))
                        {
                            existsInThree.Add(item, Scores[item]);
                        }
                    }
                }

                existsInAllThreeSacks.Add(existsInThree);
            }

            return existsInAllThreeSacks.Select(x => x.Sum(y => y.Value)).Sum();
        }
    }

    public class RuckSack
    {
        public RuckSack(string input)
        {
            FirstPart = input[0..(input.Length / 2)].ToList();
            SecondPart = input[(input.Length / 2)..input.Length].ToList();
        }

        public List<char> FirstPart { get; set; }
        public List<char> SecondPart { get; set; }
    }
}
