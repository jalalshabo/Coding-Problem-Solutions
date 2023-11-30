using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{

    // Source: https://leetcode.com/problems/is-subsequence/
    // Author: Jalal Shabo
    // Date  : 11/28/2023
    // Time Complexity: O(n) one look through string
    // Space Complexity: O(n) 
    public static class IsSubsequence
    {
        public static bool IsSubsequenceSolution(string s, string t)
        {
            if (s.Length == 0)
            {
                return true;
            }

            if (t.Length == 0)
            {
                return false;
            }

            int currentCharIndex = 0;
            foreach (char letter in t)
            {

                if (s[currentCharIndex] == letter) currentCharIndex++;
                
                if (currentCharIndex == s.Length) return true;
            }

            return false;

        }
    }
}