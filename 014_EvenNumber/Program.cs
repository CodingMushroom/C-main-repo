// Задание: Выяснить является ли число чётным

// Вариант 1
Console.WriteLine("Вариант 1. Эта прога проверяет четность числа");

Console.Write("Введите первое число (А) - ");
double A = Convert.ToDouble(Console.ReadLine());

if (A % 2 == 0)
    Console.WriteLine($"Это четное число");

else
    Console.WriteLine($"Это нечетное число");


// Варинт 2
Console.WriteLine("Вариант 2. Эта прога проверяет четность числа");

System.Console.WriteLine();
System.Console.Write("Введите число:    ");
string writeNumber = Console.ReadLine();

int number = Convert.ToInt32(writeNumber);
string result = $"Число {number} является чётным";

if (number % 2 != 0) result = result.Replace("является", "не является");

System.Console.WriteLine(result);
System.Console.WriteLine();
