using System.Text.RegularExpressions;

public static class Kata12
{
    public static string PigIt(string str) => string.Join(" ", str.Split(' ')
        .Select(word =>
        Regex.IsMatch(word, @"^[A-Za-z]+$")
            ? word[1..] + word[0] + "ay"
            : word
        ));
}
