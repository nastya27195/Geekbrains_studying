//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"


Console.Clear();
Console.WriteLine("Введите целое число");
int a1 = Convert.ToInt32(Console.ReadLine());
int a2 = -a1;
if (a1 >= 0)
while (a2 <= a1)
        Console.Write($"{a2++} ","");
else 
while (a2 >= a1)
        Console.Write($"{a2--} ","");
