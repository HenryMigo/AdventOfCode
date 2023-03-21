using AOC2022.Library;
using FluentAssertions;
using Xunit;

namespace AOC2022.UnitTests
{
    public class Day4Tests
    {
        [Fact]
        public void Day4_Part1_Example()
        {
            // Arrange
            var inputData = "2-4,6-8\r\n2-3,4-5\r\n5-7,7-9\r\n2-8,3-7\r\n6-6,4-6\r\n2-6,4-8".Split("\r\n").ToList();

            // Act
            var result = Day4.Part_One(inputData);

            // Assert
            result.Should().Be(2);
        }

        [Fact]
        public void Day4_Part1()
        {
            // Arrange
            var inputData = File.ReadAllLines("../../../InputData/Day4.txt").ToList();

            // Act
            var result = Day4.Part_One(inputData);

            // Assert
            result.Should().Be(453);
        }
    }
}
