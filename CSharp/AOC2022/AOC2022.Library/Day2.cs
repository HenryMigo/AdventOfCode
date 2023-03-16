namespace AOC2022.Library
{
    public static class Day2
    {
        private static readonly Dictionary<string, int> InputScores = new()
        {
            {"X", 1 },
            {"Y", 2},
            {"Z", 3}
        };

        private static readonly Dictionary<string, Dictionary<string, int>> OptionScore = new()
        {
            {"A", new Dictionary<string,int>(){{"X",3},{"Y",1},{"Z",2}}},
            {"B", new Dictionary<string,int>(){{"X",1},{"Y",2},{"Z",3}}},
            {"C", new Dictionary<string,int>(){{"X",2},{"Y",3},{"Z",1}}}
        };

        private static readonly Dictionary<string, int> WinScore = new()
        {
            {"X", 0 },
            {"Y", 3 },
            {"Z", 6 }
        };

        public static int Part_One(IEnumerable<string> inputs)
        {
            var score = 0;

            foreach(var input in inputs)
            {
                var plays = input.Split(' ');

                var opponent = plays[0];
                var mine = plays[1];

                /*
                    Draw 
                */
                if (opponent == "A" &&  mine == "X" ||
                    opponent == "B" && mine == "Y" ||
                    opponent == "C" && mine == "Z") 
                {
                    score += 3 + InputScores[mine];
                }
                /*
                    Win 
                */
                else if (opponent == "A" && mine == "Y" ||
                    opponent == "B" && mine == "Z" ||
                    opponent == "C" && mine == "X")
                {
                    score += 6 + InputScores[mine];
                }
                /*
                    Loss 
                */
                else
                {
                    score += InputScores[mine];
                }
            }

            return score;
        }

        public static int Part_Two(IEnumerable<string> inputs)
        {
            var score = 0;

            foreach(var input in inputs)
            {
                var plays = input.Split(' ');

                var opponent = plays[0];
                var mine = plays[1];

                score += OptionScore[opponent][mine] + WinScore[mine];
            }

            return score;
        }
    }

    public enum MovePoints
    {
        X = 1,
        Y = 2,
        Z = 3
    }
}
