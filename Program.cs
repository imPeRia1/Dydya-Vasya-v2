int hourHandAmount = 0;
int[] vasyaArray = { 1, -2 };
AhShitHereWeGoAgain(vasyaArray, hourHandAmount);

int[] AhShitHereWeGoAgain(int[] arr, int hHA)
{
    int[] results = new int[arr.Length + 1];
    int minhHA = hHA;
    for (int i = 0; i<results.Length; i++)
    {
        minhHA = hHA;
        results[i] = hHA;
        for (int j = i; j < arr.Length; j++)
            results[j+1] = results[j] + arr[j];
        
        for (int x = i; x>0; x--)
            results[x-1] = results[x] - arr[x-1];

        for (int y = 0; y<results.Length; y++)
            if (results[y] < hHA) minhHA = results[y];
        if (minhHA == hHA) break;
    }

    if (minhHA != hHA) Console.WriteLine("not found");
    else
    {
        foreach (var x in results)
            Console.Write(x + " ");
    }
    return results;
}