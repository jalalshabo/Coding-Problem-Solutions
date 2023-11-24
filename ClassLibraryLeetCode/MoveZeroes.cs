using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{
    // Source: https://leetcode.com/problems/move-zeroes/
    // Author: Jalal Shabo
    // Date  : 11/15/2023
    // Time Complexity: O(n) loop through list once
    // Space Complexity: O(1) no extra space used
    public static class MoveZeroes
    {
        //leftPTr increments until zero value if start of array is multiple non zero numbers
        public static void MoveZeroesSolution(int[] nums)
        {

            int leftPtr = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {

                if (nums[i] != 0)
                {
                    (nums[leftPtr], nums[i]) = (nums[i], nums[leftPtr]);
                    leftPtr++;
                }
 


            }

        }
    }
}