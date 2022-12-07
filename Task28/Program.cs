// Напишите программу, которая принимает на вход число N и
// выдает произведение чисел от 1 до N.


Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ProDigits(int n)
{
  int p = 1;
  for (int i = 1; i <= n; i++)
  {
   p = p * i;
  }
  return p;
}

if (number > 0)
{
    int result = ProDigits(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} равно: {result}");
}

else Console.WriteLine("Требуется ввести натуральное число");