// Напишите программу, которая
// 1. принимает на вход пятизначное число и
// 2. проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Да");
    }
    else
    {
        Console.WriteLine($"{number} - Нет");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - Не является пятизначным");
}
