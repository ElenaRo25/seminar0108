// // Задача 2:
// Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine() );
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 < num2)
{
    Console.WriteLine($"Большее число {num2}");
}
if (num1 > num2)
{
    Console.WriteLine($"Большее число {num1}");
}
