using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._08;

public class Tests : BaseTests<Part1, Part2, Input>
{
    public Tests() : base(
        new Results(
        part1ExampleResult: "21",
        part1UserResult: "1849", 
        part2ExampleResult: "8",
        part2UserResult: "201600")) { }
}