namespace Codility_lessons;

public class Sorting
{
    public static int Distinct(int[] array)
    {
        return array.Distinct().Count();
    }

    public static int MaxProductOfThree(int[] array)
    {
        Array.Sort(array);

        if (array[^1] * array[^2] * array[^3] > array[0] * array[1] * array[^1])
            return array[^1] * array[^2] * array[^3];

        return array[0] * array[1] * array[^1];
    }
}