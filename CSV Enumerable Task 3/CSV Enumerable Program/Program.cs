using Csv_Library;

try
{
    var csvEnumerable = new CsvEnumerable<TestCsvRecord>();
    var csvCount = csvEnumerable.Count();

    if (csvCount == 0)
    {
        Console.WriteLine("File is empty!");
    }
    else
    {
        int index = 1;
        foreach (var item in csvEnumerable)
        {
            Console.WriteLine($"Record {index}: Id={item.Id}, Name={item.Name};");

            index += 1;
        }
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine("Invalid file path!");
}
catch
{
    Console.WriteLine("Invalid file content!");
}
