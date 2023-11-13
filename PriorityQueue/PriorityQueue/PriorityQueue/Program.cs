using PriorityQueue;

PriorityQueueArray x = new(3);

x.Enqueue("x", 20);
x.Enqueue("z", 30);
x.Enqueue("y", 20);
x.Enqueue("y", 20);


x.Dequeue();
x.Dequeue();
x.Dequeue();
x.Dequeue();

x.Enqueue("xy", 60);
x.Enqueue("tz", 90);

x.Dequeue();
x.Dequeue();
x.PrintElements();
