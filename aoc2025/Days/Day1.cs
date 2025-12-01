using Aoc2025.Utilities;

namespace Aoc2025.Days;

public class Day1(IFileUtilities utilities) : Day(utilities)
{
    public override long Part1(string filename)
    {
        var inputLines = _utilities.ReadFile(filename);

        var currentValue = 50;
        var result = 0;

        foreach (var line in inputLines)
        {
            // Process each line
            var (count, remainder) = MoveDial(line, currentValue);
            currentValue = remainder;

            if (currentValue == 0)
            {
                result++;
            }
        }

        return result;
    }

    public override long Part2(string filename)
    {
        var inputLines = _utilities.ReadFile(filename);

        var currentValue = 50;
        var result = 0;

        foreach (var line in inputLines)
        {
            // Process each line
            var (count, remainder) = MoveDial(line, currentValue);
            currentValue = remainder;
            if (remainder == 0) count++;
            result += count;
        }

        return result;
    }

    private (int count, int remainder) MoveDial(string instruction, int currentValue)
    {
        var direction = instruction[0];
        var amount = int.Parse(instruction[1..]);

        return direction switch
        {
            'L' => (Math.Abs((currentValue + amount) / 100), (currentValue + amount) % 100),
            'R' => (Math.Abs((currentValue - amount) / 100), (currentValue - amount) % 100),
            _ => throw new ArgumentException("Invalid direction")
        };
    }
}