// 72. Задать двумерный массив следующим правилом: A = m+n (№51)


// Методы

void FillArray(int[,] Array)
{
    
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            int M = new Random().Next(1,20);
            int N = new Random().Next(1,20);
            Array[i, j] = M + N;
        }
    }
}

void PrintArray(int[,] Array)
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
