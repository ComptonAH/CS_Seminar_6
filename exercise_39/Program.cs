int[] RandomArray()
{
    int[] Array = new int[new Random().Next(3,11)];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(11);
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
    return Array;
}

int[] ReverseArray(int[] Array)
{
    int[] RevArray = new int[Array.Length];
    for (int j = 0, i = Array.Length-1; j < Array.Length; j++,i--)
    {
        RevArray[j] = Array[i];
        Console.Write($"{RevArray[j]} ");   
    }
    return Array;
}

ReverseArray(RandomArray());