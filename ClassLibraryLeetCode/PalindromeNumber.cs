using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{

    // Source: https://leetcode.com/problems/palindrome-number/
    // Author: Jalal Shabo
    // Date  : 11/17/2023
    // Time Complexity: O(n)
    // Space Complexity: O(1)
    public static class PalindromeNumber
    {
        public static bool PalindromeNumberSolution(int x)
        {

            if (x % 10 == 0 && x != 0) return false;

            string xAsString = x.ToString();
            for (int i = 0; i < xAsString.Length; i++)
            {
                if (xAsString[i] == xAsString[(xAsString.Length - 1) - i] && i == (xAsString.Length) - 1)
                {
                    return true;
                }
                else if (xAsString[i] == xAsString[(xAsString.Length - 1) - i])
                {
                    continue;

                }
                else
                {
                    return false;
                }

            }

            return false;

        }
    }
}