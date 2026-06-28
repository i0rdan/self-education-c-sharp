## Multi-threaded File Processing

### Short Description
Create a console application that demonstrates multi-threaded file processing. The application should concurrently count the number of files, words, and lines in a specified directory, allow users to search for a word in these files, and handle errors gracefully.

### Requirements
1. Code style
2. Create a console application
3. Check if the InputFiles directory exists; if not, handle the situation gracefully with an appropriate error message
4. Use multi-threading to concurrently perform the following tasks:
    - Count the total number of files in the InputFiles directory
    - Count the total number of words in all files combined
    - Count the total number of lines in all files combined
5. Display the results of the above tasks with informative output
6. Allow the user to enter a word for searching within the files
7. Implement multi-threaded word searching in each file
8. Handle errors such as missing files, directory issues, or exceptions gracefully and display appropriate error messages

### Example
```bash
dotnet run --project "File Processor Program"
```

```
Enter directory path to process: File Processor Task 7/InputFiles
[Thread 5] File count completed: 4
[Thread 7] Line count completed: 13
[Thread 6] Word count completed: 83
===== File Processing Results =====
Total files: 4
Total words: 83
Total lines: 13
Enter a word to search for (or press Enter to quit): 
No search word entered. Exiting.
```

Sample `InputFiles` directory is included for testing.
