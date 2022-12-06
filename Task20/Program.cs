//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D простанстве.


Console.WriteLine("Введите координаты точки X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance (int xa, int ya, int xb, int yb)
{
    double xc = (xa - xb) * (xa - xb);
    double yc = (ya - yb) * (ya - yb);
    double res = Math.Sqrt(xc + yc);
    return res;
}


double result = Distance(x1, y1, x2, y2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero); 
Console.WriteLine($"Расстояние между этими двумя точками равно {resultRound}");
