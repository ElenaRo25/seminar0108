// Задача 8:
// Напишите программу, которая
// 1. на вход принимает число (N), а 
// 2. на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int even = 2;
while (number >= even)
{
    Console.Write(even + " ");
    even = even + 2;
}