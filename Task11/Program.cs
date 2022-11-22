// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число --> {number}");

// int firstDigit = number / 100;
// int thirdDigit = number % 10;

// Console.WriteLine($"После удаления второй цифры число выглядит так --> {firstDigit}{thirdDigit}");

int RemoveSecondDigit(int numb)
{
    int firstDigit = numb / 100;
    int thirdDigit = numb % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}
 Console.WriteLine($"После удаления второй цифры число выглядит так --> {RemoveSecondDigit(number)}");
