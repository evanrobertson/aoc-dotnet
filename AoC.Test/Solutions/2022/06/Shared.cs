namespace AoC.Test.Solutions._2022._06;

public static class Shared
{
    public static int? FindUniqueRange(string input, int length)
    {
        var queue = new Queue<char>();

        foreach (var (index, item) in input.EnumerateWithIndex())
        {
            if (queue.Count >= length) queue.Dequeue();
            
            queue.Enqueue(item);

            var hash = new HashSet<char>(queue);
            if (hash.Count == length) return index + 1;
        }

        return null;
    }
}