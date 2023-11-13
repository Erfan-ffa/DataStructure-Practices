// See https://aka.ms/new-console-template for more information
using QueueWithLinkedList;

Console.WriteLine("Hello, World!");

QueueLinkedList x = new QueueLinkedList();
x.Enqueue(1);
x.Dequeue();
x.Enqueue(2);
x.Enqueue(3);
x.Enqueue(4);
x.Enqueue(5);

x.Dequeue();
x.Enqueue(10);
x.Dequeue();


x.PrintMembers();