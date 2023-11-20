using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{
    // Source: https://leetcode.com/problems/product-of-array-except-self/
    // Author: Jalal Shabo
    // Date  : 11/19/2023
    // Time Complexity: O(n)
    // Space Complexity: O(n) 
    // TODO: Complete two pointer solution method to reduce space complexity to O(1)
    public static class ProductOfArrayExeptSelf
    {
        public static int[] ProductOfArrayExeptSelfSolutionWithDivision(int[] nums){
            // O(n) Time Complexity 
            // (3n) Space Complexity 

            int[] productArray = new int[nums.Length];
            int[] prefixArray = new int[nums.Length];
            int[] postfixArray = new int[nums.Length];
            int rightProduct = 1, leftProduct = 1;
            // create prefix array by looping through nums
            for (int i = 0; i < nums.Length-1; i++)
            {
                rightProduct = rightProduct*nums[i];
                prefixArray[i] = rightProduct;
            }

            //create postfix array by looping through nums
            for (int i = nums.Length-1; i >= 0; i--)
            {   
                leftProduct = leftProduct*nums[i];
                postfixArray[i] = leftProduct;
            }

            //set values of both ends manually
            productArray[0] = postfixArray[1];
            productArray[nums.Length-1] = prefixArray[prefixArray.Length-2];

            //loop through and insert calculate sum of products with post and prefix arrays
            for (int i = 1; i < nums.Length-1; i++)
            {
                productArray[i] = prefixArray[i-1]*postfixArray[i+1];
            }

            return productArray;

        }
        
    }
}