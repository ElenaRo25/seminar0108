// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows1 = 2;
int cols1 = 2;
int rows2 = 2;
int cols2 = 2;

int[,] matrix1 = GenerateRandomMatrix(rows1, cols1);
int[,] matrix2 = GenerateRandomMatrix(rows2, cols2);

Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);

Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);

if (cols1 != rows2)
{
    Console.WriteLine("Невозможно выполнить умножение матриц");
    return;
}

int[,] result = MultiplyMatrices(matrix1, matrix2);

Console.WriteLine("Результирующая матрица:");
PrintMatrix(result);

int[,] GenerateRandomMatrix(int rows, int cols)
{
    Random random = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = random.Next(10); // генерация случайного числа от 0 до 9
        }
    }

    return matrix;
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);

    int[,] result = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            for (int k = 0; k < cols1; k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return result;
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
