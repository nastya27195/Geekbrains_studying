// Напишите программу, которая принимает на вход число (А) и
// выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int n)
{
  int sum = 0;
  for (int i = 1; i <= n; i++)
  {
   sum = sum + i;
  }
  return sum;
}

if (number > 0)
{
    int result = SumDigits(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} равна: {result}");
}

else Console.WriteLine("Требуется ввести натуральное число");