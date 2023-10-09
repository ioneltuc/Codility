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
        int[] maxSumStartingSlice = new int[a.Length];
        int[] maxSumEndingSlice = new int[a.Length];

        for (int i = a.Length - 2; i > 0; i--)
            maxSumStartingSlice[i] = Math.Max(0, maxSumStartingSlice[i] + a[i]);

        for (int i = 1; i < a.Length - 1; i++)
            maxSumEndingSlice[i] = Math.Max(0, maxSumEndingSlice[i] + a[i]);

        int maxDoubleSliceSum = 0;
        
        for (int i = 0; i < a.Length - 2; i++)
            maxDoubleSliceSum = Math.Max(maxDoubleSliceSum, maxSumStartingSlice[i] + maxSumEndingSlice[i + 2]);

        return maxDoubleSliceSum;
    }
}