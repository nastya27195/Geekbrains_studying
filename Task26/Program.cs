// Напишите программу, которая принимает на вход число и 
//выводит количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int AmountDigits(int n)
{
    int b = 0;
    while (n  > 0)
    {
        n = n / 10;
        b++;
    }
   return b == 0 ? 1 : b;
}

if (num < 0) num = -num;

int result = AmountDigits(num);
Console.WriteLine($"Количество цифр в числе {num} --> {result}");
