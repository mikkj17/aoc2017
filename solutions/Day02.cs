namespace aoc2017.solutions;

public class Day02
{
    private const int Day = 2;
    private const string Test1 = @"5 1 9 5
7 5 3
2 4 6 8";
    private const string Test2 = @"5 9 2 8
9 4 7 3
3 8 6 5";

    private readonly bool _useInput;
    private readonly Parser _parser;
    public Day02(bool useInput)
    {
        _useInput = useInput;
        _parser = new Parser(day: Day);
    }

    public int SolveFirst()
    {
        return Solve(Test1, nums => nums.Max() - nums.Min());
    }

    public int SolveSecond()
    {
        return Solve(Test2, nums =>
        {
            for (var i = 0; i < nums.Count; i++)
            {
                var outer = nums[i];
                for (var j = 0; j < nums.Count; j++)
                {
                    var inner = nums[j];
                    if (i != j && outer % inner == 0)
                    {
                        return outer / inner;
                    }
                }
            }

            throw new InvalidOperationException();
        });
    }

    private int Solve(string testString, Func<List<int>, int> callback)
    {
        var lines = _useInput ? _parser.ParseLines() : testString.Split('\n').ToList();
        return lines.Select(line => callback(line.Split().Select(int.Parse).ToList())).Sum();
    }
}
