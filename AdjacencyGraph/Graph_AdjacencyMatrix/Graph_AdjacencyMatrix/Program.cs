using Graph_AdjacencyMatrix;

RecursiveAdjacencyFinder recursiveFinder = new RecursiveAdjacencyFinder();

recursiveFinder.FindAdjacency();

Console.WriteLine("Iterative : ");

IterativeAdjacencyFinder iterativefinder = new IterativeAdjacencyFinder();
iterativefinder.Find();