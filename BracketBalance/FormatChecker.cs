using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketBalance
{
    public static class FormatChecker
    {
        public static bool IsBracketBalanced(string expression)
        {
            List<char> openBrackets = new() { '(', '[', '{'};
            List<char> closedBrackets = new() { ')', ']', '}' };
            Stack<char> bracketsStack = new();
            for (int i = 0; i != expression.Length; ++i)
            {
                char currentSymbol = expression[i];
                if (openBrackets.Contains(currentSymbol))
                {
                    bracketsStack.Push(currentSymbol);
                }
                else if (closedBrackets.Contains(currentSymbol))
                {
                    if (bracketsStack.Count == 0 || !AreBracketsTheSame(bracketsStack.Pop(), currentSymbol))
                    {
                        return false;
                    }
                }
            }

            return bracketsStack.Count == 0;
        }

        private static bool AreBracketsTheSame(char openBracket, char closeBracket)
        {
            return (openBracket == '(' && closeBracket == ')') ||
                (openBracket == '[' && closeBracket == ']') ||
                (openBracket == '{' && closeBracket == '}');
        }
    }
}
