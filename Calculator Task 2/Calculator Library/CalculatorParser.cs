namespace Calculator_Library
{
    public class CalculatorParser
    {
        const int argsCount = 3;

        public static void Parse(string? input, out double operand1, out double operand2, out CalculatorOperator op)
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
            }
            catch
            {
                throw new ArgumentException("Invalid first operand is provided!");
            }

            try
            {
                operand2 = double.Parse(inputArgs[1]);
            }
            catch
            {
                throw new ArgumentException("Invalid second operand is provided!");
            }

            var parsedOp = (CalculatorOperator)char.Parse(inputArgs[2]);
            if (Enum.IsDefined(parsedOp))
            {
                op = parsedOp;
            } else
            {
                throw new NotImplementedException("No such operator!");
            }
        }

    }
}
