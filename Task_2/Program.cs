Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число d: ");
int b = int.Parse(Console.ReadLine());

int max = a;

if(a > max) max = a;
if(b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);
