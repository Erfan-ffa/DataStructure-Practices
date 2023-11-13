using BinarySearch;

int key;

do 
{
    Console.Write("Key : ");
    key = int.Parse(Console.ReadLine());

    RecursiveBinarySearch x = new RecursiveBinarySearch();
    x.BinarySearch(key, 0, 7);

    Console.WriteLine("-----------------------------");

    IterativeBinarySearch a = new IterativeBinarySearch();
    a.BinarySearchs(key);


} while (key != -50);
