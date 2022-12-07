using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._03;

public class Part1 : IPart
{
    public string? Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");

        var total = 0;
        
        foreach (var line in lines)
        {
            var start = line[..(line.Length / 2)];
            var end = line[(line.Length / 2)..];

            total += start.Intersect(end)
                .Select(Shared.PriorityForChar)
                .Sum();
        }

        return total.ToString();
    }
}