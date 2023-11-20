using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryLeetCode
{
    // Source: https://leetcode.com/problems/merge-two-sorted-lists/
    // Author: Jalal Shabo
    // Date  : 11/15/2023
    // Time Complexity: O(n) loop through 2 lists 
    // Space Complexity: O(1) no extra space used

    public static class MergeTwoSortedLists
    {
        //created listnode class as per question specs 
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null!)
            {
                this.val = val;
                this.next = next;
            }
        }
        //method for testing solution on personal computer, takes list and turns into linked list
        public static ListNode ListToListNode(int[] array)
        {
            //starting head node
            ListNode headNode = new ListNode();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                //create new node with last number in array 
                ListNode node = new ListNode(array[i]);
                //make the headnode as the next node which would be the null if 1st time 
                node.next = headNode;
                //make headnode point to node such adding nums from list from left to right 
                headNode = node;
            }

            return headNode;
        }
        public static ListNode MergeTwoSortedListsSolution(ListNode list1, ListNode list2)
        {

            //create headnode and tailnode, head to keep place and tail to traverse
            ListNode headNode = new ListNode();
            ListNode tailNode = headNode;

            //incase of edge case of empty list return none empty 
            if (list1 == null || list2 == null)
            {

                if (list1 == null)
                {
                    return list2!;
                }
                else
                {
                    return list1;
                }
            }

            // while both lists are not null check which is lower and add it to our headnode
            // move list accessed forward and move tail forward 
            while (list1 != null && list2 != null)
            {

                if (list1.val < list2.val)
                {

                    tailNode.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tailNode.next = list2;
                    list2 = list2.next;
                }
                tailNode = tailNode.next;
            }

            tailNode.next = list1! ?? list2!;
            return headNode;
        }
    }
}