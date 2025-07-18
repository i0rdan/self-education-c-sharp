public static class Kata10
{
    public static string Order(string words) => words.Length > 0
        ? string.Join(' ', words.Split(' ').OrderBy((n) => n.Where((c) => char.IsDigit(c)).First()))
        : string.Empty;
}
