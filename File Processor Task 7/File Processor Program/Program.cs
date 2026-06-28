using File_Processor_Library.Models;
using File_Processor_Library.Services;

Console.Write("Enter directory path to process: ");

string? inputDir = Console.ReadLine();
if (string.IsNullOrWhiteSpace(inputDir))
{
    Console.WriteLine("Error: No directory path provided.");
    return;
}
if (!Directory.Exists(inputDir))
{
    Console.WriteLine($"Error: Directory '{inputDir}' does not exist.");
    return;
}

string[] files;
try
{
    files = Directory.GetFiles(inputDir, "*", SearchOption.AllDirectories);
}
catch (Exception ex)
{
    Console.WriteLine($"Error accessing directory '{inputDir}': {ex.Message}.");
    return;
}
if (files.Length == 0)
{
    Console.WriteLine($"No files found in '{inputDir}'.");
    return;
}

FileProcessorService fileProcessor = new();
WordSearcherService wordSearcher = new();

int fileCount = 0;
Thread fileCountThread = new(() =>
{
    try
    {
        fileCount = fileProcessor.CountFiles(files);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error counting files: {ex.Message}.");
    }
});

int totalWords = 0;
Thread wordCountThread = new(() =>
{
    try
    {
        totalWords = fileProcessor.CountWords(files);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error counting words: {ex.Message}.");
    }
});

int totalLines = 0;
Thread lineCountThread = new(() =>
{
    try
    {
        totalLines = fileProcessor.CountLines(files);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error counting lines: {ex.Message}.");
    }
});

List<Thread> threads = [fileCountThread, wordCountThread, lineCountThread];
foreach (Thread thread in threads)
{
    thread.Start();
}
foreach (Thread thread in threads)
{
    thread.Join();
}

Console.WriteLine("===== File Processing Results =====");
Console.WriteLine($"Total files: {fileCount}.");
Console.WriteLine($"Total words: {totalWords}.");
Console.WriteLine($"Total lines: {totalLines}.");

Console.Write("Enter a word to search for (or press Enter to quit): ");

string? searchWord = Console.ReadLine();
if (string.IsNullOrWhiteSpace(searchWord))
{
    Console.WriteLine("No search word entered. Exiting.");
    return;
}

Console.WriteLine($"Searching for \"{searchWord}\"...");

List<SearchResult> results = wordSearcher.Search(files, searchWord);

if (results.Count == 0)
{
    Console.WriteLine("No matches found.");
}
else
{
    foreach (SearchResult result in results)
    {
        Console.WriteLine($"[{result.FileName}] Line {result.LineNumber}: {result.LineContent}");
    }
}

Console.WriteLine("Search complete.");
