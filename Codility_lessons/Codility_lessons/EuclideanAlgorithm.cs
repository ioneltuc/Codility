namespace Codility_lessons;

public class EuclideanAlgorithm
{
    public static int ChocolatesByNumbers(int n, int m)
    {
        return n / GreatestCommonDivisor(n, m);
    }

    private static int GreatestCommonDivisor(int a, int b)
    {
        if (a % b == 0)
            return b;
        else
            return GreatestCommonDivisor(b, a % b);
    }

    public static int CommonPrimeDivisors(int[] a, int[] b)
    {
        int pairsWithSameDivisors = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == b[i])
            {
                pairsWithSameDivisors++;
                continue;
            }

            if (a[i] == 1 || b[i] == 1)
                continue;

            int gcd = GreatestCommonDivisor(a[i], b[i]);
            int newA = a[i] / gcd;
            int newB = b[i] / gcd;

            if (!PerformUntilEqualOne(newA, gcd))
                continue;

            if (!PerformUntilEqualOne(newB, gcd))
                continue;

            pairsWithSameDivisors++;
        }

        return pairsWithSameDivisors;
    }

    private static bool PerformUntilEqualOne(int n, int gcd)
    {
        while (n != 1)
        {
            int euclid = GreatestCommonDivisor(n, gcd);

            if (euclid == 1)
                return false;

            n = n / euclid;
        }

        return true;
    }
}