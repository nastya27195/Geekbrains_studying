// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Clear();

Console.WriteLine("Введите два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// if (num1 % num2 == 0) Console.WriteLine("Кратно");
// else 
// {
//     result = num1 % num2;
//     Console.WriteLine($"Не кратно, остаток = {result}");
// }


// bool Multiplicity(int numb1, int numb2)
// {
//     return numb1 % numb2 == 0;
// 
// }
// bool result = Multiplicity(num1, num2);
// Console.WriteLine(result ? "Кратно" : $"Не кратно, остаток = {num1 % num2}");



int Multiplicity(int numb1, int numb2)
{
    return numb1 % numb2;

}

int result2 = Multiplicity(num1, num2);

Console.WriteLine(result2 == 0 ? "Кратно" : $"Не кратно, остаток = {result2}");