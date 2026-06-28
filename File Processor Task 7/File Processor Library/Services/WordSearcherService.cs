using File_Processor_Library.Models;

namespace File_Processor_Library.Services
{
    public class WordSearcherService : IWordSearcher
    {
        public List<SearchResult> Search(string[] files, string word)
        {
            List<SearchResult> results = [];
            foreach (string file in files)
            {
                try
                {
                    string[] lines = File.ReadAllLines(file);
                    string fileName = Path.GetFileName(file);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Contains(word, StringComparison.OrdinalIgnoreCase))
                        {
                            results.Add(new SearchResult(fileName, i + 1, lines[i].Trim()));
                        }
                    }
                }
                catch (IOException ex)
                {
                    throw new IOException($"Error searching file '{file}': {ex.Message}.", ex);
                }
            }
            return results;
        }
    }
}
