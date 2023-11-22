using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{

    // Source: https://leetcode.com/problems/concatenation-of-array/
    // Author: Jalal Shabo
    // Date  : 11/20/2023
    // Time Complexity: O(n) --- looping through array twice
    // Space Complexity: O(n) 
    public static class ConcatenationOfArray
    {

        public static int[] ConcatenationOfArraySolution(int[] nums)
        {
            int[] concatenatedArray = new int[nums.Length * 2];
            int count = 0;
            foreach (int num in nums)
            {
                concatenatedArray[count] = num;
                count++;
            }

            foreach (int num in nums)
            {
                concatenatedArray[count] = num;
                count++;
            }

            return concatenatedArray;

        }

        public static int[] ConcatenationOfArrayResizeSolution(int[] nums)
        {
            int arrayLength = nums.Length;
            Array.Resize<int>(ref nums, arrayLength * 2);

            for (int i = 0; i < arrayLength; i++)
            {
                nums[i + arrayLength] = nums[i];
            }

            return nums;
        }
        public static int[] ConcatenationOfArraySolutionSimple(int[] nums)
        {

            int[] concatenatedArray = new int[nums.Length * 2];
            nums.CopyTo(concatenatedArray, 0);
            nums.CopyTo(concatenatedArray, nums.Length);
            return concatenatedArray;


        }

    }
}