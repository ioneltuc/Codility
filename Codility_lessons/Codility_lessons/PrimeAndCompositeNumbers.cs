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

    public static int Flags(int[] mountain)
    {
        bool[] peaks = CreatePeaks(mountain);
        int numberOfPeaks = peaks.Where(x => x == true).Count();

        for (int i = numberOfPeaks; i > 0; i--)
        {
            if (CheckTakeFlags(i, peaks))
                return i;
        }

        return numberOfPeaks;
    }

    private static bool[] CreatePeaks(int[] mountain)
    {
        bool[] peaks = Enumerable.Repeat(false, mountain.Length).ToArray();

        for (int i = 1; i < mountain.Length - 1; i++)
            if (mountain[i] > Math.Max(mountain[i - 1], mountain[i + 1]))
                peaks[i] = true;

        return peaks;
    }

    private static bool CheckTakeFlags(int countToCheck, bool[] mountainPeaks)
    {
        bool[] peaks = mountainPeaks;
        int flags = countToCheck;
        int pos = 0;

        while (pos < peaks.Length && flags > 0)
        {
            if (peaks[pos])
            {
                flags--;
                pos += countToCheck;
            }
            else
            {
                pos++;
            }
        }

        return flags == 0;
    }
}