public static class Kata13
{
    public static string Decode(string morseCode)
    {
        return string.IsNullOrEmpty(morseCode.Trim())
            ? string.Empty
            : string.Join(" ", morseCode.Trim().Split(" ").Select((word) => string.Join("", morseCode.Split(" ").Select((c) => "s"))));
    }
}
