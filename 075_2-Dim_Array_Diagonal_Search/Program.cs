// В матрице чисел найти сумму элементов главной диагонали (№54)

// Методы

void FillArray(int[,] Array)
{
    for (int m = 0; m < Array.GetLength(0); m++)
    {
        for (int n = 0; n < Array.GetLength(1); n++)
        {
            Array[m, n] = new Random().Next(1, 20);
        }
    }
}

void PrintArray(int[,] Array)
{
    for (int m = 0; m < Array.GetLength(0); m++)
    {
        for (int n = 0; n < Array.GetLength(1); n++)
        {
            Console.Write($"{Array[m, n]} ");
        }
        Console.WriteLine();
    }
}

int Diagonal_Sum(int[,] Array)
{
    int Sum = 0;
    for (int m = 0; m < Array.GetLength(0); m++)
    {
        for (int n = 0; n < Array.GetLength(1); n++)
        {
             if (m == n) Sum += Array[m, n];
        }
    }
    return Sum;
}

// Ввод и решение

Console.WriteLine();
Console.Write("Задайте высоту (M) и ширину (N) массива через запятую = ");
string Text = Console.ReadLine();
Console.WriteLine();

string[] Number;
if (Text.Contains(",")) Number = Text.Split(',');
else Number = Text.Split('.');

int.TryParse(Number[0], out int M);
int.TryParse(Number[1], out int N);

int[,] Array = new int[M, N];

FillArray(Array);
Console.WriteLine($"Сгенерирован 2-умерный массив с высотой {M} и шириной {N} = ");
PrintArray(Array);
Console.WriteLine();

Console.WriteLine("Сумма элементов главной диагонали равна: " + Diagonal_Sum(Array));
Console.WriteLine();


// Альтернативный метод суммирования:
//int Diagonal_Sum(int[,] Array)
//{
//    int Sum = 0;
//   for (int m = 0; m < Array.GetLength(0); m++)
//    {
//        Sum += Array[m, m];
//    }
//    return Sum;
//}