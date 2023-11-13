// See https://aka.ms/new-console-template for more information
using LinkedList;

NodeOperation x = new NodeOperation();

for (int i = 1; i <= 8; i++)
{
    x.InsertNodeAtLast(i);
}


Console.WriteLine(x.BinarySearchs(3));