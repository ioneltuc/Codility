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
    
    public static int CountDistinctSlices(int m, int[] a)
    {
        int front = 0;
        int back = 0;
        int distinctSlicesCount = 0;
        
        while (front <= back && front < a.Length)
        {
            int sliceLength = back - front + 1;
            int[] slice = new int[sliceLength];
            Array.Copy(a, front, slice, 0, sliceLength); 
            
            if (IsSliceDistinct(slice))
            {
                distinctSlicesCount++;
                back++;

                if (back >= a.Length)
                {
                    front++;
                    back = front;
                }
            }
            else
            {
                front++;
                back = front;
            }
        }

        return distinctSlicesCount;
    }

    public static bool IsSliceDistinct(int[] slice)
    {
        return slice.Length == slice.Distinct().Count();
    }
}