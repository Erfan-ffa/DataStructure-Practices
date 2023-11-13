using SortLinkedList;

Operation x = new Operation();

x.Enqueue(1);
x.Enqueue(2);
x.Enqueue(2);
x.Enqueue(1);
x.Enqueue(8);

x.SortLinkedList(true);


x.Print();
