using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    // Source: https://leetcode.com/problems/can-place-flowers/
    // Author: Jalal Shabo
    // Date  : 11/29/2023
    // Time Complexity: O(n) 
    // Beats 85% of all C# submissions in Runtime
    // Space Complexity: O(n) 
    // Beats 97% of all C# submissions in Memory Usage

    public class CanPlaceFlowers
    {
        public static bool CanPlaceFlowersSolution(int[] flowerbed, int n)
        {

            int plantedCounter = 0;

            for (int i = 0; i < flowerbed.Length; i++)
            {

                int before = i - 1 < 0 ? 0 : flowerbed[i - 1];
                int after = i + 1 < flowerbed.Length ? flowerbed[i + 1] : 0;

                if (flowerbed[i] == 0 && before == 0 && after == 0)
                {
                    flowerbed[i] = 1;
                    plantedCounter++;
                    i++;
                }

            }

            return plantedCounter >= n;
        }

        public static bool CanPlaceFlowersSolutionTwo(int[] flowerbed, int n)
        {
            int[] flowerbedsModified = new int[flowerbed.Length + 2];
            flowerbedsModified[0] = 0;
            flowerbed.CopyTo(flowerbedsModified, 1);
            flowerbedsModified[^1] = 0;


            int plantedCounter = 0;
            for (int i = 1; i <= flowerbedsModified.Length - 2; i++)
            {

                if (flowerbedsModified[i] == 0)
                {
                    if (flowerbedsModified[i - 1] == 0 && flowerbedsModified[i + 1] == 0)
                    {
                        flowerbedsModified[i] = 1;
                        plantedCounter++;
                        i++;
                    }

                }
            }

            return plantedCounter >= n;

        }
    }
}