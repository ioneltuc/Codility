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

    private static bool IsSliceDistinct(int[] slice)
    {
        return slice.Length == slice.Distinct().Count();
    }

    public static int CountTriangles(int[] a)
    {
        Array.Sort(a);
        
        int trianglesCount = 0;

        for (int i = 0; i < a.Length; i++)
        {
            int k = i + 2;
            
            for (int j = i + 1; j < a.Length; j++)
            {
                while (k < a.Length && a[i] + a[j] > a[k])
                    k++;

                trianglesCount += k - j - 1;
            }
        }

        return trianglesCount;
    }

    public static int MinAbsSumOfTwo(int[] a)
    {
        Array.Sort(a);
        
        int front = 0;
        int back = a.Length - 1;
        int minAbsSumOfTwo = int.MaxValue;
        int currentSum = 0;
        int currentAbsSum = 0;
        
        while (front <= back)
        {
            currentSum = a[front] + a[back];
            currentAbsSum = Math.Abs(currentSum);

            if (currentAbsSum < minAbsSumOfTwo)
                minAbsSumOfTwo = currentAbsSum;

            if (currentSum < 0)
                front++;
            else if (currentSum > 0)
                back--;
            else if (currentSum == 0)
                return 0;
        }

        return minAbsSumOfTwo;
    }
}