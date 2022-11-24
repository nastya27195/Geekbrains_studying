// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

bool WeekDay (int numb)
{
  if (numb <= 7) return true;
  return false;
}

bool result = WeekDay(num);
Console.WriteLine(result ? "Да" : "Нет");