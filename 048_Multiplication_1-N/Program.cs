// Вычисление произведения чисел от 1 до N (№29)

// метод

int Multiplication(int X)
{
    int Result = 1;
    for (int i = 1; i <= X; i++)
    {
        Result = Result * i;
    }
    return Result;
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int Result = 0;
Result = Multiplication(N);

Console.WriteLine($"Произведение чисел от 1 до {N} = {Result}");
Console.WriteLine();