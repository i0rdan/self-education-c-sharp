namespace Calculator_Library
{
    public class Calculator
    {
        public event CalculationHandler? CalculationPerformed;

        private double Add(double a, double b) => a + b;

        private double Subtract(double a, double b) => a - b;

        private double Multiply(double a, double b) => a * b;

        private double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Impossibe to divide by zero!");
            }

            return a / b;
        }

        public double Calculate(double a, double b, CalculatorOperator op)
        {
            double result;
            switch (op)
            {
                case CalculatorOperator.Add:
                {
                    result = Add(a, b);
                    break;
                }
                case CalculatorOperator.Subtract:
                {
                    result = Subtract(a, b);
                    break;
                }
                case CalculatorOperator.Multiply:
                {
                    result = Multiply(a, b);
                    break;
                }
                case CalculatorOperator.Divide:
                {
                    result = Divide(a, b);
                    break;
                }
                default:
                {
                    throw new NotImplementedException("No such operator!");
                }
            }

            var arg = new CalculatorEventArgs(a, b, result);
            CalculationPerformed?.Invoke(arg);

            return result;
        }
    }
}