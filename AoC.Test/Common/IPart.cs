namespace AoC.Test.Common;

public interface IPart
{
    static IEnumerable<string> ParseInput(string input, string separator) => input.Split(separator);

    string? Execute(string input);
}