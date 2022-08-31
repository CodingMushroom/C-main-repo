// Метод принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Нельзя использовать pow.

//Вариант1 (базовый)
Console.WriteLine();
Console.WriteLine("Вариант1. Метод принимает А и В и возвводит А в степень В");

Console.Write("Введите число А = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В = ");
int B = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int X, int Y)
{
    int Result = 1;
    for (int i = 1; i <= Y; i++)
    {
        Result = Result*X;
    }
    return Result;
}

int FinalScore = Exponentiation(A,B);
Console.WriteLine(FinalScore);


//_________________________________________________________________________________________________________________
//Вариант2 (вывод таблицы результатов)
Console.WriteLine();
Console.WriteLine("Вариант2. Метод принимает А и В и возвводит А в степень В. Вывод таблицы результатов.");

Console.Write("Введите число А = ");
int C = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В = ");
int D = Convert.ToInt32(Console.ReadLine());

int[] ExponTable(int X, int Y)
{
    int[] Array = new int[Y]; // создаем массив с N элементами
    int Exponention = 1;
    for (int i = 0; i < Y; i++)
    {
        Exponention = Exponention * X;
        Array[i] = Exponention;
    }
    return Array;
}

void PrintTable(int[] Array, int X)
{
    int counter = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{X} ^ {counter} = ");
        Console.WriteLine(Array[i]);
        counter++;
    }
}

ExponTable(C,D);
PrintTable(ExponTable(C,D),C);
Console.WriteLine();
