
using PriorityQueue;

PriorityQueueArray x = new(3);

x.Enqueue("x", 20);
x.Enqueue("z", 10);
x.Enqueue("y", 30);


x.Dequeue();
x.Dequeue();
x.Dequeue();


x.Enqueue("xy", 60);
x.Enqueue("tz", 90);


x.PrintElements();