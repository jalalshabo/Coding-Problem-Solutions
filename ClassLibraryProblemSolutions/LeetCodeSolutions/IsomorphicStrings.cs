using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{

    // Source: https://leetcode.com/problems/isomorphic-strings/
    // Author: Jalal Shabo
    // Date  : 11/29/2023
    // Time Complexity: O(n) 
        // Beats 82% of all C# submissions
    // Space Complexity: O(n) 
        // Beats 10% of all C# submissions
    public class IsomorphicStrings
    {
        public static bool IsomorphicStringsSolution(string s, string t){

            Dictionary<char, int> sCharKeyOccuranceValue = new Dictionary<char, int>();
            Dictionary<char, int> tCharKeyOccuranceValue = new Dictionary<char, int>();
            List<int> sMapArray = new List<int>(); 
            List<int> tMapArray = new List<int>(); 


            int counter = 0; 
            foreach (char ch in s)
            {
                if(sCharKeyOccuranceValue.ContainsKey(ch)){
                    sMapArray.Add(sCharKeyOccuranceValue[ch]);
                    
                }else{
                    sMapArray.Add(counter);
                    sCharKeyOccuranceValue.Add(ch, counter);
                    counter++; 
                }
            }

            counter = 0; 
            foreach (char ch in t)
            {
                if(tCharKeyOccuranceValue.ContainsKey(ch)){
                    tMapArray.Add(tCharKeyOccuranceValue[ch]);
                    
                }else{
                    tMapArray.Add(counter);
                    tCharKeyOccuranceValue.Add(ch, counter);
                    counter++; 
                }
            }

            return sMapArray.SequenceEqual(tMapArray);
        }
    }
}