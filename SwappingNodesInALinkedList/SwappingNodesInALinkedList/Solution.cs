public class Solution
{
    public class ListNode
    {
        public int val;
        public ListNode next;

    }
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
    public ListNode SwapNodes(ListNode head, int k)
    {
        int length = Puzzle(head);
        int nodeLastK = length - k;
        int counter = nodeLastK;
        int counter2 = 1;

        var tempLastK = head;
        var tempFirstK = head;

        if (head.next == null)
        {
            return head;
        }
        else
        {

            while (counter > 0)
            {
                tempLastK = tempLastK.next;
                counter--;
            }

            while (counter2 < k)
            {
                tempFirstK = tempFirstK.next;
                counter2++;
            }

            var temp = tempFirstK.val;
            tempFirstK.val = tempLastK.val;
            tempLastK.val = temp;
        }
        return head;
    }
}
