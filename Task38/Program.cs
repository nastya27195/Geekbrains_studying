//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
    }
    return arr;

}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


double MaxElem(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}


double MinElem(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}


double[] array = CreateArrayRndDouble(5, 1, 10);
PrintArray(array);
double maxElement = MaxElem(array);
double minElement = MinElem(array);
double result = Math.Round((maxElement - minElement), 2);


Console.WriteLine(maxElement);
Console.WriteLine(minElement);

Console.WriteLine($"Разность между максимальным и минимальным элементами данного массива равна: {result}");



