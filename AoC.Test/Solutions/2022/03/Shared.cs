namespace AoC.Test.Solutions._2022._03;

public static class Shared
{
    public static int PriorityForChar(char c)
    {
        var i = (int)c;
        return i >= 97 ? i - 96 : i - 38;
    }
}