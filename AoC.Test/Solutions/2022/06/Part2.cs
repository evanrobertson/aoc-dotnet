using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._06;

public class Part2 : IPart
{
    public string? Execute(string input)
    {
        return Shared.FindUniqueRange(input, 14).ToString();
    }
}