using Analizer_Library;

while (true)
{
    try
    {
        Console.WriteLine("Please enter your string for validation:");

        string? s = Console.ReadLine();
        if(BracketsAnalizer.IsValid(s))
        {
            Console.WriteLine("String is valid!");
        }
        else
        {
            Console.WriteLine("String is not valid!");
        }
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }

    Console.WriteLine();
}
