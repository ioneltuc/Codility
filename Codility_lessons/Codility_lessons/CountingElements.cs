namespace Codility_lessons;

public class CountingElements
{
    public static int PermCheck(int[] array)
    {
        if(array.Length != array.Max())
            return 0;

        List<int> permutation = Enumerable
            .Range(1, array.Max())
            .ToList();

        if (array.Distinct().Count() != array.Length || permutation.Except(array).Any())
            return 0;

        return 1;
    }

    public static int MissingInteger(int[] array)
    {
        array = array.Where(x => x > 0).Distinct().ToArray();

        Array.Sort(array);

        int smallestInteger = 1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == smallestInteger)
                smallestInteger++;
            else
                break;
        }

        return smallestInteger;
    }

    public static int FrogRiverOne(int x, int[] fallingLeaves)
    {
        int[] requiredLeaves = Enumerable.Range(1, x).ToArray();

        HashSet<int> currentLeaves = new HashSet<int>();

        for (int i = 0; i < fallingLeaves.Length; i++)
        {
            currentLeaves.Add(fallingLeaves[i]);

            if (currentLeaves.Count < requiredLeaves.Length)
                continue;

            if (!requiredLeaves.Except(currentLeaves).Any())
                return i;
        }

        return -1;
    }

    public static int[] MaxCounters(int n, int[] array)
    {
        int[] counters = new int[n];
        int currentMaxCounter = 0;
        int lastMaxCounter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > n)
            {
                lastMaxCounter = currentMaxCounter;
            }
            else
            {
                if (counters[array[i] - 1] < lastMaxCounter)
                    counters[array[i] - 1] = lastMaxCounter;

                counters[array[i] - 1]++;

                currentMaxCounter = Math.Max(counters[array[i] - 1], currentMaxCounter);
            }
        }

        for (int i = 0; i < counters.Length; i++)
            if (counters[i] < lastMaxCounter)
                counters[i] = lastMaxCounter;

        return counters;
    }
}