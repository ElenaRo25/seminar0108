// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("! ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" !");
    }
}

void FindNumber(int[,] matrix, int a, int b)
{
    if (a > matrix.GetLength(0) || b > matrix.GetLength(1))
    {
        Console.WriteLine($"Такого элемента нет в массиве");
    }
    else
    {
        int c = matrix[a - 1, b - 1];
        Console.WriteLine(c);
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -99, 99);
PrintMatrix(array2d);
Console.WriteLine("Введите строку");
int rowsNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец");
int columnsNumber = Convert.ToInt32(Console.ReadLine());
FindNumber(array2d, rowsNumber, columnsNumber);