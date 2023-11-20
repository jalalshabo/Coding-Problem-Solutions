using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace UtilityLibraries;

// A video game developer is developing a game in which the character makes their way through several segments of a level.
// In each segment, if the character collects a coin, the player scores a point. 
// However, if a segment does not contain a coin, the player loses a point. 
// Player 1 always begins the level, and, at some point, game play is turned over to Player 2 to complete the level. 
// Player 1's goal is to achieve a higher score than Player 2 once the level is completed. 
// Given the status of game segments (whether they contain a coin or not), determine the minimum number of segments Player 1 should play so that, in the end, their score is greater than Player 2's score.
// Example segments = [1, 1, 0, 1]
// Player 1 has the following options:
// Play O segments. This would give them a score of 0. 
// Player 2 would have a score of 3-1=2(because they gain a point for each of the 3 segments with a coin, and lose 1 point for the segment without a coin).
// Play 1 segment. This would give them a score of 1. Player 2 would have a score of 2-1=1.
// Play 2 segments. This would give them a score of 2. Player 2 would have a score of 1-1=0.
// Only in this last case, by playing 2 segments, would Player 1's score be greater than Player 2's. 
// Therefore, return the answer 2.
// Function Description
// Complete the function playSegments in the editor below.
// playSegments has the following parameter:
// int coins[ndenotes whether a video game segment contains a coin (1) or not (0)
// Returns:
// int: the minimum number of segments Player 1 must play so that their score is greater than Player 2's score
public static class HackerRankCoinGame
{
    public static int CoinGame(int[] coins)
    {
        int playerOneScore = 0;
        int totalZero = 0;
        int totalOne = 0;

        foreach (var item in coins)
        {
            if (item == 0)
            {
                totalZero += 1;
            }
            else
            {
                totalOne += 1;
            }
        }

        int totalPoints = totalOne - totalZero;
        int count = 0;

        foreach (int nums in coins)
        {
            count++;
            playerOneScore += nums == 1 ? 1 : -1;

            if (playerOneScore > totalPoints)
            {
                return count;
            }

        }

        return 0;

    }

}
public static class LeetCodeInvertBinaryTree
{
    public class TreeNode
    {

        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null!, TreeNode right = null!)
        {
            this.val = val;
            this.right = right;
            this.left = left;
        }
    }

    //TODO Complete this Question....https://leetcode.com/problems/invert-binary-tree/
    public static TreeNode InvertBinaryTree(TreeNode root)
    {

        //TODO: Implement array to Binary Tree Conversion
        static TreeNode ArrayToBinaryTree(int[] array)
        {
            TreeNode node = new TreeNode();
            return node;
        }


        if (root.right != null)
        {
            InvertBinaryTree(root.right);
        }

        if (root.left != null)
        {
            InvertBinaryTree(root.left);
        }

        TreeNode temp = new TreeNode();

        temp = root;
        root.right = temp.left;
        root.left = temp.right;

        return root;



    }
}