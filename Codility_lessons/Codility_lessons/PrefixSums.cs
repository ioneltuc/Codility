namespace Codility_lessons;

public class PrefixSums
{
    public static int PassingCars(int[] cars)
    {
        int pairsOfCarsPassed = 0;
        
        for (int i = 0; i < cars.Length; i++)
        {
            if (cars[i] == 0)
            {
                int[] remainingCars = new int[cars.Length - i];
                
                Array.Copy(
                    cars, 
                    i, 
                    remainingCars, 
                    0, 
                    remainingCars.Length);

                pairsOfCarsPassed += remainingCars.Sum();
            }
        }

        return pairsOfCarsPassed;
    }
}