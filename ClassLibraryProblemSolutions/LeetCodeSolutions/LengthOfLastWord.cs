using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{

    // Source: https://leetcode.com/problems/length-of-last-word/ 
    // Author: Jalal Shabo
    // Date  : 11/28/2023
    // Time Complexity: O(n) one look through string
    // Space Complexity: 
    public static class LengthOfLastWord
    {
        public static int LengthOfLastWordSolution(string s)
        {
            int lastWordLength = 0;
            bool foundFirstChar = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (Char.IsLetter(s[i]))
                {
                    foundFirstChar = true;
                    lastWordLength++;
                    continue;
                }
                else if (foundFirstChar)
                {
                    break;
                }

            }

            return lastWordLength;

        }

    }
}