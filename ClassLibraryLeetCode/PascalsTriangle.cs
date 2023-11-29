using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{
    // Source: https://leetcode.com/problems/pascals-triangle/
    // Author: Jalal Shabo
    // Date  : 11/28/2023
    // Time Complexity: O(n^2) 
    // Space Complexity: O(n) 
    public static class PascalsTriangle
    {
        public static IList<IList<int>> PascalsTriangleSolution(int numRows){

            IList<IList<int>> pascalsTriangle = new List<IList<int>>() { new List<int> {1}  };

            for (int i = 1; i < numRows-1; i++)
            {
                IList<int> tempList = pascalsTriangle[i-1].ToList(); 
                tempList.Insert(0, 0);
                tempList.Add(0);

                List<int> addList = new List<int>(); 
                
                for (int x = 0; x < i+1; x++)
                {

                    addList.Add(tempList[x] + tempList[x+1]); 
                    
                }

                pascalsTriangle.Add(addList);
                
            }

            return pascalsTriangle; 



        }
        
    }
}