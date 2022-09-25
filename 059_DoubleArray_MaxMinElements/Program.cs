// В указанном массиве вещественных чисел найдите разницу м/у максимальным и минимальным элементами. (№40)

// Часть 1 Методы

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}|");
    }
}

double MaxNumber(double[] array)
{
    double Max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max) Max = array[i];
    }
    return Max;
}

double MinNumber(double[] array)
{
    double Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < Min) Min = array[i];
    }
    return Min;
}

// Часть 2 Ввод данных пользователем

Console.WriteLine();
Console.Write("Введите желаемую длину массива = ");
int N = Convert.ToInt32(Console.ReadLine());
double[] Array = new double[N];

// Часть 3 Расчеты

FillArray(Array);

Console.Write("Сгенерирован массив = ");
PrintArray(Array);
Console.WriteLine();

Console.WriteLine($"Мин = {MinNumber(Array)}");
Console.WriteLine($"Макс = {MaxNumber(Array)}");
Console.Write("Разница м/у макс и мин в массиве = ");

double Difference = 0;
Difference = MaxNumber(Array) - MinNumber(Array);
Console.Write(Difference);

Console.WriteLine();
Console.WriteLine();


// Альтернативный вариант метода с функциями array.Max() и array.Min()
//
// void PrintDiffMinMax(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
//     double difference = array.Max() - array.Min();
//     Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
//     Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
//     Console.WriteLine();
// }