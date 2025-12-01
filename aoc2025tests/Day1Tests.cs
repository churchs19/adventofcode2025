using Aoc2025.Utilities;
using Aoc2025.Days;

using NSubstitute;

namespace Aoc2025Tests;

[TestFixture]
public class Day1Tests
{
    [Test]
    public void Part1_ReturnsExpected()
    {
        // Arrange
        string filename = "1/input.txt";
        var mockUtilities = Substitute.For<IFileUtilities>();
        mockUtilities.ReadFile(filename).Returns(["L68",
            "L30",
            "R48",
            "L5",
            "R60",
            "L55",
            "L1",
            "L99",
            "R14",
            "L82"]);
        var day1 = new Day1(mockUtilities);

        // Act
        var result = day1.Part1(filename);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Part2_ReturnsExpected()
    {
        // Arrange
        var mockUtilities = Substitute.For<IFileUtilities>();
        var day1 = new Day1(mockUtilities);
        string filename = "input-test2.txt";
        mockUtilities.ReadFile(filename).Returns(["L68",
            "L30",
            "R48",
            "L5",
            "R60",
            "L55",
            "L1",
            "L99",
            "R14",
            "L82"]);

        // Act
        var result = day1.Part2(filename);

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }
}