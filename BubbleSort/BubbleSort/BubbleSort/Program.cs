using BubbleSort;

int[] array = new int[12] { 1,150 , -3  , 2, 0, 3, -5, 54, 3, 2, 3, 120 };
SimpleBubbleSort buuble = new SimpleBubbleSort();
buuble.SortArray(array);

Console.WriteLine();

int[] array2 = new int[10] { 1, 2, 0, 3, -5, 54, 3, 2, 3, 12 };
OptimizedBubbleSort x = new OptimizedBubbleSort();
x.SortArray(array2);