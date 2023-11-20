using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{
    // Source: https://leetcode.com/problems/group-anagrams/
    // Author: Jalal Shabo
    // Date  : 11/17/2023
    // Time Complexity: O(n Log n) due to sort
    // Space Complexity: O(n) 
    public static class GroupAnagrams
    {

        public static IList<IList<string>> GroupAnagramsSolution(string[] strs)
        {

            List<IList<string>> groupedAnagrams = new List<IList<string>>();

            Dictionary<string, IList<string>> existingAnagram = new Dictionary<string, IList<string>>();

            foreach (string str in strs)
            {
                char[] strCharArray = str.ToArray();
                Array.Sort(strCharArray);
                string sortedStr = new string(strCharArray);

                if (!existingAnagram.ContainsKey(sortedStr))
                {

                    existingAnagram[sortedStr].Add(str);

                }
                else
                {
                    existingAnagram.Add(sortedStr, new List<string>());
                }
            }

            return existingAnagram.Values.ToList();
        }
    }
}