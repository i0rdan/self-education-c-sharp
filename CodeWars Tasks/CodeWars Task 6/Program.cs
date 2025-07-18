public static class Kata6
{
    public static bool XO(string input)
    {
        var xCount = 0;
        var oCount = 0;

        foreach (var c in input.ToLower())
        {
            if (c == 'x') xCount++;
            if (c == 'o') oCount++;
        }

        return xCount == oCount;
    }
}
