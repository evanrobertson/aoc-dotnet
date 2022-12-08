using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._02;

public class Tests : BaseTests<Part1, Part2, Input>
{
    public Tests() : base(new Results(
        part1ExampleResult: "15",
        part1UserResult: "12679", 
        part2ExampleResult: "12",
        part2UserResult: "14470")) { }
}