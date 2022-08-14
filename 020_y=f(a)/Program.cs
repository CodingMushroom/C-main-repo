// Задание: Программа вычисления значения функции y = f(a)

Console.WriteLine("Эта програ вычисляет функцию y = 3*x^2 + 2*x^3");

double f (double a) // вводим метод "расчет функции"
{
    return 3 * Math.Pow(a, 2) + 2 * Math.Pow(a, 3);
}

Console.Write("Введите x:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(f(x));