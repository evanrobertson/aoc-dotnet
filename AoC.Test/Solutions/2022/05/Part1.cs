using System.Text.RegularExpressions;
using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._05;

public class Part1 : IPart
{
   public static string Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");
        var stackInput = Shared.GetStacks(input);
        var moves = Shared.GetMoves(lines);

        var stacks = new List<Stack<char>>();

        foreach (var line in stackInput.Reverse())
        {
            if (!line.Trim().StartsWith('[')) break;

            for (var i = 0; i < line.Length; i++)
            {
                var c = line[i];
                if (c is ' ' or '[' or ']') continue;

                var stackI = i / 4;
                while (stacks.Count <= stackI)
                {
                    stacks.Add(new Stack<char>());
                }

                stacks[stackI].Push(c);
            }
        }

        foreach (var (amount, from, to) in moves)
        {
            for (var i = 0; i < amount; i++)
            {
                var v = stacks[from - 1].Pop();
                stacks[to - 1].Push(v);
            }
        }

        return stacks.Aggregate("", (current, stack) => current + stack.Peek()).ToString();
    }
}