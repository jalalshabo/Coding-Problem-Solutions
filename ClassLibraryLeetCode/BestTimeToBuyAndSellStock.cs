using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{
    // Source: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    // Author: Jalal Shabo
    // Date  : 11/17/2023
    // Time Complexity: O(n) one look through array
    // Space Complexity: O(1) no extra data structures used
    public static class BestTimeToBuyAndSellStock
    {
        public static int BestTimeToBuyAndSellStockSolution(int[] prices)
        {

            int maxprofit = 0;
            int ptr1 = 0, ptr2 = 1;

            //while ptr2 has not reach last element
            while (ptr2 <= prices.Length - 1)
            {
                //if maxprofit of ptr2 - ptr1 is higher then what we have saved, resave
                if (maxprofit < (prices[ptr2] - prices[ptr1]))
                {
                    maxprofit = prices[ptr2] - prices[ptr1];
                }

                //if ptr2 is smaller then move ptr1 to smaller value
                if (prices[ptr1] > prices[ptr2])
                {
                    ptr1 = ptr2;
                }

                ptr2++;

            }
            return maxprofit;
        }
    }
}