// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Solution x = new Solution();
ListNode f1 = new ListNode();
f1.val = 3;
var current = f1;

ListNode f2 = new ListNode();
f2.val = 7;
current.next = f2;
current = f2;

x.RemoveNthFromEnd(f1, 1);