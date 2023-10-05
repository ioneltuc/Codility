namespace Codility_lessons;

public class TimeComplexity
{
    public static int FrogJmp(int x, int y, int d)
    {
        double distance = y - x;
        return (int)Math.Ceiling(distance / d);
    }

    public static int PermMissingElem(int[] array)
    {
        if (array.Length == 0)
            return 1;

        if (array.Length == 1 && array.First() == 1)
            return array.First() + 1;

        if (array.Length == 1 && array.First() != 1)
            return array.First() - 1; 

        Array.Sort(array);

        if (array[0] != 1)
            return 1;
        
        var missingElem = Enumerable
            .Range(array.First(), array.Length)
            .Except(array.ToList());

        return missingElem.Count() == 0 ? array.Max() + 1 : missingElem.First();
    }
}