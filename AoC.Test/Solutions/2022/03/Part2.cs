using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._03;

public class Part2 : IPart
{
    public string? Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");
        var stack = new Stack<string>(lines);

        var total = 0;
        while (stack.Count >= 3)
        {
            total += stack.Pop()
                .Intersect(stack.Pop())
                .Intersect(stack.Pop())
                .Select(Shared.PriorityForChar)
                .Sum();
        }

        return total.ToString();
    }
}