using AoC.Test.Common;

namespace AoC.Test.Solutions._2022._04;

public class Tests : BaseTests<Part1, Part2, Input>
{
    public Tests() : base(new Results(
        part1ExampleResult: "2",
        part1UserResult: "487", 
        part2ExampleResult: "4",
        part2UserResult: "849")) { }
}