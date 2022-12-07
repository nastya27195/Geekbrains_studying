//  Напишите программу, которая 
//  принимает на вход число и 
//  выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigits(int n)
{
    int sum = 0;
    int r = default;
    while (n > 0)
    {
    r = n % 10;
    n = n / 10;
    sum = sum + r;
    }
    return sum;


}

int result = SumDigits(num);
Console.WriteLine($"Сумма цифр в числе {num} равна: {result}");