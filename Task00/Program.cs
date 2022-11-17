Console.Clear();
Console.WriteLine ("Введите целое цисло");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");