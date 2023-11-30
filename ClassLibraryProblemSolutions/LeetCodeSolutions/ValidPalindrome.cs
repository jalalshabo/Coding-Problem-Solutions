using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    // Source: https://leetcode.com/problems/valid-palindrome/
    // Author: Jalal Shabo
    // Date  : 11/17/2023

    // Time Complexity: O(n)
    // Space Complexity: O(1)
    public class ValidPalindrome
    {

        public static bool ValidPalindromeSolution(string s)
        {
            if (s.Count() < 2)
            {
                return true;
            }

            char[] strArray = s.ToLower().ToArray();

            int leftPtr = 0, rightPtr = strArray.Length - 1;

            while (leftPtr < rightPtr)
            {

                if (Char.IsLetterOrDigit(strArray[leftPtr]) == false || Char.IsLetterOrDigit(strArray[rightPtr]) == false)
                {

                    if (char.IsLetterOrDigit(strArray[leftPtr]) == false)
                    {
                        leftPtr++;
                        continue;
                    }
                    else
                    {
                        rightPtr--;
                        continue;
                    }
                }
                else if (strArray[leftPtr] != strArray[rightPtr])
                {
                    return false;
                }
                else
                {
                    leftPtr++;
                    rightPtr--;
                }
            }
            return true;
        }
    }
}