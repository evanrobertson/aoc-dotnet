using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._07;

public class Part2 : IPart
{
    public string? Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");
        
        var root = Shared.BuildDirectories(lines);
        
        var aim = 30000000 - (70000000 - root.Size());

        return Shared.GetSizes(x => x >= aim, root)
            .Order()
            .First()
            .ToString();
    }
}