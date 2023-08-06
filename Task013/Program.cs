// Напишите программу, которая 
// 1. выводит третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99) Console.WriteLine("Третьей цифры нет");

if (number > 99)
{
    int thirdDigit = number / 10;
    int result = number % 10;
    Console.WriteLine(result);
}

if (number > 999)

// Не удалось ввывести третью цифру из пятизначного числа