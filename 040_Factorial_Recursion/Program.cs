// Расчет факториала методом рекурсии (Урок4)

// Вариант 1 Итеративный метод нахождения факториала
double Factorial(int N) // double - тк int может не вместить значения растущего факториала
{
    if (N == 1) return 1; // 1! = 1, 0! = 1
    else return N * Factorial(N-1); // return - обязательное указание о возврате значения N-1 итд
}

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

// Вариант 2 Итеративный метод нахождения факториала

int FactorialFor(int N)
{
    int Result = 1;
    for (int i = 1; i <= N; i++)
    Result *= i; // Result = Result * i
    return Result;
}
Console.WriteLine($"Вариант 2 (итеративный) 10! = {FactorialFor(10)}");