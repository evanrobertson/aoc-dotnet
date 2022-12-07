using System.Text.RegularExpressions;
using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._05;

public class Part1 : IPart
{
    private static IEnumerable<string> GetStacks(string input) =>
        input.Split("\n\n")[0].Split("\n").TakeWhile(x => !x.Trim().StartsWith("1"));

    private static IEnumerable<(int, int, int)> GetMoves(IEnumerable<string> input)
    {
        var regex = new Regex(@"move (\d+) from (\d+) to (\d+)");
        var moves = input.Where(x => x.StartsWith("move"));
        return moves.Select(x => regex.Match(x)).Select(x => (int.Parse(x.Groups[1].Value),
            int.Parse(x.Groups[2].Value), int.Parse(x.Groups[3].Value)));
    }
    
    public string? Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");
        var stackInput = GetStacks(input);
        var moves = GetMoves(lines);

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