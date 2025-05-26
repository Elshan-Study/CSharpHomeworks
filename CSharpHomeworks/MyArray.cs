namespace CSharpHomeworks;

public class MyArray(IEnumerable<int> values) : ICalc, IOutput2
{
    private readonly List<int> _array = [..values];

    public void Add(int value)
    {
        _array.Add(value);
    }
    
    public bool Remove(int value)
    {
        return _array.Remove(value);
    }

    public int Less(int valueToCompare)
    {
        return _array.Count(x => x < valueToCompare);
    }

    public int Greater(int valueToCompare)
    {
        return _array.Count(x => x > valueToCompare);
    }

    public int CountDistinct()
    {
        return _array.Distinct().Count();
    }

    public int EqualToValue(int valueToCompare)
    {
        return _array.Count(x => x == valueToCompare);
    }

    public void Print()
    {
        Console.WriteLine(string.Join(", ", _array));
    }

    public void ShowEven()
    {
        foreach (var item in _array)
        {
            if (item % 2 == 0) Console.Write($"{item} ");
        }
        
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        foreach (var item in _array)
        {
            if (item % 2 != 0) Console.Write($"{item} ");
        }
        
        Console.WriteLine();
    }
}