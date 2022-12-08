namespace AoC.Test.Common;

public interface IPart
{
    static IEnumerable<string> ParseInput(string input, string separator) => input.Split(separator);

    static abstract string? Execute(string input);
}