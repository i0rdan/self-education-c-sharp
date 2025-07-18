public static class Kata3
{
    public static string GetMiddleSymbolOfString(string s) => s.Substring(s.Length % 2 == 1 ? s.Length / 2 : s.Length / 2 - 1, s.Length % 2 == 1 ? 1 : 2);
}
