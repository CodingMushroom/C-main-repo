// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет (№53)


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

string Search_Position(int[,] Array, int Number)
{
    string Result = string.Empty;
    for (int m = 0; m < Array.GetLength(0); m++)
    {
        for (int n = 0; n < Array.GetLength(1); n++)
        {
            if (Number == Array[m, n]) Result += $"({m}, {n})";
        }
    }
    if (Result == string.Empty) Result = "Такого элемента нет в массиве";
    return Result;
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

Console.Write("Введите число для его поиска в массиве = ");
int Search_Number = int.Parse(Console.ReadLine()); // int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат = {Search_Position(Array, Search_Number)}");
Console.WriteLine();
