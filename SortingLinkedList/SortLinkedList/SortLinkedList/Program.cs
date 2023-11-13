// See https://aka.ms/new-console-template for more information
using SortLinkedList;

Console.WriteLine("Hello, World!");
Operation x = new Operation();

x.Enqueue(-8);
x.Enqueue(3);
x.Enqueue(4);
x.Enqueue(2);

x.SortLinkedList();


x.Print();