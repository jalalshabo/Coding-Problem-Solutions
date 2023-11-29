using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{

    // Source: https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/
    // Author: Jalal Shabo
    // Date  : 11/28/2023
    // Time Complexity: O(n) one look through array
    // Space Complexity: O(n)
    public static class ReplaceElementswithGreatestElementonRightSide
    {

        public static int[] ReplaceElementswithGreatestElementonRightSideSolution(int[] arr)
        {
            int currentLargest = arr[arr.Length-1];

            for (int i = arr.Length - 1; i >= 0 ; i--)
            {

                if(arr[i] < currentLargest){

                    arr[i] = currentLargest;
                }
                else{
                    int temp = currentLargest; 
                    currentLargest = arr[i];
                    arr[i] = temp;
                }
            }

            arr[arr.Length-1] = -1; 

            return arr; 
        }
        
    }
}