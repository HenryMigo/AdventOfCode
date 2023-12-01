using AOC2023.Library;
using FluentAssertions;

namespace AOC2023.UnitTests;

public class DayOneTests
{
    [Fact]
    public async Task ExampleDayOnePartOne_WhenPartOne_Then142()
    {
        // Arrange
        var dayOne = new DayOne();
        
        // Act
        var result = await dayOne.PartOneAsync("ExampleDayOnePartOne");

        // Assert
        result.Should().Be(142);
    }
    
    [Fact]
    public async Task DayOnePartOne_WhenPartOne_Then54644()
    {
        // Arrange
        var dayOne = new DayOne();
        
        // Act
        var result = await dayOne.PartOneAsync("DayOne");

        // Assert
        result.Should().Be(54644);
    }
    
    [Fact]
    public async Task ExampleDayOnePartTwo_WhenPartOne_Then281()
    {
        // Arrange
        var dayOne = new DayOne();
        
        // Act
        var result = await dayOne.PartTwoAsync("ExampleDayOnePartTwo");

        // Assert
        result.Should().Be(281);
    }
    
    [Fact]
    public async Task DayOnePartTwo_WhenPartOne_Then53348()
    {
        // Arrange
        var dayOne = new DayOne();
        
        // Act
        var result = await dayOne.PartTwoAsync("DayOne");

        // Assert
        result.Should().Be(53348);
    }
}