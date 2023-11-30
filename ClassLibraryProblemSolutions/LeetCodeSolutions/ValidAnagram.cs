using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    // Source: https://leetcode.com/problems/Valid-Anagram/
    // Author: Jalal Shabo
    // Date  : 11/15/2023
    // Time Complexity: O(n)
    // Space Complexity: O(n)
    public static class ValidAnagram
    {
        public static bool ValidAnagramSolution(string s, string t)
    {

        Dictionary<char, int> freqCounter = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (freqCounter.ContainsKey(c))
            {
                freqCounter[c] += 1;
            }
            else
            {
                freqCounter.Add(c, 1);
            }
        }

        foreach (char c in t)
        {
            if (freqCounter.ContainsKey(c))
            {
                freqCounter[c] -= 1;
            }
            else
            {
                return false;
            }
        }

        return freqCounter.Values.All(num => num == 0);

    }
        
    }
}