// Напишите программу, 
//которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Clear();

Console.WriteLine("Введите пятизначное число");

int n = Convert.ToInt32(Console.ReadLine());


bool result = Pal(n);

Console.WriteLine(result ? "Да" : "Нет");



bool Pal(int num)
{
    if ((num / 10000 == num % 10) && (num / 1000 - num / 10000 * 10) == (num % 100 - num % 10) / 10) return true;
    return false;

}









