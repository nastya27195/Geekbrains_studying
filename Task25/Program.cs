// Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.Clear();

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

double ThePower(int a, int b)
{
    int i = 1;
    double res = 1;

    if (b > 0)
    {
        while (i <= b)
        {
            res = res * a;
            i++;
        }

        return res;
    }
    else
    {
        b = Math.Abs(b);
        while (i <= b)
        {
            res = res * a;
            i++;
        }
        return 1 / res;

    }

}

double result = ThePower(num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} --> {result}");
