using AOC2022.Library;
using FluentAssertions;
using Xunit;

namespace AOC2022.UnitTests
{
    public class Day2Tests
    {
        [Fact]
        public void Day2_Part1_Example()
        {
            // Arrange
            var inputData = "A Y\r\nB X\r\nC Z".Split("\r\n").ToList();

            // Act
            var score = Day2.Part_One(inputData);

            // Assert
            score.Should().Be(15);
        }

        [Fact]
        public void Day2_Part1()
        {
            // Arrange
            var inputData = File.ReadAllLines("../../../InputData/Day2.txt");

            // Act
            var score = Day2.Part_One(inputData);

            // Assert
            score.Should().Be(15632);
        }

        [Fact]
        public void Day2_Part2_Example()
        {
            // Arrange
            var inputData = "A Y\r\nB X\r\nC Z".Split("\r\n").ToList();

            // Act
            var score = Day2.Part_Two(inputData);

            // Assert
            score.Should().Be(12);
        }

        [Fact]
        public void Day2_Part2()
        {
            // Arrange
            var inputData = File.ReadAllLines("../../../InputData/Day2.txt");

            // Act
            var score = Day2.Part_Two(inputData);

            // Assert
            score.Should().Be(14416);
        }
    }
}
