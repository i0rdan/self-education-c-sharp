using System.Text;

namespace MyStringBuilder_Library.MyStringBuilderCommands
{
    public class ClearCommand : IMyStringBuilderCommand
    {
        private readonly string _currentValue;

        public ClearCommand(string currentValue)
        {
            _currentValue = currentValue;
        }

        public StringBuilder Execute(StringBuilder sb) => sb.Clear();

        public StringBuilder Undo(StringBuilder sb) => sb.Append(_currentValue);
    }
}
