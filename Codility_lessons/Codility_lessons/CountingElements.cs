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
}