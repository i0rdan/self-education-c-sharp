using System.Text;

namespace MyStringBuilder_Library.MyStringBuilderCommands
{
    public class AppendLineCommand : IMyStringBuilderCommand
    {
        public StringBuilder Execute(StringBuilder sb) => sb.AppendLine();

        public StringBuilder Undo(StringBuilder sb) => sb.Remove(sb.Length - 1, 1);
    }
}
