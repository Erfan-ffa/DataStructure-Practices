using Search_insert_position;

int[] array = { 1, 3, 4, 6, 6, 8, 10 };
Solution x = new Solution();
int result = x.RecursiveFind(array, 0, array.Length - 1, 4);
Console.WriteLine(result);