using Calculator_Library;

Calculator calculator = new ();

calculator.CalculationPerformed += OnCalculationPerformed;

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Enter two numbers and an operator (+, -, *, /)");

    string? input = Console.ReadLine();
    try
    {
        CalculatorParser.Parse(input, out double operand1, out double operand2, out CalculatorOperator op);

        calculator.Calculate(operand1, operand2, op);
    } catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void OnCalculationPerformed(CalculatorEventArgs arg)
{
    Console.WriteLine("Calculation finished!");
    Console.WriteLine($"First number: {arg.operand1};");
    Console.WriteLine($"Second number: {arg.operand2};");
    Console.WriteLine($"Result: {arg.result};");
}
