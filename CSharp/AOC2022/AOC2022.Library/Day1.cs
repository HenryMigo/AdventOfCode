namespace AOC2022.Library
{
    public static class Day1
    {
        public static int Part_One(IEnumerable<string> inputs)
        {
            var elves = GetElves(inputs);

            var calorieSums = elves.Select(x => x.Calories.Sum());

            return calorieSums.Max();
        }

        public static int Part_Two(IEnumerable<string> inputs)
        {
            var elves = GetElves(inputs);

            var elvesOrdered = elves.OrderByDescending(x => x.Calories.Sum());

            var topThreeElves = elvesOrdered.Take(3).Select(x => x.Calories.Sum());

            return topThreeElves.Sum();
        }

        private static List<ElvesDayOne> GetElves(IEnumerable<string> inputs)
        {
            var elves = new List<ElvesDayOne>();
            var tempList = new List<string>();
            var list = inputs.ToArray();

            for (var i = 0; i <= list.Length; i++)
            {
                if (i == list.Length)
                {
                    elves.Add(new ElvesDayOne(tempList));
                    tempList = new List<string>();
                }
                else if (string.IsNullOrEmpty(list[i]))
                {
                    elves.Add(new ElvesDayOne(tempList));
                    tempList = new List<string>();
                }
                else
                {
                    tempList.Add(list[i]);
                }
            }

            return elves;
        }
    }

    public class ElvesDayOne
    {
        public ElvesDayOne(List<string> calories)
        {
            Calories = calories.Select(int.Parse).ToList();
        }

        public List<int> Calories { get; set; }
    }
}
