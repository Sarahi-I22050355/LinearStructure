using System;
using System.Collections.Generic;

namespace LinearStructure
{
    class Program
    { 
        static bool AreParenthesesBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char character in expression)
            {
                if (character == '(')
                {
                    stack.Push(character);
                }
                else if (character == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        static void Main()
        {
            Console.WriteLine("Enter a mathematical expression to check if parentheses are balanced:");
            string userInput = Console.ReadLine();

            bool isBalanced = AreParenthesesBalanced(userInput);

            if (isBalanced)
            {
                Console.WriteLine("The parentheses in the expression are balanced.");
            }
            else
            {
                Console.WriteLine("The parentheses in the expression are not balanced.");
            }
            Console.WriteLine();
        }
    }
}