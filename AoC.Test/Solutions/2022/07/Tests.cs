using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._07;

public class Tests : BaseTests<Part1, Part2, Input>
{
    public Tests() : base(new Results(
        part1ExampleResult: "95437",
        part1UserResult: "1432936", 
        part2ExampleResult: "24933642",
        part2UserResult: "272298")) { }
}