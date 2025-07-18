public static class Kata7
{
    public static int GetSum(int a, int b)
    {
        return Enumerable.Range(a, b - a + 1).ToArray().Sum();
    }
}
