using System.Drawing;
using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._08;

public class Part1 : IPart
{
    public static string Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");

        var grid = lines.Select((r, y) =>
            r.Select((c, x) => new Tree { Value = int.Parse(c.ToString()), X = x, Y = y }).ToList()).ToList();
        var gridSize = new Size(grid[0].Count, grid.Count);

        foreach (var tree in grid.SelectMany(row => row))
        {
            if (tree.IsOuter(gridSize)) tree.Seen = true;

            foreach (var direction in Shared.AllDirections)
            {
                var current = tree;
                while (Shared.GetTree(direction, current, grid, out var nextTree))
                {
                    if (nextTree.Value >= tree.Value) break;
                    if (nextTree.IsOuter(gridSize)) tree.Seen = true;
                    current = nextTree;
                }
            }
        }

        return grid.SelectMany(x => x)
            .Count(x => x.Seen)
            .ToString();
    }
}