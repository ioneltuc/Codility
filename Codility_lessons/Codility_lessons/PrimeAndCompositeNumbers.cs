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
}