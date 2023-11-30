using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace LeetCodeSolutions
{
    // https://leetcode.com/problems/reverse-string/
    // Author: Jalal Shabo
    // Date  : 11/22/2023
    // Time Complexity: O(n) --- looping through array once
    // Space Complexity: O(1) --- change array in place
    public static class ReverseString
    {
        public static void ReverseStringSolution(char[] s){

           for (int i = 0; i < s.Length/2; i++)
           {

            char tempChar  = s[i];
            s[i] = s[(s.Length-1) - i];
            s[(s.Length-1) - i] = tempChar;
    
           }

        }
    }
}