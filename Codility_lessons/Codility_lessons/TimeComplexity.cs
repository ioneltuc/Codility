namespace Codility_lessons;

public class TimeComplexity
{
    public static int FrogJmp(int x, int y, int d)
    {
        double distance = y - x;
        return (int)Math.Ceiling(distance / d);
    }
}