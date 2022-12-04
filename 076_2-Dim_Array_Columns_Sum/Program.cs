// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов (№55)


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

void PrintCoordinates(int[,] Array)
{
    for (int m = 0; m < Array.GetLength(0); m++)
    {
        for (int n = 0; n < Array.GetLength(1); n++)
        {
            Console.Write($"{(m, n)} ");
        }
        Console.WriteLine();
    }
}

void Column_Average(int[,] Array)
{
    string Result = string.Empty;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int Sum = 0;
        int Column = 0;
        int Count = 0;
        double Average = 0;

        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Sum += Array[j, i];                                 // для сбора суммы по столбцам, меняем местами i (строка) и j (столбец) - транспонируем координаты
            Column = i + 1;
            Count++;
        }
        Average = (double)Sum / Count;                          // для отражения деления с остатком добавляем в начало "(double)"
        Console.WriteLine($"{Column}-й столбец = {Average}");

    }
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

Console.WriteLine("Среднее арифметическое по столбцам = ");
Column_Average(Array);
Console.WriteLine();


// альтернативный вариант расчета средней с с выводом в строку
//string Column_Average(int[,] Array)
//{
//    string Result = string.Empty;
//    for (int i = 0; i < Array.GetLength(0); i++)
//    {
//        int Sum = 0;
//        int Column = 0;
//        int Count = 0;
//        double Average = 0;

//        for (int j = 0; j < Array.GetLength(1); j++)
//        {
//           Sum += Array[j, i];                                 // для сбора суммы по столбцам, меняем местами i (строка) и j (столбец) - транспонируем координаты
//            Column = i + 1;
//           Count++;
//        }
//        Average = (double)Sum / Count;                          // для отражения деления с остатком добавляем в начало "(double)"
//        Result += Column + "-й столбец" + " " + "=" + " " + Average.ToString() + ";" + " ";
//    }
//    return Result;
//}

