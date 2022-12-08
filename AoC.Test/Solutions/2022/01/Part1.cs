using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._01;

public class Part1 : IPart
{
    public static string Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n\n");

        var most = 0;
        foreach (var elf in lines)
        {
            var items = elf.Split('\n');
            var total = items.Aggregate(0, (acc, x) => acc + int.Parse(x));
            if (total > most) most = total;
        }

        return most.ToString();
    }
}