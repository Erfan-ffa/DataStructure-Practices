// See https://aka.ms/new-console-template for more information



using Queue_using_stacks;

QueueArray x = new(3);
x.Enqueue(1);
x.Enqueue(2);
x.Enqueue(3);

x.Enqueue(3);
x.Enqueue(3);
x.Enqueue(3);
x.Enqueue(3);


x.Dequque();
x.Dequque();
x.Dequque();
x.Dequque();

x.Enqueue(9);
x.Enqueue(13);
Console.WriteLine("----");
x.PrintMemebers();
Console.WriteLine("----");
x.Dequque();
Console.WriteLine("----");

x.Enqueue(56);
x.Dequque();

x.PrintMemebers();
