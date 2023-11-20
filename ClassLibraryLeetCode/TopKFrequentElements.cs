using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{
    // Source: https://leetcode.com/problems/top-k-frequent-elements/
    // Author: Jalal Shabo
    // Date  : 11/18/2023
    // Time Complexity: O(n Log n), need to sort dictionary 
    // Space Complexity: O(n) 
    public static class TopKFrequentElements
{

    public static int[] TopKFrequentElementsSolution(int[] nums, int k)
    {

        //O(n) time complexity (sort dict n, for loop n)

        Dictionary<int, int> numAndFrequency = new Dictionary<int, int>();
        //look through nums and save numbers as key and save frequency as value 
        foreach (int num in nums)
        {
            if (numAndFrequency.ContainsKey(num))
            {
                numAndFrequency[num] += 1;
            }
            else
            {
                numAndFrequency.Add(num, 1);
            }
        }

        //take all elements in dic, order by decending values, select keys, take k keys and save as array
        int[] topElements = numAndFrequency.OrderByDescending(x => x.Value)
                                    .Select(x => x.Key)
                                    .Take(k)
                                    .ToArray();

        return topElements;
    }


}
}