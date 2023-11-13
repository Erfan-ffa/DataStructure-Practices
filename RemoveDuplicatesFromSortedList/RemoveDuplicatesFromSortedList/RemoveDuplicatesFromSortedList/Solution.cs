using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var tempNode = head;

            // solution one
            //while (tempNode != null && tempNode.next != null)
            //{
            //    if (tempNode.val == tempNode.next.val)
            //    {
            //        var current = tempNode;
            //        while (current.val == current.next.val)
            //        {
            //            current = current.next;
            //            if (current.next == null)
            //            {
            //                tempNode.next = null;
            //                return head;
            //            }
            //        }

            //        tempNode.next = current.next;
            //    }

            //    tempNode = tempNode.next;
            //}

            //return head;


            // solution two
            while (tempNode != null && tempNode.next != null)
            {
                if (tempNode.next.val == tempNode.val)
                {
                    tempNode.next = tempNode.next.next;
                }
                else
                {
                    tempNode = tempNode.next;
                }
            }

            return head;
        }
    }
}
