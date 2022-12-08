using System.Text.RegularExpressions;

namespace AoC.Test.Solutions._2022._05;

public static class Shared
{
    public static IEnumerable<string> GetStacks(string input) =>
        input.Split("\n\n")[0].Split("\n").TakeWhile(x => !x.Trim().StartsWith("1"));

    public static IEnumerable<(int, int, int)> GetMoves(IEnumerable<string> input)
    {
        var regex = new Regex(@"move (\d+) from (\d+) to (\d+)");
        var moves = input.Where(x => x.StartsWith("move"));
        return moves.Select(x => regex.Match(x)).Select(x => (int.Parse(x.Groups[1].Value),
            int.Parse(x.Groups[2].Value), int.Parse(x.Groups[3].Value)));
    }
}