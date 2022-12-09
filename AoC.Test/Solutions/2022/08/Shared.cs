using System.Drawing;

namespace AoC.Test.Solutions._2022._08;

internal record Direction(int X, int Y);



public class Tree
{
    public int Value { get; init; }
        
    public bool Seen { get; set; }
    
    public List<int> Trees = new () {0,0,0,0};
        
    public int X { get; init; }
        
    public int Y { get; init; }

    public bool IsOuter(Size gridSize) => X == 0 || Y == 0 || X == gridSize.Width - 1 || Y == gridSize.Height - 1;
}

public static class Shared
{
    internal static readonly Direction Up = new(0, -1);
    internal static readonly Direction Left = new(-1, 0);
    internal static readonly Direction Down = new(0, 1);
    internal static readonly Direction Right = new(1, 0);

    internal static readonly List<Direction> AllDirections = new() { Up, Left, Down, Right };
    
    internal static bool GetTree(Direction direction, Tree currentTree, List<List<Tree>> allTrees, out Tree? tree)
    {
        tree = default;
        
        var (x, y) = (currentTree.X + direction.X, currentTree.Y + direction.Y);
        if (x < 0 || y < 0) return false;
        if (x >= allTrees[0].Count || y >= allTrees.Count ) return false;

        tree = allTrees[y][x];
        return true;
    }
}