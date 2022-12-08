using Xunit.Extensions.Ordering;

namespace AoC.Test.Common;

public abstract class BaseTests<TPart1, TPart2, TInput>
    where TPart1 : IPart
    where TPart2 : IPart
    where TInput : IInput
{
    private readonly Results _results;

    protected BaseTests(Results results)
    {
        _results = results;
    }

    [Fact, Order(1)]
    public void Part1Example()
    {
        Assert.Equal(_results.Part1ExampleResult, TPart1.Execute(TInput.Example));
    }

    [Fact, Order(2)]
    public void Part1User()
    {
        Assert.Equal(_results.Part1UserResult, TPart1.Execute(TInput.User));
    }

    [Fact, Order(3)]
    public void Part2Example()
    {
        Assert.Equal(_results.Part2ExampleResult, TPart2.Execute(TInput.Example));
    }

    [Fact, Order(4)]
    public void Part2User()
    {
        Assert.Equal(_results.Part2UserResult, TPart2.Execute(TInput.User));
    }
}