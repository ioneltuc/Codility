namespace Codility_lessons;

public class CountingElements
{
    public static int PermCheck(int[] array)
    {
        if (array.Length == 1)
        {
            if (array.First() == 1)
                return 1;

            return 0;
        }

        int[] occurrences = new int[array.Max() + 1];

        for (int i = 0; i < array.Length; i++)
            occurrences[array[i]]++;

        for (int i = 1; i < occurrences.Length; i++)
        {
            if (occurrences[i] != 1)
                return 0;
        }

        return 1;
    }

    public static int MissingInteger(int[] array)
    {
        if (array.Any(x => x < 1))
            return 1;

        if (array.Length == 1)
        {
            if (array[0] != 1)
                return array[0] - 1;
        }
        
        int[] arrayNoDuplicates = array.Distinct().ToArray();

        int[] range = Enumerable
            .Range(1, arrayNoDuplicates.Max() - arrayNoDuplicates.Min() + 1)
            .ToArray();

        int[] missingElements = range.Except(arrayNoDuplicates).ToArray();

        int diff = range.Sum() - arrayNoDuplicates.Sum();

        return diff == 0 ? array.Max() + 1 : missingElements.Min();
    }

    public static int FrogRiverOne(int x, int[] fallingLeaves)
    {
        bool isLastLeave = false;
        
        for (int i = 0; i < fallingLeaves.Length; i++)
        {
            int[] potentialResult = new int[i + 1];
            Array.Copy(fallingLeaves, potentialResult, i + 1);

            int[] occurences = new int[potentialResult.Max()];

            for (int j = 0; j < potentialResult.Length; j++)
            {
                if (potentialResult[j] == x)
                    isLastLeave = true;

                occurences[potentialResult[j] - 1]++;
            }

            if (!occurences.Contains(0) && isLastLeave)
                return i;
        }

        return -1;
    }
}