public static class Kata9
{
    public static long findNb(long m)
    {
        var num = (-1 + Math.Sqrt(1 + 8 * Math.Sqrt(m))) / 2;
        return num % 1 == 0 ? (long)num : -1;
    }
}
