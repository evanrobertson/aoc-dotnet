using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._06;

public class Tests : BaseTests<Part1, Part2, Input>
{
    public Tests() : base(new Results(
        part1ExampleResult: "6",
        part1UserResult: "1912", 
        part2ExampleResult: "23",
        part2UserResult: "2122")) { }
}