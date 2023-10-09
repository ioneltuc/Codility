namespace Codility_lessons;

public class Arrays
{
    public int[] CyclicRotation(int[] array, int k)
    {
        int[] finalArray = new int[array.Length];
        
        if (array.Length == 0)
            return finalArray;
        
        for (int i = 0; i < k; i++)
        {
            int lastElement = array[array.Length - 1];

            for (int j = 1; j < array.Length; j++)
            {
                array[array.Length - j] = array[array.Length - j - 1];
            }

            array[0] = lastElement;
        }

        Array.Copy(array, finalArray, array.Length);

        return finalArray;
    }
    
    public static int OddOccurrencesInArray(int[] array)
    {
        Dictionary<int, int> occurrences = new Dictionary<int, int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (occurrences.ContainsKey(array[i]))
            {
                int count = occurrences[array[i]];
                count++;
                occurrences[array[i]] = count;
            }
            else
            {
                occurrences.Add(array[i], 1);
            }
        }

        return occurrences.First(x => x.Value % 2 != 0).Key;
    }
}