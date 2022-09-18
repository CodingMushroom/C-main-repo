// Задайте массив в 12 элементов, случайно заполненных числами из [-9;9]. Найти суммы отриц и полож значений

// Часть 1 Описание методов

void FillArray(int[] arrayX, int minX, int maxX)
{
    for (int i = 0; i < arrayX.Length; i++)
    {
        arrayX[i] = new Random().Next(minX, maxX + 1);
    }
}

void PrintArray(int[] arrayY)
{
    for (int i = 0; i < arrayY.Length; i++)
    {
        Console.Write($"|{arrayY[i]}|");
    }
}

int PositiveSum(int[] arrayZ)
{
    int Sum = 0;
    
    for (int i = 0; i < arrayZ.Length; i++)
    {
        if (arrayZ[i] > 0) 
        Sum = Sum + arrayZ[i];
    }
    return Sum;
}

int NegativeSum(int[] arrayW)
{
    int Sum = 0;
    
    for (int i = 0; i < arrayW.Length; i++)
    {
        if (arrayW[i] < 0) 
        Sum = Sum + arrayW[i];
    }
    return Sum;
}

// Часть 2 Обработка ввода пользователя

Console.Write("Введите желаемую длину массива = ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

Console.Write("Введите границы диапазона значений для наполнения массива (через запятую) = ");
string T = Convert.ToString(Console.ReadLine());
string[] Text;
Text = T.Split(',');
int.TryParse(Text[0], out int min);
int.TryParse(Text[1], out int max);

// Часть 3 Расчет сумм

FillArray(array, min, max);
Console.Write("Сгенерирован массив: ");
PrintArray(array);
Console.WriteLine();

int Sum1 = PositiveSum(array);
int Sum2 = NegativeSum(array);

Console.WriteLine($"Сумма положительных значений из массива = {Sum1}");
Console.WriteLine($"Сумма отрицательных значений из массива = {Sum2}");
Console.WriteLine();
