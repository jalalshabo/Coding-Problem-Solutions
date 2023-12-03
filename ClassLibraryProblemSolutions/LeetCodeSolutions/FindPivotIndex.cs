using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryProblemSolutions.LeetCodeSolutions
{

    // Source: https://leetcode.com/problems/find-pivot-index/
    // Author: Jalal Shabo
    // Date  : 12/01/2023
    // Time Complexity: O(n) 
    // Beats 98% of all C# submissions in Runtime
    // Space Complexity: O(n) 
    // Beats 65% of all C# submissions in Memory Usage
    public class FindPivotIndex
    {
        public static int FindPivotIndexSolution(int[] nums)
        {

            int rightSum = nums.Sum(); 
            int leftSum = 0;


            for (int i = 0; i < nums.Length-1; i++)
            {

                rightSum -= nums[i];

                if (leftSum == rightSum){
                    return i; 
                }

                leftSum += nums[i];


            }

            return -1;

            
        }


        public static int FindPivotIndexSolutionHighMemory(int[] nums)
        {

            int[] leftSumArray = new int[nums.Length];
            int[] rightSumArray = new int[nums.Length];
            int sum = 0;


            for (int i = 0; i <= nums.Length - 1; i++)
            {
                leftSumArray[i] = sum;
                sum += nums[i];
            }

            sum = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {

                rightSumArray[i] = sum;
                sum += nums[i];

            }

            for (int i = 0; i < nums.Length; i++)
            {

                if (leftSumArray[i] == rightSumArray[i])
                {
                    return i;
                }

            }

            return -1;
        }

    }
}