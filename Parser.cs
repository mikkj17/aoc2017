namespace aoc2017;

public class Parser
{
    private readonly string _path;
    public Parser(int day)
    {
        _path = GetPath(day);
    }

    public string Parse()
    {
        return File.ReadAllText(_path);
    }

    public List<string> ParseLines()
    {
        return File.ReadLines(_path).ToList();
    }

    public List<int> ParseLinesToInts()
    {
        return File.ReadLines(_path).Select(int.Parse).ToList();
    }

    private static string GetPath(int day)
    {
        return $"inputs/day{day.ToString().PadLeft(2, '0')}.txt";
    }
}
