using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Analizer_Library
{
    public class BracketsAnalizer
    {
        static ReadOnlyDictionary<Bracket, Bracket> bracketsDict = new (
            new Dictionary<Bracket, Bracket> {
                [Bracket.OpenParenthesis] = Bracket.CloseParenthesis,
                [Bracket.CloseParenthesis] = Bracket.OpenParenthesis,
                [Bracket.OpenSquare] = Bracket.CloseSquare,
                [Bracket.CloseSquare] = Bracket.OpenSquare,
                [Bracket.OpenCurly] = Bracket.CloseCurly,
                [Bracket.CloseCurly] = Bracket.OpenCurly,
            }
        );

        public static bool IsValid (string? input)
        {
            if (input is null)
            {
                throw new ArgumentException("String is null!");
            }

            var stack = new Stack<Bracket>();
            foreach (var elem in input)
            {
                var key = (Bracket)elem;
                if (!bracketsDict.TryGetValue(key, out Bracket value))
                {
                    throw new InvalidEnumArgumentException("Invalid element in string!");
                }

                if (stack.TryPeek(out Bracket curr) && curr == value)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(key);
                }
            }

            return stack.Count == 0;
        }
    }
}
