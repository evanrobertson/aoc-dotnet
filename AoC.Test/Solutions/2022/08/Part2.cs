using System.Drawing;
using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._08;

public class Part2 : IPart
{
    private static int DirectionToIndex(Direction direction) => direction switch
    {
        { } when direction == Shared.Up => 0,
        { } when direction == Shared.Left => 1,
        { } when direction == Shared.Down => 2,
        { } when direction == Shared.Right => 3,
        _ => -1
    };

    public static string? Execute(string input)
    {
        var lines = IPart.ParseInput(input, "\n");

        var grid = lines.Select((r, y) =>
            r.Select((c, x) => new Tree { Value = int.Parse(c.ToString()), X = x, Y = y }).ToList()).ToList();
        var gridSize = new Size(grid[0].Count, grid.Count);

        foreach (var tree in grid.SelectMany(row => row))
        {
            if (tree.IsOuter(gridSize)) continue;

            foreach (var direction in Shared.AllDirections)
            {
                var current = tree;
                while (Shared.GetTree(direction, current, grid, out var nextTree))
                {
                    tree.Trees[DirectionToIndex(direction)]++;
                    if (nextTree.Value >= tree.Value) break;
                    current = nextTree;
                }
            }
        }

        return grid.SelectMany(x => x.Select(i => i.Trees.Aggregate(1, (acc, item) => acc * item))).Max().ToString();
    }
}