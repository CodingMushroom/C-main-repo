// Расчет факториала методом рекурсии (Урок4)

double Factorial(int N) // double - тк int может не вместить значения растущего факториала
{
    if (N == 1) return 1; // 1! = 1, 0! = 1
    else return N * Factorial(N-1); // return - обязательное указание о возврате значения N-1 итд
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}