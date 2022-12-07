using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._07;

public class Part1 : IPart
{
    public string? Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");
        
        var root = Shared.BuildDirectories(lines);

        return root.AllDirectories
            .Aggregate(0, (acc, x) => x.Size < 100000 ? acc + x.Size : acc)
            .ToString();
    }
}