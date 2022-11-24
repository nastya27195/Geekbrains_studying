// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int numb)
{
  return (numb % 7 == 0) && (numb % 23 == 0);
}

bool result = Multiplicity(num);
Console.WriteLine(result ? "Кратно" : $"Не кратно");