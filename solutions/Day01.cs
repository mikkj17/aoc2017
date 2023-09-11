namespace aoc2017.solutions;

public class Day01
{
    private const int Day = 1;
    private const string Test1 = "1122";
    private const string Test2 = "1212";

    private readonly bool _useInput;
    private readonly Parser _parser;
    public Day01(bool useInput)
    {
        _useInput = useInput;
        _parser = new Parser(day: Day);
    }

    public int SolveFirst() => Solve(Test1, _ => 1);

    public int SolveSecond() => Solve(Test2, count => count / 2);

    private int Solve(string testInput, Func<int, int> indexer)
    {
        var input = _useInput ? _parser.Parse() : testInput;
        var nums = input.Select(e => int.Parse(e.ToString())).ToList();
        return nums.Where((num, i) => num == nums[(i + indexer(nums.Count)) % nums.Count]).Sum();
    }
}
