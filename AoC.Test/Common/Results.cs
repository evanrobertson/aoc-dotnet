namespace AoC.Test.Common;

public class Results
{
    public Results(string part1ExampleResult, string part1UserResult, string part2ExampleResult,
        string part2UserResult) => (Part1ExampleResult, Part1UserResult, Part2ExampleResult, Part2UserResult) =
        (part1ExampleResult, part1UserResult, part2ExampleResult, part2UserResult);

    public string Part1ExampleResult { get; init; }
    public string Part1UserResult { get; init; }
    public string Part2ExampleResult { get; init; }
    public string Part2UserResult { get; init; }
}