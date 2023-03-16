using FluentAssertions;
using Xunit;

namespace AOC2022.UnitTests
{
    public class Day1Tests
    {
        [Fact]
        public void Day1_Part1_Example()
        {
            var inputData = "1000\r\n2000\r\n3000\r\n\r\n4000\r\n\r\n5000\r\n6000\r\n\r\n7000\r\n8000\r\n9000\r\n\r\n10000".Split("\r\n").ToList();

            inputData = inputData.Select(x => x.Replace("\r", string.Empty)).ToList();

            var result = Day1.Part_One(inputData);

            result.Should().Be(24000);
        }

        [Fact]
        public void Day1_Part1() {
            var inputData = File.ReadAllLines("../../../InputData/Day1.txt").ToList();

            var result = Day1.Part_One(inputData);

            result.Should().Be(72017);
        }

        [Fact]
        public void Day1_Part2_Example()
        {
            var inputData = "1000\r\n2000\r\n3000\r\n\r\n4000\r\n\r\n5000\r\n6000\r\n\r\n7000\r\n8000\r\n9000\r\n\r\n10000".Split("\r\n").ToList();

            inputData = inputData.Select(x => x.Replace("\r", string.Empty)).ToList();

            var result = Day1.Part_Two(inputData);

            result.Should().Be(45000);
        }

        [Fact]
        public void Day1_Part2()
        {
            var inputData = File.ReadAllLines("../../../InputData/Day1.txt").ToList();

            var result = Day1.Part_Two(inputData);

            result.Should().Be(212520);
        }
    }
}