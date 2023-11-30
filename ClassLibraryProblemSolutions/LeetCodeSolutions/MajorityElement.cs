using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{

    // Source: https://leetcode.com/problems/majority-element
    // Author: Jalal Shabo
    // Date  : 11/29/2023
    // Time Complexity: O(n) 
    // Beats 98% of all C# submissions in Runtime
    // Space Complexity: O(1) 
    // Beats 87% of all C# submissions in Memory Usage
    public class MajorityElement
    {

        public static int MajorityElementSolution(int[] nums)
        {
            //using Boyer Moore Majority Vote Algorithm

            int candidate = nums[0], count = 1;
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (count == 0)
                {
                    count++;
                    candidate = nums[i];
                }
                else if (candidate == nums[i])
                {
                    count++;
                }
                else count--;

            }
            return candidate;
        }

        public static int MajorityElementSolutionDict(int[] nums)
        {

            Dictionary<int, int> numberKeyOccuranceValue = new Dictionary<int, int>();


            if (nums.Length == 1)
            {

                return nums[0];
            }

            int largestOccurance = 0;
            int largestOccuranceKey = 0;
            foreach (int num in nums)
            {
                if (numberKeyOccuranceValue.ContainsKey(num))
                {
                    numberKeyOccuranceValue[num]++;


                    if (numberKeyOccuranceValue[num] > largestOccurance)
                    {

                        largestOccuranceKey = num;
                        largestOccurance = numberKeyOccuranceValue[num];
                    }
                }
                else
                {
                    numberKeyOccuranceValue.Add(num, 1);

                }
            }

            return largestOccuranceKey;


        }
    }
}