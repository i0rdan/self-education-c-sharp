public static class Kata11
{
    public static string SpinWords(string sentence) => sentence.Length > 0
        ? string.Join(' ', sentence.Split(' ').Select((elem) => elem.Length >= 5 ? string.Join(string.Empty, elem.Reverse()) : elem))
        : string.Empty;
}
