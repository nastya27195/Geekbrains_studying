// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int digitSecond = (num / 10) % 10;

Console.WriteLine(digitSecond);

