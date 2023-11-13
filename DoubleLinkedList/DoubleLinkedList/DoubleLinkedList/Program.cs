// See https://aka.ms/new-console-template for more information
using DoubleLinkedList;

LinkedListOperation x = new LinkedListOperation();

x.InsertAtFirst(2);
x.InsertAtFirst(1);
x.InsertAfter(2, 4);
x.InsertAtLast(3);

x.DeleteAt(3);

x.InsertAfter(1, 4);
x.InsertAfter(3, 4);

x.Print();
Console.WriteLine("----");

x.Print();

