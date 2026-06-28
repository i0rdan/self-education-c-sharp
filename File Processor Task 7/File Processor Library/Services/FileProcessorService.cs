namespace File_Processor_Library.Services
{
    public class FileProcessorService : IFileProcessor
    {
        public const string SplitChars = " \t\n\r";
        public int CountFiles(string[] files)
        {
            return files.Length;
        }

        public int CountWords(string[] files)
        {
            int wordsCount = 0;
            foreach (string file in files)
            {
                try
                {
                    string content = File.ReadAllText(file);
                    string[] words = content.Split(SplitChars.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    wordsCount += words.Length;
                }
                catch (IOException ex)
                {
                    throw new IOException($"Error reading file '{file}': {ex.Message}.", ex);
                }
            }
            return wordsCount;
        }

        public int CountLines(string[] files)
        {
            int linesCount = 0;
            foreach (string file in files)
            {
                try
                {
                    string[] lines = File.ReadAllLines(file);
                    linesCount += lines.Length;
                }
                catch (IOException ex)
                {
                    throw new IOException($"Error reading file '{file}': {ex.Message}.", ex);
                }
            }
            return linesCount;
        }
    }
}
