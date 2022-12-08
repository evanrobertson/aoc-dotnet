using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._02;

public class Part1 : IPart
{
    public static string Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");

        var result = new Dictionary<string, int>
        {
            { "A X", 1 + 3 }, { "A Y", 2 + 6 }, { "A Z", 3 + 0 },
            { "B X", 1 + 0 }, { "B Y", 2 + 3 }, { "B Z", 3 + 6 },
            { "C X", 1 + 6 }, { "C Y", 2 + 0 }, { "C Z", 3 + 3 }
        };

        return lines.Aggregate(0, (acc, x) => acc + result[x]).ToString();
    }
}