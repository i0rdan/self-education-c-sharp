public static class Kata8
{
    public static int Solution(int value)
    {
        if (value < 3)
        {
            return 0;
        }

        var sum = 0;

        for (var i = 3; i < value; i += 1)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        return sum;
    }

}
