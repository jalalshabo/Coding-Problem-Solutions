using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{
    // Source: https://leetcode.com/problems/trapping-rain-water/
    // Author: Jalal Shabo
    // Date  : 11/19/2023
    // Time Complexity: O(n) --- for both solutions, only look through array n times
    // Space Complexity: O(n) for array solution, and O(1) for two pointer solution
    public static class TrappingRainWater
    {
        public static int TrappingRainWatereSolution(int[] height){


            if(height.Length < 2){
                return 0;
            }

            int maxL = height[0], maxR = height[height.Length-1]; 
            int maxWaterContained = 0;
            for (int l = 0, r = height.Length-1; l < r;)
            {
                if(maxL < maxR){
                    l++;
                    maxL = Math.Max(height[l],maxL);
                    maxWaterContained += maxL - height[l];

                }else{
                    r--;
                    maxR = Math.Max(height[r],maxR);
                    maxWaterContained += maxR - height[r];
                }
            }

                return maxWaterContained;

        }
        public static int TrappingRainWaterNSpaceSolution(int[] height){


            int[] maxLeft = new int[height.Length];
            int[] maxRight = new int[height.Length];
            int[] minLeftRight = new int[height.Length];


            for (int i = 0, currentMax = 0; i < height.Length-1; i++)
            {
                maxLeft[i] = currentMax;
                if(currentMax < height[i]){
                    currentMax = height[i];
                }
            }

            for (int i = height.Length-1, currentMax = 0; i > 0; i--)
            {
                maxRight[i] = currentMax;
                if(currentMax < height[i]){
                    currentMax = height[i];
                }
            }

            for (int i = 0; i < minLeftRight.Length-1; i++)
            {
                int currentValue = Math.Min(maxLeft[i],maxRight[i]) - height[i];
                minLeftRight[i] = currentValue >= 0 ? currentValue : 0;
                
            }


            return minLeftRight.Sum();

        }
        
    }
}