namespace AOC2023.Library;

public class DayTwo
{
    private const int RedCubes = 12;
    private const int GreenCubes = 13;
    private const int BlueCubes = 14;

    public async Task<int> PartOneAsync(string fileName)
    {
        var games = await ReadFileAsync(fileName);

        var results = new List<int>();

        foreach (var game in games)
        {
            var notOkay = new List<bool>();

            var gameNumber = int.Parse(game.Split(':')[0].Split(' ')[1]);
            var sets = game.Split(':')[1].Split(';');

            foreach (var set in sets)
            {
                var redCubes = 0;
                var greenCubes = 0;
                var blueCubes = 0;

                var cubes = set.Split(',');

                foreach (var cube in cubes)
                {
                    var cubeSplit = cube.Trim().Split(' ');
                    var cubeAmount = int.Parse(cubeSplit[0]);
                    var cubeColour = cubeSplit[1].ToLower();

                    switch (cubeColour)
                    {
                        case "blue":
                            blueCubes += cubeAmount;
                            break;
                        case "red":
                            redCubes += cubeAmount;
                            break;
                        case "green":
                            greenCubes += cubeAmount;
                            break;
                    }
                }

                if (greenCubes > GreenCubes || blueCubes > BlueCubes || redCubes > RedCubes)
                {
                    notOkay.Add(false);
                }
            }

            if (!notOkay.Contains(false))
            {
                results.Add(gameNumber);
            }
        }

        return results.Sum();
    }

    public async Task<int> PartTwoAsync(string fileName)
    {
        var games = await ReadFileAsync(fileName);

        var results = new List<int>();

        foreach (var game in games)
        {
            var minRed = 0;
            var minBlue = 0;
            var minGreen = 0;

            var sets = game.Split(':')[1].Split(';');

            foreach (var set in sets)
            {
                var redCubes = 0;
                var greenCubes = 0;
                var blueCubes = 0;

                var cubes = set.Split(',');

                foreach (var cube in cubes)
                {
                    var cubeSplit = cube.Trim().Split(' ');
                    var cubeAmount = int.Parse(cubeSplit[0]);
                    var cubeColour = cubeSplit[1].ToLower();

                    switch (cubeColour)
                    {
                        case "blue":
                            blueCubes += cubeAmount;

                            if (minBlue == 0)
                            {
                                minBlue = cubeAmount;
                            }
                            else if (cubeAmount > minBlue)
                            {
                                minBlue = cubeAmount;
                            }

                            break;
                        case "red":
                            redCubes += cubeAmount;

                            if (minRed == 0)
                            {
                                minRed = cubeAmount;
                            }
                            else if (cubeAmount > minRed)
                            {
                                minRed = cubeAmount;
                            }

                            break;
                        case "green":
                            greenCubes += cubeAmount;

                            if (minGreen == 0)
                            {
                                minGreen = cubeAmount;
                            }
                            else if (cubeAmount > minGreen)
                            {
                                minGreen = cubeAmount;
                            }

                            break;
                    }
                }
            }

            results.Add(minBlue * minGreen * minRed);
        }

        return results.Sum();
    }

    private async Task<IEnumerable<string>> ReadFileAsync(string fileName)
    {
        var fileContents = await File.ReadAllTextAsync($"../../../../AOC2023.Library/{fileName}.txt");

        return fileContents.Split("\r\n");
    }
}