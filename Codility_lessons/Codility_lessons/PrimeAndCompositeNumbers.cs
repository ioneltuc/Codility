namespace Codility_lessons;

public class PrimeAndCompositeNumbers
{
    public static int CountFactors(int n)
    {
        int i = 1;
        int factorsCount = 0;

        while (i * i < n)
        {
            if (n % i == 0)
                factorsCount += 2;

            i++;
        }

        if (i * i == n)
            factorsCount++;

        return factorsCount;
    }

    public static int MinPerimeterRectangle(int n)
    {
        int minPerimeter = int.MaxValue;
        int perimeter = 0;
        int i = 1;

        while (i * i <= n)
        {
            if (n % i == 0)
                perimeter = CalculatePerimeter(i, n / i);

            if (perimeter < minPerimeter)
                minPerimeter = perimeter;

            i++;
        }

        return minPerimeter;
    }

    private static int CalculatePerimeter(int a, int b)
    {
        return 2 * (a + b);
    }

    public int Flags(int[] mountain)
    {
        List<Peak> peaks = new List<Peak>();
        
        for (int i = 1; i < mountain.Length; i++)
        {
            if (mountain[i] > mountain[i - 1] && mountain[i] > mountain[i + 1])
            {
                var peak = new Peak(mountain[i], i);
                peaks.Add(peak);
            }
        }

        return 0;
    }

    private class Peak
    {
        private int _height;
        private int _index;
        
        public Peak(int height, int index)
        {
            _height = height;
            _index = index;
        }

        public int GetHeight()
        {
            return _height;
        }

        public int GetIndex()
        {
            return _index;
        }
    }
}