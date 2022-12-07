namespace AoC.Test.Extensions;

static class Extensions {
    public static IEnumerable<(int Index, T Item)> EnumerateWithIndex<T>(this IEnumerable<T> source) {
        var index = 0;
        foreach (var item in source) {
            yield return (index++, item);
        }
    }
}