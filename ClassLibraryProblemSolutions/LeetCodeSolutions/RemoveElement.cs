using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    // Source: https://leetcode.com/problems/remove-element
    // Author: Jalal Shabo
    // Date  : 11/24/2023
    // Time Complexity: O(n) one look through array with two pointers and one look through the array to count unique numbers.
    // Space Complexity: O(n)
    // two pointer solution is faster, but the simplicity and readability of solution two has its own benefits  
    public static class RemoveElement
    {
        public static int RemoveElementSolution(int[] nums, int val)
        {

            int leftPtr = 0, rightPtr = nums.Length - 1;


            while (leftPtr < rightPtr)
            {

                if (nums[leftPtr] == val && nums[rightPtr] != val)
                {
                    (nums[leftPtr], nums[rightPtr]) = (nums[rightPtr], nums[leftPtr]);
                    leftPtr++;
                    rightPtr--;
                }
                if (nums[leftPtr] != val)
                {
                    leftPtr++;
                }
                if (nums[rightPtr] == val)
                {
                    rightPtr--;
                }
            }

            int count = 0;

            foreach (int i in nums)
            {
                if (i == val)
                {
                    break;
                }
                count++;

            }

            return count;
        }


        public static int RemoveElementSolutionTwo(int[] nums, int val)
        {

            int uniqueIntCount = 0;

            foreach (int num in nums)
            {
                if (num != val) {
                    nums[uniqueIntCount] = num;
                    uniqueIntCount++;
                }
            }

            return uniqueIntCount;
        }
    }
}