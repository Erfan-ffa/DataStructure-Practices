
using FindingTheIndexOfElementInArrayWithBinarySearch;

int[] array = { -2, 1, 3, 4, 5 }; // -2 , 1 , 2 ,3 , 4 , 5

RecursiveFinder recursiveFinder = new RecursiveFinder(); 
IterativeFinder iterativeFinder = new IterativeFinder();

recursiveFinder.RecursiveFinde(array, 0, array.Length, 2);
Console.WriteLine("----");
iterativeFinder.Finde(array, 2);

