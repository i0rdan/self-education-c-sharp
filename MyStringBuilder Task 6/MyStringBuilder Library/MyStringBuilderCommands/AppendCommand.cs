using System.Text;

namespace MyStringBuilder_Library.MyStringBuilderCommands
{
    public class AppendCommand : IMyStringBuilderCommand
    {
        private readonly string _valueToAppend;

        public AppendCommand(string valueToAppend)
        {
            _valueToAppend = valueToAppend;
        }

        public StringBuilder Execute(StringBuilder sb) => sb.Append(_valueToAppend);

        public StringBuilder Undo(StringBuilder sb) => sb.Remove(sb.Length - 1, _valueToAppend.Length);
    }
}
