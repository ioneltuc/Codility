namespace Codility_lessons;

public class Iterations
{
    public static int BinaryGap(int n)
    {
        string binaryRepresentation = Convert.ToString(n, 2);
        int longestGap = 0;
        int actualGap = 0;

        for (int i = 0; i < binaryRepresentation.Length; i++)
        {
            if (binaryRepresentation[i] == '1')
            {
                if (actualGap > longestGap)
                    longestGap = actualGap;

                actualGap = 0;
                continue;
            }
            else if (binaryRepresentation[i] == '0')
            {
                actualGap++;
            }
        }

        return longestGap;
    }
}