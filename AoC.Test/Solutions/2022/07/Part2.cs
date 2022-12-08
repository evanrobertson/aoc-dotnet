using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._07;

public class Part2 : IPart
{
    public static string Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");
        
        var root = Shared.BuildDirectories(lines);
        
        var aim = 30000000 - (70000000 - root.Size);

        return root.AllDirectories.Select(x => x.Size)
            .Where(x => x >= aim)
            .Min()
            .ToString();
    }
}