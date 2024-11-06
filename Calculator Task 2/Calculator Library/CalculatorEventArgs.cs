namespace Calculator_Library
{
    public class CalculatorEventArgs : EventArgs
    {
        public readonly double operand1;

        public readonly double operand2;

        public readonly double result;

        public CalculatorEventArgs(double operand1, double operand2, double result)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
            this.result = result;
        }
    }
}
