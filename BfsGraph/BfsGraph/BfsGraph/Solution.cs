using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BfsImplementingWithGraph
{
    public class Solution
    {
        int nodeQuantity = 8;
        public int[,] array = { { 0, 0, 1, 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 1, 0 }, { 1, 0, 0, 0, 0, 1, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 1, 1, 0, 1, 0 } };
        public Queue<int> queue = new Queue<int>();
        public int[] visited;

        public Solution()
        {
            visited = new int[nodeQuantity];
        }

        int k = 0;
        public void Search(int index)
        {
            visited[k] = index;
            k++;
            if (queue.Count > 0)
                queue.Dequeue();

            for (int i = 0; i < nodeQuantity; i++)
            {
                if (array[index, i] == 1)
                {
                    bool isVisited = false;
                    for (int j = 0; j < visited.Length; j++)
                    {
                        if (i == visited[j])
                            isVisited = true;
                    }

                    if (!isVisited)
                    {
                        bool falg2 = false;
                        for (int h = 0; h < queue.Count; h++)
                        {
                            var x = queue.Dequeue();
                            if (x == i)
                            {
                                falg2 = true;
                            }
                            queue.Enqueue(x);
                        }

                        if (!falg2)
                        {
                            queue.Enqueue(i);
                        }
                    }
                }
            }

            if (queue.Count == 0)
            {
                foreach (var item in visited)
                {
                    Console.WriteLine(item + " ");
                }
                return;
            }

            Search(queue.Peek());
        }
    }
}