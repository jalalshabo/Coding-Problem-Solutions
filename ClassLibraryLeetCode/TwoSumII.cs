using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{

    // Source: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted
    // Author: Jalal Shabo
    // Date  : 11/18/2023

    // Time Complexity: O(n) --- looping once through array
    // Space Complexity: O(1) constant space, no added data structures
    // could use dictionary to speed this up but question asked to be complete with constant space
    public static class TwoSumII
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int rightPtr = 0, leftPtr = numbers.Length-1;

            while(rightPtr!=leftPtr){

                int currentValue = numbers[rightPtr] + numbers[leftPtr];

                if(currentValue == target){

                    break;
                }

                if(currentValue>target){
                    leftPtr--;
                }else{
                    rightPtr++;
                }
            }

            return new int[] {rightPtr+1, leftPtr+1};
        }
    }
}