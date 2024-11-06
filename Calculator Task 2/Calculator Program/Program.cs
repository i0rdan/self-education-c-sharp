using Calculator_Library;

// where to store constants?
const int argsCount = 3;
string[] exitCommands = { "exit", "quit", "q" };

Calculator calculator = new Calculator();
calculator.CalculationPerformed += OnCalculationPerformed;

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Enter two numbers and an operator (+, -, *, /)");
    Console.WriteLine($"Or one of the following for quit: {string.Join(", ", exitCommands)}");

    string? input = Console.ReadLine();
    if (exitCommands.Contains(input?.ToLower()))
    {
        break;
    }

    try
    {
        ParseInput(input, out double operand1, out double operand2, out CalculatorOperator op);

        calculator.Calculate(operand1, operand2, op);
    } catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("Exiting...");

static void ParseInput(string? input, out double operand1, out double operand2, out CalculatorOperator op)
{
    if (input == null)
    {
        throw new NullReferenceException("Input is empty!");
    }

    string[] inputArgs = input.Split(" ");
    if (inputArgs.Length != argsCount)
    {
        throw new ArgumentException("Invalid amount of arguments!");
    }

    try
    {
        operand1 = double.Parse(inputArgs[0]);
        operand2 = double.Parse(inputArgs[1]);
    }
    catch
    {
        throw new ArgumentException("Invalid operands are provided!");
    }

    op = (CalculatorOperator)char.Parse(inputArgs[2]);
}

static void OnCalculationPerformed(CalculatorEventArgs arg)
{
    Console.WriteLine("Calculation finished!");
    Console.WriteLine($"First number: {arg.operand1};");
    Console.WriteLine($"Second number: {arg.operand2};");
    Console.WriteLine($"Result: {arg.result};");
}
