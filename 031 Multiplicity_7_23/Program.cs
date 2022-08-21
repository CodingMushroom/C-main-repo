// Дано число. Проверить его кратность 7 или 23 (№15)

Console.WriteLine("Эта прога проверяет кратно ли заданное число 7 или 23");
Console.WriteLine();

// Вариант1 (случайное число)
Console.WriteLine("Вариант1 Случайное число");
int numberA = new Random().Next(1, 10000);
Console.WriteLine($"Выпало число {numberA}");

if (numberA % 7 == 0 && numberA % 23 == 0)
    Console.WriteLine($"Число {numberA} делится на 7 и на 23");
else if (numberA % 7 == 0)
    Console.WriteLine($"Число {numberA} делится на 7");
else if (numberA % 23 == 0)
    Console.WriteLine($"Число {numberA} делится на 23");
else
    Console.WriteLine($"Число {numberA} НЕ делится на 7 и 23");

Console.WriteLine();

// Вариант1 (заданное число)
Console.WriteLine("Вариант2 Заданное число");
Console.Write("Введите число - ");
double numberB = Convert.ToDouble(Console.ReadLine());

if (numberB % 7 == 0 && numberB % 23 == 0)
    Console.WriteLine($"Число {numberB} делится на 7 и на 23");
else if (numberA % 7 == 0)
    Console.WriteLine($"Число {numberB} делится на 7");
else if (numberA % 23 == 0)
    Console.WriteLine($"Число {numberB} делится на 23");
else
    Console.WriteLine($"Число {numberB} НЕ делится на 7 и 23");

Console.WriteLine();

