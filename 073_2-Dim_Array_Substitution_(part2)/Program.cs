// В двумерном массиве заменить элементы, у которых оба индекса чётные, на их квадрат (№52)


// Методы

void FillArray(int[,] Array)
{
    for (int m = 0; m < Array.GetLength(0); m++)
    {
        for (int n = 0; n < Array.GetLength(1); n++)
        {
            Array[m, n] = new Random().Next(1, 10);
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

void Replace(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if ((m == 0) || (n == 0)) array[m, n] = array[m, n];
            else if ((m % 2 == 0) && (n % 2 == 0)) array[m, n] = array[m, n] * array[m, n];
        }
    }
}


//Ввод и решение

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

Replace(Array);
Console.WriteLine($"Массив после замены = ");
PrintArray(Array);
Console.WriteLine();

