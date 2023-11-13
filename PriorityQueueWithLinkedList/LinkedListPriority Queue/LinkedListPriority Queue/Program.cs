// See https://aka.ms/new-console-template for more information
using LinkedListPriority_Queue;

Operation x = new Operation();
x.Enqueue(20, 5);
x.Enqueue(2,4);
x.Enqueue(2,-1);


x.Print();
Console.WriteLine("-----");
x.Dequeue();
x.Print(); 