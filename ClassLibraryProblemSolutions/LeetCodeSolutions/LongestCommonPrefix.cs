using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{

    // Source: https://leetcode.com/problems/longest-common-prefix/
    // Author: Jalal Shabo
    // Date  : 11/28/2023
    // Time Complexity: O(n Log n) OrderBy LinQ method longest time complexity foreach statement is O(n*m)
    // Space Complexity: O(n) length of longest prefix 
    public static class LongestCommonPrefix
    {
        public static string LongestCommonPrefixSolution(string[] strs){


            int index = 0;
            StringBuilder longestPrefix = new StringBuilder();
            string shortest = strs.OrderBy(x => x.Length).First(); 

            foreach (char ch in shortest)
            {
                if (strs.Any(s => s[index] != ch)) break;

                longestPrefix.Append(ch);
                index++; 
                
            }

            return longestPrefix.ToString(); 
        }
        
    }
}