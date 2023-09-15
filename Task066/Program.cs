// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfNaturalNumbers(int start, int end)
{
    if (start > end)
    {
        return 0;
    }
    else
    {
        return start + SumOfNaturalNumbers(start + 1, end);
    }
}

Console.Write("Введите значение M: ");
string inputM = Console.ReadLine();

Console.Write("Введите значение N: ");
string inputN = Console.ReadLine();

if (!string.IsNullOrEmpty(inputM) && !string.IsNullOrEmpty(inputN))
{
    if (int.TryParse(inputM, out int M) && int.TryParse(inputN, out int N))
    {
        int sum = SumOfNaturalNumbers(M, N);
        Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", M, N, sum);
    }
    else
    {
        Console.WriteLine("Введены некорректные значения M и/или N.");
    }
}
else
{
    Console.WriteLine("Вы не ввели значения M и/или N.");
}
