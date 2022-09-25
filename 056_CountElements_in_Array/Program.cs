// Задать одномерный массив, из 123 чисел и найти в нем кол-во элементов на отрезке [10,99] (№37)

// Часть 1 Методы

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}|");
    }
}

int CountNumbers(int[] array, int min, int max)
{
    int Counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min & array[i] <= max) Counter = Counter + 1;
    }
    return Counter;
}

// Часть 2 Ввод данных пользователем

Console.WriteLine();
Console.Write("Укажиче какое число элементов массива следует сгенерировать = ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[N];

Console.Write("Введите границы диапазона, значения которого будем искать в массиве (через запятую) = ");
string T = Convert.ToString(Console.ReadLine());
string[] Text;
Text = T.Split(',');
int.TryParse(Text[0], out int min);
int.TryParse(Text[1], out int max);

// Часть 2 Расчеты

FillArray(Array);

Console.Write("Сгенерирован массив = ");
PrintArray(Array);
Console.WriteLine();
Console.WriteLine();

Console.Write($"Кол-во элементов в массиве из отрезка [{min},{max}] = {CountNumbers(Array, min, max)}");
Console.WriteLine();
Console.WriteLine();
