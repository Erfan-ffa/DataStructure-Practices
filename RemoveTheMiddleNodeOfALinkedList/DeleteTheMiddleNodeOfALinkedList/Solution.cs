namespace DeleteTheMiddleNodeOfALinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
    }

    public class Solution
    {
        public int Puzzle(ListNode node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return 1 + Puzzle(node.next);
            }
        }
        public ListNode DeleteMiddle(ListNode head)
        {
            if (head.next == null)
            {
                return null;
            }
            else if (head.next.next == null)
            {
                head.next = null;
            }
            else
            {
                int countOfNodes = Puzzle(head) / 2;
                double middle = Math.Round(Convert.ToDouble(countOfNodes));

                var tempNode = head;
                while (middle > 1)
                {
                    tempNode = tempNode.next;
                    middle--;
                }

                tempNode.next = tempNode.next.next;
            }
            return head;
        }
    }
}
