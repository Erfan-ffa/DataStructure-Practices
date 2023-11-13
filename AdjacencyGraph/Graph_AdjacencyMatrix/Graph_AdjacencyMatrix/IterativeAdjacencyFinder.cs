namespace Graph_AdjacencyMatrix
{
    public class IterativeAdjacencyFinder
    {
        public void Find()
        {
            int node = int.Parse(Console.ReadLine());
            int[,] numArray = new int[node, node];

            for (int i = 0; i < node; i++)
            {
                for (int j = 0; j < node; j++)
                {
                    int num = int.Parse(Console.ReadLine());
                    numArray[i, j] = num;
                }
            }

            int firstChar = 65;
            int secondChar = 65;

            for (int i = 0; i < node; i++)
            {
                for (int j = 0; j < node; j++)
                {
                    int temp = numArray[i, j];
                    if (temp == 1)
                    {
                        Console.WriteLine($"{(char)firstChar} -> {(char)secondChar}");
                    }
                    secondChar++;
                }
                firstChar++;
                secondChar = 65;
                Console.WriteLine("---");
            }
        }
    }
}
