namespace Codility_lessons;

public class SieveOfEratosthenes
{
    public static int[] CountNonDivisible(int[] a)
    {
        int[] result = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            int nonDivisorsCount = 0;

            for (int j = 0; j < a.Length; j++)
            {
                if (i == j)
                    continue;
                
                if (a[i] % a[j] != 0)
                {
                    nonDivisorsCount++;
                }
            }

            result[i] = nonDivisorsCount;
        }

        return result;
    }
}