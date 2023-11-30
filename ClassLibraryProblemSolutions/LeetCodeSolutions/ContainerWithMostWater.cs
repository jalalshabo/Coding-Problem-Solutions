using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{

    // Source: https://leetcode.com/problems/container-with-most-water
    // Author: Jalal Shabo
    // Date  : 11/19/2023
    // Time Complexity: O(n) --- looping once through array with two pointers
    // Space Complexity: O(1) constant space, no added data structures
    public static class ContainerWithMostWater
    {
        public static int ContainerWithMostWaterSolution(int[] height)
        {


            int maxWaterContained = 0;
            int currentWaterContained = 0;

            // loop through heights with two pointers, move lower height, most important is width with largest height 
            for (int i = 0, j=height.Length-1; i < j;)
            {

                if(height[i] > height[j]){

                    currentWaterContained = height[j]*(j-i);
                    j--;
                }
                else{
                    currentWaterContained = height[i]*(j-i);
                    i++;
                }

                maxWaterContained = currentWaterContained > maxWaterContained ? currentWaterContained : maxWaterContained;
            }

            return maxWaterContained; 

        }

    }
}