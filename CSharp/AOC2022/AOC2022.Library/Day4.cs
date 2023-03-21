﻿namespace AOC2022.Library
{
    public static class Day4
    {
        public static int Part_One(List<string> inputData)
        {
            var elves = new Elves
            {
                Pairs = new List<List<Pairs>>()
            };

            foreach (var line in inputData)
            {
                var pairs = new List<Pairs>();
                var parts = line.Split(',');

                foreach (var part in parts)
                {
                    var range = part.Split('-');
                    pairs.Add(new Pairs(int.Parse(range[0]), int.Parse(range[1])));
                }

                elves.Pairs.Add(pairs);
            }

            var count = 0;

            for (var i = 0; i < elves.Pairs.Count; i++)
            {
                var pair = elves.Pairs[i];

                for (var j = 0; j < pair.Count - 1; j++)
                {
                    var firstRange = pair[j];
                    var secondRange = pair[j + 1];

                    if (firstRange.From <= secondRange.From && firstRange.To >= secondRange.To)
                    {
                        count++;
                    }
                    else if (secondRange.From <= firstRange.From && secondRange.To >= firstRange.To)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static int Part_Two(List<string> inputData)
        {
            return 0;
        }
    }

    public class Elves
    {
        public List<List<Pairs>> Pairs { get; set; }
    }

    public class Pairs
    {
        public Pairs(int from, int to)
        {
            From = from;
            To = to;
        }

        public int From { get; set; }

        public int To { get; set; }
    }
}
