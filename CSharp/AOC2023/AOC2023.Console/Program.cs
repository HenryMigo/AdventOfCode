// See https://aka.ms/new-console-template for more information

using AOC2023.Library;

var dayOne = new DayOne();

var result = await dayOne.PartTwoAsync("DayOne");

Console.WriteLine($"Result: {result}");

Console.ReadKey();