namespace File_Processor_Library
{
    public interface IFileProcessor
    {
        int CountFiles(string[] files);
        int CountWords(string[] files);
        int CountLines(string[] files);
    }
}
