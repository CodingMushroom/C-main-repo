﻿// Последовательность фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int N) // метод расчет последовательности Фибоначчи
{
    if (N == 1 || N == 2) return 1; // || - ИЛИ
    else return Fibonacci(N-1) + Fibonacci(N-2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
Console.WriteLine();