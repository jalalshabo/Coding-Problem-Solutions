using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{

    // Source: https://leetcode.com/problems/merge-strings-alternately/
    // Author: Jalal Shabo
    // Date  : 11/17/2023
    // Time Complexity: O(n)
    // Space Complexity: O(1) 
    public static class MergeStringsAlternately
    {
        public static string MergeStringsAlternatelySolution(string word1, string word2){

            StringBuilder mergedAlternately = new StringBuilder();

            int counter = 0;
            // look through both and append, after which append end of which ever list has remainder
            while (counter < word1.Length && counter < word2.Length )
            {   
                mergedAlternately.Append(word1[counter]).Append(word2[counter]);
                counter++;
            }
            while (counter < word1.Length )
            {   
                mergedAlternately.Append(word1[counter]);
                counter++;
            }
            while (counter < word2.Length )
            {   
                mergedAlternately.Append(word2[counter]);
                counter++;
            }


            return mergedAlternately.ToString();
           
        }
    }
}