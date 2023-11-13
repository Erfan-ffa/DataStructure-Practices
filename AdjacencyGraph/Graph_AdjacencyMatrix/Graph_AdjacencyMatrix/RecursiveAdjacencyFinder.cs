namespace Graph_AdjacencyMatrix
{
    public class RecursiveAdjacencyFinder
    {
        int[,] numArray;
        int nodeCounter;
        int firstChar = 65;
        int secondChar = 65;
        public RecursiveAdjacencyFinder()
        {
            nodeCounter = int.Parse(Console.ReadLine());
            numArray = new int[nodeCounter, nodeCounter];
            GetInput();
        }
        public void GetInput(int i = 0, int j = 0)
        {
            if (j == nodeCounter)
            {
                j = 0;
                i++;
            }
            if (i >= nodeCounter )
            {
                return;
            }
            int value = int.Parse(Console.ReadLine());
            numArray[i, j] = value;
            GetInput(i, ++j);

        }
        public void FindAdjacency(int i  = 0, int j = 0)
        {
            if (j == nodeCounter)
            {
                j = 0;
                i++;
                secondChar = 65;
                firstChar++;
                Console.WriteLine("-------");
            }
            if (i >= nodeCounter)
            {
                return;
            }
            if (numArray[i, j] == 1)
            {
                Console.WriteLine($"{(char)firstChar} -> {(char)secondChar}");
            }
            secondChar++;
            FindAdjacency(i, ++j);
        }
    }
}
