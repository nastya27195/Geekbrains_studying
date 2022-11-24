// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int thirdDigit = 0;

// if (num >= 100)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     thirdDigit = num % 10;
//     Console.WriteLine(thirdDigit);

// }
// else Console.WriteLine("Третьей цифры нет");

int ThirdDigit(int numb)
{
    while (numb > 999)
    {
        numb = numb / 10;
    }
    return thirdDigit = numb % 10;

}

if (num >= 100)
{
    int thirdDidit = ThirdDigit(num);
    Console.WriteLine(thirdDidit);

}
Console.WriteLine("Третьей цифры не существует");

