namespace AoC.Test.Solutions._2022._07;

public static class Shared
{
    public static Directory BuildDirectories(IEnumerable<string> lines)
    {
        var commands = lines.Where(x => !x.StartsWith("$ ls"));
        
        var root = new Directory { Name = "/" };
        var current = root;
        
        foreach (var command in commands)
        {
            if (command.StartsWith("$ cd"))
            {
                var dirName = command.Replace("$ cd", "").Trim();
                current = dirName switch
                {
                    ".." => current.Parent ?? root,
                    "/" => root,
                    _ => current.SubDirectories.First(x => x.Name == dirName)
                };

                continue;
            }
            
            if (command.StartsWith("dir"))
            {
                var name = command.Split(" ")[1];
                if (current.SubDirectories.Exists(x => x.Name == name)) continue;

                current.SubDirectories.Add(new Directory { Name = name, Parent = current});
                continue;
            }
            
            var fileSize = command.Split(" ")[0];
            current.FileSize += int.Parse(fileSize);

        }

        return root;
    }
}

public class Directory
{
    public string Name { get; init; } = string.Empty;
    public Directory? Parent { get; init; }
    public List<Directory> SubDirectories { get; } = new();

    public int FileSize { get; set; }
    
    public IEnumerable<Directory> AllDirectories =>
        SubDirectories.Concat(SubDirectories.SelectMany(x => x.AllDirectories));
    
    public int Size => FileSize + SubDirectories.Sum(x => x.Size);
}