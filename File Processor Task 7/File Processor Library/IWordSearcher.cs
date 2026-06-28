using File_Processor_Library.Models;

namespace File_Processor_Library
{
    public interface IWordSearcher
    {
        List<SearchResult> Search(string[] files, string searchWord);
    }
}
