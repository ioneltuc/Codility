namespace Codility_lessons;

public class SieveOfEratosthenes
{
    public static int[] CountNonDivisible(int[] a)
    {
        // int[] result = new int[a.Length];
        //
        // for (int i = 0; i < a.Length; i++)
        // {
        //     int nonDivisorsCount = 0;
        //
        //     for (int j = 0; j < a.Length; j++)
        //     {
        //         if (i == j)
        //             continue;
        //         
        //         if (a[i] % a[j] != 0)
        //         {
        //             nonDivisorsCount++;
        //         }
        //     }
        //
        //     result[i] = nonDivisorsCount;
        // }
        //
        // return result;

        int[] occurrences = new int[a.Max() + 1];
        
        for (int i = 0; i < a.Length; i++)
        {
            occurrences[a[i]]++;
        }

        int[] result = new int[a.Length];
        
        for (int i = 0; i < a.Length; i++)
        {
            int divisorsCount = 0;
            int k = 1;
            
            while (k * k <= a[i])
            {
                if (a[i] % k == 0)
                {
                    divisorsCount += occurrences[k];

                    if (a[i] / k != k)
                        divisorsCount += occurrences[a[i] / k];
                }

                k++;
            }

            result[i] = a.Length - divisorsCount;
        }

        return result;
    }
}