using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{

    // Source: https://leetcode.com/problems/valid-parentheses
    // Author: Jalal Shabo
    // Date  : 11/14/2023

    // Time Complexity: O(n) 
    // Space Complexity: O(n) as stack of possible n elements created
    public static class ValidParentheses
    {
        public static bool ValidParenthesesSolution(string s)
        {

            // return false if string length is not even as result with odd characters would alwayas be false
            if (s.Length % 2 != 0)
            {
                return false;
            }
            // create stack for opened brackets, and array for closing and opening brackets 
            Stack<char> charStack = new Stack<char>();

            var brackets = new Dictionary<char, char>() { { ')', '(' }, { ']', '[' }, { '}', '{' } };

            // loop through characters in string, if opening push to stack, if closing check if top of stack is corresponding closing bracket if so pop, else return false. If at the end the stack is empty its correctly balanced 
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    charStack.Push(s[i]);
                }

                else if (s[i] == ')' || s[i] == ']' || s[i] == '}')
                {
                    if (charStack.Count != 0 && brackets[s[i]] == charStack.Peek())
                    {
                        charStack.Pop();

                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return charStack.Count == 0;
        }

    }
}