using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryProblemSolutions.LeetCodeSolutions
{
    // Source: https://leetcode.com/problems/valid-mountain-array/
    // Author: Jalal Shabo
    // Date  : 12/01/2023
    // Time Complexity: O(n) 
    // Space Complexity: O(1) 
    public class ValidMountainArray
    {
        public static bool ValidMountainArraySolution(int[] arr)
        {

            if (arr.Length <= 2)
            {
                return false; 
            }

            int leftPtr = 0, rightPtr = arr.Length - 1;
            while (leftPtr < rightPtr)
            {

                if (arr[leftPtr] < arr[leftPtr + 1])
                {
                    leftPtr++;
                }
                else if (arr[rightPtr] < arr[rightPtr - 1])
                {
                    rightPtr--;
                }
                else
                {
                    return false;
                }

            }

            if (leftPtr == 0 || rightPtr == arr.Length - 1) return false; 

            return true;

        }
    }
}