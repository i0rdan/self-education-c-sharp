public static class Kata14
{
    public static bool Scramble(string str1, string str2)
    {
        if (string.IsNullOrEmpty(str2.Trim())) return true;
        if (string.IsNullOrEmpty(str1.Trim())) return false;

        var map = new Dictionary<char, int>();

        foreach (char c in str2.Trim())
        {
            if (map.ContainsKey(c)) map[c] += 1;
            else map.Add(c, 1);
        }

        foreach (char c in str1.Trim())
        {
            if (map.ContainsKey(c))
            {
                if (map[c] == 1) map.Remove(c);
                else map[c] -= 1;
            }
        }

        return map.Count == 0;
    }
}
