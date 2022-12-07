using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._01;

public class Part2 : IPart
{
    public string? Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n\n");

        var totals = new List<int>();

        foreach (var elf in lines)
        {
            var items = elf.Split('\n');
            var total = items.Aggregate(0, (acc, x) => acc + int.Parse(x));
            totals.Add(total);
        }

        totals = totals.OrderDescending().ToList();
        
        return (totals[0] + totals[1] + totals[2]).ToString();
    }
}