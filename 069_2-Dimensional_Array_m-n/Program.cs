// 48. Показать двумерный массив размером m×n заполненный целыми числами


// Методы
void FillArray(int[,] Array)                                          
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(1, 100);
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

// Ввод данных
Console.WriteLine();
Console.Write("Задайте высоту (m) и ширину (n) массива через запятую = ");
string Text = Console.ReadLine();
Console.WriteLine();

string[] Number;                                                    // вводим массив для записи в [0] - целой части, в [1] - вещественной (после ,)
if (Text.Contains(",")) Number = Text.Split(',');                   // условие разделения заданного пользователем числа и СС
else Number = Text.Split('.');                                      // если не будет , или . разбиения не произойдет и array[0] = заполнится заданным числом

int.TryParse(Number[0], out int M);                                 // перевод строкового текста в int  и записть ( через out) в переменную
int.TryParse(Number[1], out int N);

int[,] array = new int[M, N];                                       // задаем двумерный массив [,]

FillArray(array);

Console.Write($"Сгенерирован 2-умерный массив с высотой {M} и шириной {N} = ");
Console.WriteLine();

Console.WriteLine();
PrintArray(array);
Console.WriteLine();

