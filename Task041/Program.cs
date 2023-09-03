// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую:");
string input = Console.ReadLine();

string[] numbers = input.Split(',');

int count = 0;
foreach (string number in numbers)
{
    int num = 0;
    if (int.TryParse(number.Trim(), out num))
    {
        if (num > 0)
        {
            count++;
        }
    }
}

Console.WriteLine("Количество чисел больше 0: " + count);