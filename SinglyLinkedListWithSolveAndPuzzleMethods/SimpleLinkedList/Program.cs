// See https://aka.ms/new-console-template for more information
using LinkedList;

NodeOperation x = new NodeOperation();
x.InsertNodeAtLast(1);
x.InsertNodeAtLast(2);
x.InsertNodeAtLast(3);
x.Print();
x.InsertNodeAtLast(4);
x.InsertNodeAtLast(5);
x.InsertNodeAtLast(6);
Console.WriteLine("Puzzle Method");
x.PrintPuzzleMethod();
Console.WriteLine("Solve Method");
x.PrintSolveMethod();

