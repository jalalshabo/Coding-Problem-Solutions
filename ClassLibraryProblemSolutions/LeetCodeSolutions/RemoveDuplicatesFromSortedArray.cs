using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{

    // Source: https://leetcode.com/problems/remove-duplicates-from-sorted-array
    // Author: Jalal Shabo
    // Date  : 11/24/2023
    // Time Complexity: O(n) one look through array, two pointer solution faster.
    // Space Complexity: O(1) no extra data structures used
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicatesFromSortedArraySolution(int[] nums)
        {

            int prevNumber = nums[0], arrayPosition = 1;

            for (int i = 1; i <= nums.Length - 1; i++)
            {

                if (nums[i] != prevNumber)
                {

                    nums[arrayPosition] = nums[i];
                    arrayPosition++;
                    prevNumber = nums[i];
                }

            }

            return arrayPosition;

        }

        public static int RemoveDuplicatesFromSortedArrayTwoPointerSolution(int[] nums)
        {

            int leftPtr = 1;

            for (int i = 1; i <= nums.Length-1; i++)
            {

                if(nums[i] != nums[i-1]){

                    nums[leftPtr] = nums[i];
                    leftPtr++;
                }
                
            }

            return leftPtr;

        }

    }
}