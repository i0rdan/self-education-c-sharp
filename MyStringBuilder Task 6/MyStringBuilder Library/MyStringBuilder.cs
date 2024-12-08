using System.Text;

using static System.Text.StringBuilder;

namespace MyStringBuilder_Library
{
    public class MyStringBuilder
    {
        private StringBuilder _sb;

        private readonly Stack<IMyStringBuilderCommand> _commandHistory = new();

        public int Capacity
        {
            get => _sb.Capacity;
            set => _sb.Capacity = value;
        }

        public int Length
        {
            get => _sb.Length;
            set => _sb.Length = value;
        }

        public int MaxCapacity => _sb.MaxCapacity;

        public char this[int k]
        {
            get => _sb[k];
            set => _sb[k] = value;
        }

        public MyStringBuilder()
        {
            _sb = new StringBuilder();
        }

        public MyStringBuilder(int capacity)
            : this(capacity, int.MaxValue)
        {
        }

        public MyStringBuilder(string? value)
        {
            _sb = new StringBuilder(value);
        }

        public MyStringBuilder(string? value, int capacity)
            : this(value, 0, value?.Length ?? 0, capacity)
        {
        }

        public MyStringBuilder(string? value, int startIndex, int length, int capacity)
        {
            _sb = new StringBuilder(value, startIndex, length, capacity);
        }

        public MyStringBuilder(int capacity, int maxCapacity)
        {
            _sb = new StringBuilder(capacity, maxCapacity);
        }

        public override string ToString() => _sb.ToString();

        public ChunkEnumerator GetChunks() => _sb.GetChunks();

        public override int GetHashCode() => _sb.GetHashCode();

        public override bool Equals(object? obj) => _sb.Equals(obj);

        public int EnsureCapacity(int capacity) => _sb.EnsureCapacity(capacity);

        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            _sb.CopyTo(sourceIndex, destination, destinationIndex, count);
        }

        public void CopyTo(int sourceIndex, Span<char> destination, int count)
        {
            _sb.CopyTo(sourceIndex, destination, count);
        }

        public void ExecuteCommand(IMyStringBuilderCommand command)
        {
            _sb = command.Execute(_sb);

            _commandHistory.Push(command);
        }

        public void Undo()
        {
            var command = _commandHistory.Pop();

            _sb = command.Undo(_sb);
        }
    }
}
