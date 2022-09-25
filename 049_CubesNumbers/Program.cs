// Показать кубы чисел из диапазона от 1 до N, заканчивающихся на четную цифру (№30)

Console.WriteLine();
Console.WriteLine("Данная прога показывает кубы чисел, заканчивающихся на четную цифру, из диапазона от 1 до N");
Console.Write("Введите число N - ");
int N = Convert.ToInt32(Console.ReadLine());

// Решение через цикл

Console.WriteLine("Вариант решения 1 (цикл)");
for (int counter = 1; counter <= N; counter++)
{
    int cube = counter * counter * counter;
    if (cube % 2 == 0) System.Console.Write(cube + " ");
}

System.Console.WriteLine();

// Решение через метод

Console.WriteLine();
Console.WriteLine("Вариант решения 2 (метод)");

int[] GetCubeArray(int N)
{
    int i = 0;
    int[] Cubs = new int[N / 2];

    for (int counter2 = 1; counter2 <= N; counter2++)
    {
        if (counter2 % 2 == 0)
        {
            int cube = counter2 * counter2 * counter2;
            Cubs[i] = cube;
            i++;
        }
    }
    return Cubs;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(GetCubeArray(N));
Console.WriteLine(" ");
Console.WriteLine(" ");