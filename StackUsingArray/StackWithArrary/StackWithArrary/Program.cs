// See https://aka.ms/new-console-template for more information

using StackWithArrary;

StackArray stack = new(3);
stack.Push(1);
stack.Push(2);
stack.Push(3);



stack.PrintStackMemebers();

var popedItem = stack.Pop();

stack.Push(4);

Console.WriteLine(popedItem);
Console.WriteLine("-------");
Console.WriteLine(stack.Peek());
    