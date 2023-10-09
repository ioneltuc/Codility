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
}