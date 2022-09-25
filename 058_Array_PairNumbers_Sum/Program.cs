// Найти произведения пар чисел в одномерном массиве. Парой считаются 1-ый и последний элементы, 2-ой и предпоследний итд. (№39)

// Часть 1 Методы

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}|");
    }
}

int[] GetMultiplicationArray(int[] array)
{
    int[] Pairs = new int[array.Length / 2];
    int Counter = 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
        int Multiplication = array[i] * array[array.Length - Counter];
        Pairs[i] = Multiplication;
        Counter++;
    }
    return Pairs;
}

// Часть 2 Ввод данных пользователем

Console.WriteLine();
Console.Write("Введите желаемую длину массива = ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[N];
int[] Array2 = new int[N/2];

// Часть 3 Расчеты

FillArray(Array);

Console.Write("Сгенерирован массив = ");
PrintArray(Array);
Console.WriteLine();

Console.Write($"Произведения пар чисел в одномерном массиве = ");
PrintArray(GetMultiplicationArray(Array));

Console.WriteLine();
Console.WriteLine();
