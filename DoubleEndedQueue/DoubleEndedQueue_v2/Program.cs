// See https://aka.ms/new-console-template for more information
using DoubleEndedQueue_v2;


DoubleEndedQueue x = new DoubleEndedQueue(4);
x.EnqueueFront(1);
x.EnqueueFront(2);
x.EnqueueFront(3);
x.EnqueueFront(3);

x.DequeueFront();
x.DequeueFront();
x.DequeueFront();
x.DequeueFront();


x.EnqueueRear(4);
x.EnqueueRear(1);

x.DequeueRear();
x.DequeueRear();

x.Print();