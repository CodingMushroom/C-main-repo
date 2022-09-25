// Найти сумму чисел в одномерном массиве, стоящих на нечетных позициях (№38)

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

int CountNumbers(int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) Sum += array[i];
    }
    return Sum;
}

// Часть 2 Ввод данных пользователем

Console.WriteLine();
Console.Write("Введите желаемую длину массива = ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[N];

// Часть 3 Расчеты

FillArray(Array);

Console.Write("Сгенерирован массив = ");
PrintArray(Array);
Console.WriteLine();

Console.WriteLine($"Сумма чисел на нечетных позициях в массиве = {CountNumbers(Array)}");
Console.WriteLine();
