// Напишите программу, которая
// 1. принимает на вход два числа (A и B) и
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int number1 = ReadInt("Введите первое число: ");
int number2 = ReadInt("Введите второе число: ");
ToDegree(number1, number2);

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
