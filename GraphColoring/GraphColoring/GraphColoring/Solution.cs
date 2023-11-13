namespace GraphColoring;
public class Solution
{
    public int[,] numArray = { { 0, 0, 0, 1, 0, 0, 0, 1 }, { 0, 0, 0, 1, 0, 1, 1, 0 }, { 1, 0, 0, 0, 0, 1, 1, 0 }, { 1, 0, 0, 0, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 0, 0, 0, 0, 0 }, { 0, 1, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 1, 0 } };
    public int nodeQuantity = 8;
    public Stack<int> stack;

    public Solution()
    {
        stack = new Stack<int>();
    }

    int k = 0;
    public void Search(int index, int[] visited)
    {
        Console.WriteLine($"node index: {index} Color -> {(char)(k + 65)}");
        visited[k] = index;
        k++;
        if (stack.Count > 0)
            stack.Pop();

        for (int i = nodeQuantity - 1; i >= 0; i--)
        {
            if (numArray[index, i] == 1)
            {
                bool flag = false;
                for (int j = 0; j < visited.Length; j++)
                {
                    if (visited[j] == i)
                        flag = true;
                }
                if (!flag)
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() != i)
                            stack.Push(i);
                    }
                    else
                    {
                        stack.Push(i);
                    }
                }
            }
        }

        if (stack.Count == 0)
        {
            return;
        }

        Search(stack.Peek(), visited);
    }
}