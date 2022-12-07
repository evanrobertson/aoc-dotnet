using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._04;

public class Part2 : IPart
{
    public string? Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");
        var ranges = lines.Select(
            l => l.Split(',')
                .SelectMany(x => x.Split('-').Select(int.Parse))
                .ToList());

        var total = ranges.Count(range => 
            (range[0] >= range[2] && range[0] <= range[3]) || (range[0] <= range[2] && range[1] >= range[2]));

        return total.ToString();
    }
}