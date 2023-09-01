// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)

{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}

double[] arr = CreateArrayRndDouble(4, 0, 100);
PrintArrayDouble(arr);

double min = arr[0];
double max = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
    if (arr[i] > max)
    {
        max = arr[i];
    }
}

double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {difference:F1}");