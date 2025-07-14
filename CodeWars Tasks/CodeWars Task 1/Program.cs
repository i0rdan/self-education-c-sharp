using System.Text;

public static class Kata1
{
    const int indexDiff = 96;

    const int firstIndexLetter = 1;

    const int lastIndexLetter = 26;

    public static string AlphabetPosition(string text)
    {
        var resultSb = new StringBuilder();

        foreach (char c in text)
        {
            int position = char.ToLower(c) - indexDiff;
            if (position >= firstIndexLetter && position <= lastIndexLetter)
            {
                resultSb.Append($" {position}");
            }
        }

        return resultSb.ToString().Trim();
    }
}
