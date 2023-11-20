using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{
    // TODO: Uncomplete Solution
    // Source: https://leetcode.com/problems/3sum
    // Author: Jalal Shabo
    // Date  : 
    // Time Complexity: 
    // Space Complexity: 
    public static class ThreeSum
    {
        public static IList<IList<int>> ThreeSumSolution(int[] nums)
        {

            List<IList<int>> listOfTriplets = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 3; i++)
            {
                if(i > 0 || nums[i] == nums[i+1]){
                    continue;
                }


                int leftPtr = i + 1, rightPtr = nums.Length - 1;

                while (leftPtr < rightPtr)
                {

                    int currentValue = nums[i] + nums[rightPtr] + nums[leftPtr];

                    if (currentValue > 0)
                    {
                        rightPtr--;
                    }
                    else if (currentValue < 0)
                    {
                        leftPtr++;
                    }
                    else
                    {
                        listOfTriplets.Add(new List<int> { nums[i], nums[rightPtr], nums[leftPtr] });
                        leftPtr++;
                        while(nums[leftPtr] == nums[leftPtr-1] || leftPtr < rightPtr){
                            leftPtr++;
                        }
                    }
                }
            }
            return listOfTriplets;
        }

    }
}