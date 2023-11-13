int CalculateCombination(int n, int k)
{
    if(k == 1)
        return n;
    else if(k ==n )
        return 1;

    return CalculateCombination(n - 1, k - 1) + CalculateCombination(n - 1, k);
}

Console.WriteLine(CalculateCombination(8, 5));