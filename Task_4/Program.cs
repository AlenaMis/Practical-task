// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Clear();

int a = Convert.ToInt32(Console.ReadLine());
int s = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (s > max) max = s;
if (d > max) max = d;
Console.WriteLine($"max = {max}");
