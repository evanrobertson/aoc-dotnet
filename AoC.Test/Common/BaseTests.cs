using Xunit.Extensions.Ordering;

namespace AoC.Test.Common;

public class BaseTests<T1, T2, T3>
    where T1 : IPart, new()
    where T2 : IPart, new()
    where T3 : IInput, new()
{
    private protected string? Part1ExampleResult { get; init; } = "0";
    private protected string? Part1UserResult { get; init; } = "0";
    private protected string? Part2ExampleResult { get; init; } = "0";
    private protected string? Part2UserResult { get; init; } = "0";

    private static T1 Part1 => Activator.CreateInstance<T1>();

    private static T2 Part2 => Activator.CreateInstance<T2>();
    
    private static T3 Input => Activator.CreateInstance<T3>();

    [Fact, Order(1)]
    public void Part1Example()
    {
        Assert.Equal(Part1ExampleResult, Part1.Execute(Input.Example));
    }

    [Fact, Order(2)]
    public void Part1User()
    {
        Assert.Equal(Part1UserResult, Part1.Execute(Input.User));
    }

    [Fact, Order(3)]
    public void Part2Example()
    {
        Assert.Equal(Part2ExampleResult, Part2.Execute(Input.Example));
    }

    [Fact, Order(4)]
    public void Part2User()
    {
        Assert.Equal(Part2UserResult, Part2.Execute(Input.User));
    }
}