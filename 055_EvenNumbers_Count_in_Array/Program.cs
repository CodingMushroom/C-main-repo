// Задать массив, заполнить случайными положительными 3-ех значными числами. Показать кол-во четных и нечетных чисел. (№36)

// Часть 1 Методы

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}|");
    }
}

int CountEvenNumbers(int[] array)
{
    int Sum = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) Sum = Sum + array[i];
    }
    return Sum;
}

int CountUnevenNumbers(int[] array)
{
    int Sum = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) Sum = Sum + array[i];
    }
    return Sum;
}

// Часть 2 Расчеты

Console.WriteLine();
Console.Write("Введите желаемую длину массива = ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[N];

FillArray(Array);

Console.Write("Сгенерирован массив = ");
PrintArray(Array);
Console.WriteLine();

Console.WriteLine($"Сумма четных чисел = {CountEvenNumbers(Array)}");
Console.WriteLine($"Сумма нечетных чисел = {CountUnevenNumbers(Array)}");
Console.WriteLine();
