namespace aoc2017.solutions;

public class Day03
{
    private const int Day = 3;
    private const string Test1 = "23";
    private const string Test2 = "";

    private readonly bool _useInput;
    private readonly Parser _parser;
    public Day03(bool useInput)
    {
        _useInput = useInput;
        _parser = new Parser(day: Day);
    }

    public int SolveFirst()
    {
        var input = _useInput ? _parser.Parse() : Test1;
        var inputValue = int.Parse(input);

        var layerIndex = 0;
        var cornerValue = 1;

        while (inputValue > cornerValue) {
            layerIndex++;
            cornerValue = (int) Math.Pow(2 * layerIndex + 1, 2);
        }
        
        var sideLength = 2 * layerIndex;
        var offset = cornerValue - inputValue;
        var positionWithinSide = offset % sideLength;
        var distanceFromCorner = Math.Abs((sideLength / 2) - (positionWithinSide % (sideLength / 2)));

        return layerIndex + distanceFromCorner;
    }

    public int SolveSecond()
    {
        var grid = new Dictionary<Tuple<int, int>, int>
        {
            { new Tuple<int, int>(0, 0), 1 },
        };

        return 0;
    }
}
