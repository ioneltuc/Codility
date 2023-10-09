namespace Codility_lessons;

public class Leader
{
    public static int Dominator(int[] a)
    {
        if (a.Length == 0)
            return -1;

        int[] array = new int[a.Length];
        
        Array.Copy(a, array, a.Length);
        Array.Sort(array);

        int middleIndex = array.Length / 2;
        int candidateDominator = array[middleIndex];
        int occurrences = array.Where(x => x == candidateDominator).Count();

        if (occurrences > middleIndex)
            return Array.IndexOf(a, candidateDominator);

        return -1;
    }
}