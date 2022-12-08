using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._03;

public class Tests : BaseTests<Part1, Part2, Input>
{
    public Tests() : base(new Results(
        part1ExampleResult: "157",
        part1UserResult: "8039", 
        part2ExampleResult: "70",
        part2UserResult: "2510")) { }
}