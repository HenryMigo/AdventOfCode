namespace AOC2023.Library;

public class DayOne
{
    private readonly Dictionary<string, string> _replacements = new()
    {
        {"one", "o1e"},
        {"two", "t2o"},
        {"three", "t3e"},
        {"four", "f4r"},
        {"five", "f5e"},
        {"six", "s6x"},
        {"seven", "s7n"},
        {"eight", "e8t"},
        {"nine", "n9e"}
    };

    private readonly string _numbers = "123456789";

    public async Task<int> PartOneAsync(string fileName)
    {
        var lines = await ReadFileAsync(fileName);
        var numbers = new List<int>();

        foreach (var line in lines.ToList())
        {
            var firstNumber = line.FirstOrDefault(x => _numbers.Contains(x));
            var lastNumber = line.LastOrDefault(x => _numbers.Contains(x));

            var finalNumber = int.Parse($"{firstNumber}{lastNumber}");

            numbers.Add(finalNumber);
        }

        return numbers.Sum();
    }

    public async Task<int> PartTwoAsync(string fileName)
    {
        var lines = await ReadFileAsync(fileName);
        var numbers = new List<int>();

        foreach (var line in lines.ToList())
        {
            var fixedString = line;

            foreach (var replacement in _replacements)
            {
                fixedString = fixedString.Replace(replacement.Key, replacement.Value);
            }

            var firstNumber = fixedString.FirstOrDefault(x => _numbers.Contains(x));
            var lastNumber = fixedString.LastOrDefault(x => _numbers.Contains(x));
            
            var finalNumber = int.Parse($"{firstNumber}{lastNumber}");
            
            numbers.Add(finalNumber);
        }

        return numbers.Sum();
    }

    private async Task<IEnumerable<string>> ReadFileAsync(string fileName)
    {
        var fileContents = await File.ReadAllTextAsync($"../../../../AOC2023.Library/{fileName}.txt");

        return fileContents.Split("\r\n");
    }
}