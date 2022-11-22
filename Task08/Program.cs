//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 1)
    if (number-- % 2 == 1)
    {
        Console.WriteLine(number--);
    }
    
    number--;