using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{
    // TODO: Uncomplete Solution
    // Source: https://leetcode.com/problems/longest-substring-without-repeating-characters
    // Author: Jalal Shabo
    // Date  : 
    // Time Complexity: 
    // Space Complexity: 
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LongestSubstringWithoutRepeatingCharactersSolution(string s)
        {

            int LongestSubstringCount = 0;

            for (int i = 0, j = 1; j < s.Length-1;)
            {
                if(!s[(i)..(j+1)].Contains(s[j+1])){
                    j++;
                    LongestSubstringCount =  LongestSubstringCount < j-i+1 ? j-i+1 : LongestSubstringCount;
                }
                else{
                    i++;

                    if(i==j){
                        j++;
                    }
                }
            }

            return LongestSubstringCount;
        }
    }
}