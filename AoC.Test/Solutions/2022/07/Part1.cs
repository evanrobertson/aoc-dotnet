using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._07;

public class Part1 : IPart
{
    public string? Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");
        
        var root = Shared.BuildDirectories(lines);

        return Shared.GetSizes(x => x < 100000, root).Sum().ToString();
    }
}