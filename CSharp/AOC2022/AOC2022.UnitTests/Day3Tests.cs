using AOC2022.Library;
using FluentAssertions;
using Xunit;

namespace AOC2022.UnitTests
{
    public class Day3Tests
    {
        [Fact]
        public void Day3_Part1_Example()
        {
            // Arrange
            var inputData = "vJrwpWtwJgWrhcsFMMfFFhFp\r\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\r\nPmmdzqPrVvPwwTWBwg\r\nwMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\r\nttgJtRGJQctTZtZT\r\nCrZsJsPPZsGzwwsLwLmpwMDw".Split("\r\n").ToList();

            // Act
            var result = Day3.Part_One(inputData);

            // Assert
            result.Should().Be(157);
        }

        [Fact]
        public void Day3_Part1()
        {
            // Arrange
            var inputData = File.ReadAllLines("../../../InputData/Day3.txt").ToList();

            // Act
            var result = Day3.Part_One(inputData);

            // Assert
            result.Should().Be(7821);
        }
    }
}
