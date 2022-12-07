using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._02;

public class Part2 : IPart
{
    public string? Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");
        
        var result = new Dictionary<string, int>
        {
            { "A X", 3 + 0 }, { "A Y", 1 + 3 }, { "A Z", 2 + 6 },
            { "B X", 1 + 0 }, { "B Y", 2 + 3 }, { "B Z", 3 + 6 },
            { "C X", 2 + 0 }, { "C Y", 3 + 3 }, { "C Z", 1 + 6 }
        };

        return lines.Aggregate(0, (acc, x) => acc + result[x]).ToString();
    }
}