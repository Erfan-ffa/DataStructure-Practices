public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int value = 0, ListNode nextNode = null)
    {
        val = value;
        next = nextNode;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = null;
        ListNode current = null;
        int carry = 0;

        while (l1 != null && l2 != null)
        {
            int sum = l1.val + l2.val + carry;

            int fakeSum = l1.val + l2.val + carry;

            if (sum >= 10)
            {
                sum = sum % 10;
            }

            if (head == null)
            {
                ListNode newNode = new ListNode();
                newNode.val = sum;
                newNode.next = null;
                head = newNode;
                current = newNode;
            }
            else
            {
                ListNode newNode = new ListNode();
                newNode.val = sum;
                current.next = newNode;
                current = newNode;
            }

            if (fakeSum >= 10)
            {
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            l1 = l1.next;
            l2 = l2.next;
        }

        while (l1 != null && l2 == null)
        {
            int sum = l1.val + carry;
            int fakeSum = l1.val + carry;

            if (sum >= 10)
            {
                sum = sum % 10;
            }

            ListNode newNode = new ListNode();
            newNode.val = sum;
            current.next = newNode;


            current = newNode;
            l1 = l1.next;

            if (fakeSum >= 10)
            {
                carry = 1;
            }
            else
            {
                carry = 0;
            }
        }


        while (l2 != null && l1 == null)
        {
            int sum = l2.val + carry;
            int fakeSum = l2.val + carry;

            if (sum >= 10)
            {
                sum = sum % 10;
            }


            ListNode newNode = new ListNode();
            newNode.val = sum;
            current.next = newNode;
            current = newNode;
            l2 = l2.next;

            if (fakeSum >= 10)
            {
                carry = 1;
            }
            else
            {
                carry = 0;
            }
        }

        if (carry == 1)
        {
            ListNode newNode = new ListNode();
            newNode.val = carry;
            current.next = newNode;
            current = newNode;
        }


        return head;
    }
}