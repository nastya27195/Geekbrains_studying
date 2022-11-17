Console.Clear();
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.WriteLine($"Да, число {num1} является квадратом числа {num2}");
}
else
{
    Console.WriteLine($"Нет, число {num1} не является квадратом числа {num2}");
}
