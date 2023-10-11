namespace Codility_lessons;

public class CaterpillarMethod
{
    public static int AbsDistinct(int[] a)
    {
        HashSet<int> absoluteDistinctValues = new HashSet<int>();

        foreach (var item in a)
        {
            if (item == int.MaxValue || item == int.MinValue)
            {
                absoluteDistinctValues.Add((int)Math.Abs((long)item));
                continue;
            }
            
            absoluteDistinctValues.Add(Math.Abs(item));
        }

        return absoluteDistinctValues.Count();
    }
}