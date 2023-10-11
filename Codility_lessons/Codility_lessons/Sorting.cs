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

    public static int Triangle(int[] array)
    {
        if (array.Length < 3)
            return 0;

        Array.Sort(array);

        //daca tabelul e sortat, automat array[i + 2] + array[i + 1] > array[i]
        //si array[i + 2] + array[i] > array[i + 1]
        //ramane sa verificam daca array[i] + array[i + 1] > array[i + 2]
        for (int i = 0; i < array.Length - 2; i++)
        {
            //echivalent cu array[i] + array[i + 1] > array[i + 2]
            //trecem array[i + i] in dreapta pentru a
            //trece testul cu toate 3 MaxInteger
            if (array[i] > array[i + 2] - array[i + 1])
                return 1;
        }

        return 0;
    }
}