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
}