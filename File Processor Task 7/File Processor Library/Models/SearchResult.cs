namespace File_Processor_Library.Models
{
    public class SearchResult(string fileName, int lineNumber, string lineContent)
    {
        public string FileName { get; set; } = fileName;
        public int LineNumber { get; set; } = lineNumber;
        public string LineContent { get; set; } = lineContent;
    }
}
