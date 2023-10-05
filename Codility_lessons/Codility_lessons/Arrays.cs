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
        int[] numberOfOccurrences = new int[array.Max() + 1];

        for (int i = 0; i < array.Length; i++)
        {
            numberOfOccurrences[array[i]]++;
        }
        for (int i = 0; i < numberOfOccurrences.Length; i++)
        {
            if(numberOfOccurrences[i] % 2 != 0)
                return i;
        }

        return -1;
        
        // return numberOfOccurrences
        //     .Select((n, index) => (n, index))
        //     .FirstOrDefault(x => x.n % 2 != 0).index;
    }
}