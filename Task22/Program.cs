// Напишите программу, которая
// принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.



int n = - 1;
while (n < 1)
{
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введены неверные данные");
}


void SquareTable(int numb)
{
    int i = 1;
    int result = 0;
    while (i <= numb)
    {
        result = i * i;
        i++;
        Console.Write($"{result}, ");

    }
}


SquareTable(n);
