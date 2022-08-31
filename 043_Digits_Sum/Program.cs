// Напишите матод, который принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine();
Console.WriteLine("Прога принимает на вход число и возвращает сумму его чисел");
Console.WriteLine();
Console.Write("Введите число - ");
int N = Convert.ToInt32(Console.ReadLine());

int SumCalculator(int X)
{
    int lastdigit = 0;
    int Sum = 0;
    while (X > 0)
    {
        lastdigit = X % 10;
        Sum = Sum + lastdigit;      
        X = X / 10;
    }
    return Sum;
}

int Result = SumCalculator(N);
Console.WriteLine($"Сумма всех цифр числа {N} = {Result}");
Console.WriteLine();