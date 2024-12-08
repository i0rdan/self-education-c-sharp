using System.Text;

namespace MyStringBuilder_Library
{
    public interface IMyStringBuilderCommand
    {
        StringBuilder Execute(StringBuilder sb);

        StringBuilder Undo(StringBuilder sb);
    }
}
