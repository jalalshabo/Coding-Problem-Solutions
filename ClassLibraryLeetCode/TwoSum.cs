using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{
    // Source: https://leetcode.com/problems/two-sum
    // Author: Jalal Shabo
    // Date  : 11/17/2023

    // Time Complexity: O(n) 
    // Space Complexity: O(n) 
    public static class TwoSum
{
    public static int[] TwoSumSolution(int[] nums, int target)
    {

        Dictionary<int, int> keyFirstvalueSecond = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (keyFirstvalueSecond.ContainsKey(target - nums[i]))
            {
                return new int[] { i, keyFirstvalueSecond.GetValueOrDefault(target - nums[i]) };
            }
            else
            {
                keyFirstvalueSecond.Add(nums[i], i);
            }
        }

        return new int[] { 0, 0 };

    }

}
}