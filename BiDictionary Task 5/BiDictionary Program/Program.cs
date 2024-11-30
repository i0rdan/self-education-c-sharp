using Dictionary_Library;

var dict = new BiDictionary<int, string>() {
    [1] = "test1",
    [2] = "test2",
    [3] = "test3",
};

Console.WriteLine("Keys and Values:");
foreach (var item in dict)
{
    Console.WriteLine($"{item.Key}, {item.Value}");
}

Console.WriteLine("Reversed Keys and Values:");
foreach (var item in dict.Inverse)
{
    Console.WriteLine($"{item.Key}, {item.Value}");
}
