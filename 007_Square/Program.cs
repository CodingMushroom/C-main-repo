// Задание: Вывести квадрат заданного числа

Console.WriteLine($"Это программа для вычисления квадрата числа");

// Вариант 1. Ввод числа с клавиатуры
Console.Write("Введите число - ");
int value = Convert.ToInt32(Console.ReadLine());
int result = value * value;

Console.Write($"Вариант 1. Результат - ");
Console.WriteLine(result); // или Console.WriteLine($"Итог: {result})

// Вариант 2. Считаем через переменную

int number = new Random().Next(1, 100);
int result2 = number * number;
Console.WriteLine($"Вариант 2. Квадрат числа {number} = {result}");
