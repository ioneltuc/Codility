namespace Codility_lessons;

public class MaximumSliceProblem
{
    public static int MaxProfit(int[] a)
    {
        if (a.Length == 0)
            return 0;

        int maxProfit = int.MinValue;
        int minBoughtPrice = a[0];

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < minBoughtPrice)
            {
                minBoughtPrice = a[i];
            }
            else
            {
                int profit = a[i] - minBoughtPrice;

                if (profit > maxProfit)
                    maxProfit = profit;
            }
        }

        return maxProfit < 0 ? 0 : maxProfit;
    }

    public static int MaxSliceSum(int[] a)
    {
        int maxEnding = 0;
        int maxSlice = 0;

        if (a.All(x => x < 0))
            return a.Max();

        foreach (var item in a)
        {
            maxEnding = int.Max(0, maxEnding + item);
            maxSlice = int.Max(maxSlice, maxEnding);
        }

        return maxSlice;
    }

    public static int MaxDoubleSliceSum(int[] a)
    {
        int[] slice1 = new int[a.Length];
        int[] slice2 = new int[a.Length];
        int maxDoubleSliceSum = 0;

        for (int i = 1; i < slice1.Length - 1; i++)
            slice1[i] = Math.Max(0, slice1[i - 1] + a[i]);

        for (int i = a.Length - 2; i > 0; i--)
            slice2[i] = Math.Max(0, slice2[i + 1] + a[i]);

        for (int i = 1; i < a.Length - 1; i++)
            maxDoubleSliceSum = Math.Max(maxDoubleSliceSum, slice1[i - 1] + slice2[i + 1]);

        return maxDoubleSliceSum;
    }
}