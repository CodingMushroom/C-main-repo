// 49. Показать двумерный массив размером m×n заполненный вещественными числами


// Методы
void FillArray(double[,] Array)                                          
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().NextDouble() * new Random().Next(1,20);    // по умолч ф-я NextDouble() - выдает диапазон от 0 до 1. Поэтому можно домножать значения на случ целые числа
        }
    }
}

void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Ввод данных
Console.WriteLine();
Console.Write("Задайте высоту (m) и ширину (n) массива через запятую = ");
string Text = Console.ReadLine();
Console.WriteLine();

string[] Number;
if (Text.Contains(",")) Number = Text.Split(',');
else Number = Text.Split('.');

int.TryParse(Number[0], out int M);
int.TryParse(Number[1], out int N);

double[,] array = new double[M, N];

FillArray(array);

Console.Write($"Сгенерирован 2-умерный массив с высотой {M} и шириной {N} = ");
Console.WriteLine();

Console.WriteLine();
PrintArray(array);
Console.WriteLine();


