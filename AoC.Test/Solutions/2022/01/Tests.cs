using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._01;

public class Tests : BaseTests<Part1, Part2, Input>
{
    public Tests() : base(new Results(
        part1ExampleResult: "24000",
        part1UserResult: "70509", 
        part2ExampleResult: "45000",
        part2UserResult: "208567")) { }
}