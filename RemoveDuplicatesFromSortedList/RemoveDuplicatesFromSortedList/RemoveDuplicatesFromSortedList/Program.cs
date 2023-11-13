// See https://aka.ms/new-console-template for more information
using RemoveDuplicatesFromSortedList;

//ListNode l1 = new ListNode();
//int index = 7;
//l1.val = 9;
//l1.next = null;

//while (index > 1)
//{
//    ListNode a = new ListNode();
//    a.val = 9;
//    a.next = l1;
//    l1 = a;
//    index--;
//}

//ListNode l2 = new ListNode();
//int index2 = 5;
//l2.val = 9;
//l2.next = null;

//while (index2 > 1)
//{
//    ListNode a = new ListNode();
//    a.val = index2 * 2;
//    a.next = l2;
//    l2 = a;
//    index2--;
//}


ListNode f = new ListNode() { val = 1, next = null };
ListNode e = new ListNode() { val = 1, next = f };
ListNode d = new ListNode() { val = 1, next = e };
ListNode c = new ListNode() { val = 2, next = d };
ListNode b = new ListNode() { val = 1, next = c };
ListNode a = new ListNode() { val = 1, next = b };
ListNode head = new ListNode() { val = 1, next = a };

Solution x = new Solution();
x.DeleteDuplicates(head);  