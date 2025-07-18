using System.Text;

public static class Kata5
{
    public static readonly Dictionary<char, char> dnaDict = new()
    {
        { 'T', 'A' },
        { 'A', 'T' },
        { 'C', 'G' },
        { 'G', 'C' },
    };

    public static string MakeComplement(string dna)
    {
        var sb = new StringBuilder();

        foreach (var c in dna)
        {
            sb.Append(dnaDict[c]);
        }

        return sb.ToString();
    }
}
