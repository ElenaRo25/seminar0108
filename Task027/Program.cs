// Напишите программу, которая
// 1. принимает на вход число и
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits (int num)

{
    if (num == 0) return 1;
    int sum = 0;
    while (num > 0 || num < 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumDigits (number);
Console.WriteLine($"Сумма цифр в числе {number} = {result}");
