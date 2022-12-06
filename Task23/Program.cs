// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


int n = - 1;
while (n < 1)
{
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введены неверные данные");
}


void CubeTable(int numb)
{
    int i = 1;
    int result = 0;
    while (i <= numb)
    {
        result = i * i * i;
        i++;
        Console.WriteLine($"{(i-1)} | {result}");

    }
}


CubeTable(n);