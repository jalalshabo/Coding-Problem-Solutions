using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{

    // Source: https://leetcode.com/problems/longest-consecutive-sequence
    // Author: Jalal Shabo
    // Date  : 11/18/2023
    // Time Complexity: O(n^2) worst case due to Array.Sort()
    // Space Complexity: 

    public static class LongestConsecutiveSequence
    {
        public static int LongestConsecutiveSequenceSolution(int[] nums)
        {

            if (nums.Length == 0)
            {
                return 0;
            }

            Array.Sort(nums);
            int longestConsecutiveSequence = 1;

            for (int i = 0, count = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1] - 1)
                {
                    count++;
                }
                else if (nums[i] != nums[i + 1])
                {
                    count = 1;
                }
                if (count > longestConsecutiveSequence)
                {
                    longestConsecutiveSequence = count;

                }
            }

            return longestConsecutiveSequence;
        }

    }
}