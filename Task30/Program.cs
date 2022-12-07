int[] array = new int[8];

Random rnd = new Random();

void RandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

RandomArray(array);

PrintArray(array);