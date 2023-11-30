using System.Text.RegularExpressions;

namespace LeetCodeSolutions
{
    // Source: https://leetcode.com/problems/roman-to-integer
    // Author: Jalal Shabo
    // Date  : 11/14/2023
    // Time Complexity: O(n) 
    // Space Complexity: O(n) 
    public static class RomanToInteger
    {
        public static int RomantoInt(string s)
        {
            var dict = new Dictionary<string, int>
        {
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000},
            
            {"IV", 4},
            {"IX", 9},
            {"XL", 40},
            {"XC", 90},
            {"CD", 400},
            {"CM", 900}};

            var array = new string[] { "CM", "CD", "XC", "XL", "IX", "IV", "M", "D", "C", "L", "X", "V", "I" };
            int romanToIntValue = new int();

            foreach (string str in array)
            {
                romanToIntValue += dict.GetValueOrDefault(str) * Regex.Matches(s, str).Count;
            }

            return romanToIntValue;

        }
    }
}