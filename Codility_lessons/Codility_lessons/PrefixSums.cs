namespace Codility_lessons;

public class PrefixSums
{
    public static int PassingCars(int[] cars)
    {
        int goingEstCars = 0;
        int passingCars = 0;

        for (int i = 0; i < cars.Length; i++)
        {
            if (cars[i] == 0)
                goingEstCars++;

            if (cars[i] == 1)
                passingCars += goingEstCars;

            if (passingCars > 1000000000)
                return -1;
        }

        return passingCars;
    }

    public static int CountDiv(int a, int b, int k)
    {
        // int divisible = 0;
        //
        // for (int i = a; i <= b; i++)
        // {
        //     if (i % k == 0)
        //     {
        //         divisible++;
        //     }
        // }
        //
        // return divisible;

        if (a % k == 0)
            return (b / k) - (a / k) + 1;

        return (b / k) - (a / k);
    }

    public static int[] GenomicRangeQuery(string s, int[] p, int[] q)
    {
        int[] result = new int[p.Length];

        for (int i = 0; i < result.Length; i++)
        {
            string nucleotides = s.Substring(p[i], q[i] - p[i] + 1);

            char nucleotide = nucleotides.Min();

            switch (nucleotide)
            {
                case 'A':
                    result[i] = 1;
                    break;
                case 'C':
                    result[i] = 2;
                    break;
                case 'G':
                    result[i] = 3;
                    break;
                case 'T':
                    result[i] = 4;
                    break;
            }
        }

        return result;
    }

    public static int MinAvgTwoSlice(int[] array)
    {
        double minAvg = double.MaxValue;
        int startingPos = 0;

        for (int i = 0; i < array.Length - 2; i++)
        {
            int sumOfTwo = array[i] + array[i + 1];
            int sumOfThree = array[i] + array[i + 1] + array[i + 2];

            if (sumOfThree / 3.0 < minAvg)
            {
                minAvg = sumOfThree / 3.0;
                startingPos = i;
            }

            if (sumOfTwo / 2.0 < minAvg)
            {
                minAvg = sumOfTwo / 2.0;
                startingPos = i;
            }
        }

        if ((array[^1] + array[^2]) / 2.0 < minAvg)
        {
            startingPos = array.Length - 2;
        }

        return startingPos;
    }
}