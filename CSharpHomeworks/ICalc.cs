namespace CSharpHomeworks;

public interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}