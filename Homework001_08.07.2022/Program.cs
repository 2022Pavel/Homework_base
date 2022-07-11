// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int numA = int.Parse (Console.ReadLine()); 
Console.WriteLine("Введите второе число: "); 
int numB = int.Parse (Console.ReadLine());
int max = numA;
int min = numA;

if (numA > max) max = numA;
if (numB > max) max = numB;
if (numA < min) min = numA;
if (numB < min) min = numB;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);

