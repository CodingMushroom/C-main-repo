// 37. Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine();
Console.Write($"Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] CubeTable(int N) // метод по вычислению степени
{
    int[] Array = new int[N]; // создаем массив с N элементами
    int Cube = 1;
    for (int i = 0; i < N; i++)
    {
        Array[i] = (int)Math.Pow(Cube,3); // наполняем массив значениями воз-я в степень
        Cube++;
    }
    return Array;
}

void PrintTable(int[] Array) // метод вывода на экран таблицы результатов
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{number} ^ 3 = ");
        Console.WriteLine(Array[i]);
        number++;
    }
}

int[] SqrtTable = CubeTable(N);
PrintTable(SqrtTable);


// Упрощенный вариант решения (без методов):
//int i = 1;
//double Cube = 1;
//string result = String.Empty;

//while (i <= N)
//{
//    Cube = Math.Pow(i,3);
//    Console.Write(Cube.ToString() + " ");
//    i++;
//}
