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

    public int[] CountSemiprimes(int n, int[] p, int[] q)
    {
        int[] result = new int[p.Length];
        PrimeNumbersFiller.Fill(n / 2);
        int[] primeNumbers = PrimeNumbersFiller.PrimeNumbers.ToArray();
        List<int> semiprimes = new List<int>();
        int productOfTwoPrimes = 0;
        
        for (int i = 0; i < primeNumbers.Length; i++)
        {
            for (int j = 0; j < primeNumbers.Length; j++)
            {
                productOfTwoPrimes = primeNumbers[i] * primeNumbers[j];

                if (productOfTwoPrimes > n)
                    break;
                
                semiprimes.Add(productOfTwoPrimes);
            }
        }

        semiprimes = semiprimes.Distinct().Order().ToList();

        for (int i = 0; i < p.Length; i++)
        {
            int from = semiprimes.First(x => x >= p[i]);
            int to = semiprimes.Last(x => x <= q[i]);
            int fromIndex = semiprimes.IndexOf(from);
            int toIndex = semiprimes.IndexOf(to);

            if (fromIndex > toIndex)
                result[i] = 0;
            else
                result[i] = semiprimes.Skip(fromIndex).Take(toIndex + 1).Count();
        }
        
        return result;
    }
}