using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    // Source: https://leetcode.com/problems/contains-duplicate/
    // Author: Jalal Shabo
    // Date  : 11/17/2023
    // Time Complexity: O(n)
    // Space Complexity: O(n)
    public class ContainsDuplicate
    {
        public static bool ContainsDuplicateSolution(int[] nums)
        {

            HashSet<int> lookUpTable = new HashSet<int>();
            foreach (int num in nums)
            {

                if (lookUpTable.Contains(num))
                {
                    return true;
                }
                else
                {
                    lookUpTable.Add(num);
                }

            }

            return false;


        }
    }
}