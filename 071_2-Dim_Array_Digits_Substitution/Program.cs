// В двумерном массиве n×k заменить четные элементы на противоположные (№50)


// Методы
void FillArray(int[,] Array)
{
    for (int n = 0; n < Array.GetLength(0); n++)
    {
        for (int k = 0; k < Array.GetLength(1); k++)
        {
            Array[n, k] = new Random().Next(1, 20);
        }
    }
}

void PrintArray(int[,] Array)
{
    for (int n = 0; n < Array.GetLength(0); n++)
    {
        for (int k = 0; k < Array.GetLength(1); k++)
        {
            Console.Write($"{Array[n, k]} ");
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] Array)
{
    for (int n = 0; n < Array.GetLength(0); n++)
    {
        for (int k = 0; k < Array.GetLength(1); k++)
        {
            if (Array[n, k] % 2 == 0) Array[n, k] = -Array[n, k];
        }
    }
}


// Ввод данных
Console.WriteLine();
Console.Write("Задайте высоту (n) и ширину (k) массива через запятую = ");
string Text = Console.ReadLine();
Console.WriteLine();

string[] Number;
if (Text.Contains(",")) Number = Text.Split(',');
else Number = Text.Split('.');

int.TryParse(Number[0], out int N);
int.TryParse(Number[1], out int K);

int[,] Array = new int[N, K];

FillArray(Array);

Console.WriteLine($"Сгенерирован 2-умерный массив с высотой {N} и шириной {K} = ");
PrintArray(Array);
Console.WriteLine();

ChangeArray(Array);
Console.WriteLine("Массив с замененными элементами = ");
PrintArray(Array);
Console.WriteLine();

