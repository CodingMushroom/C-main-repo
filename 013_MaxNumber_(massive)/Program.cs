// Задание: Найти максимальное из трех чисел 

// Вариант 1 Вводим числа

Console.WriteLine("Эта прога сравнивает 3 числа");
Console.Write("Вариант 1 Вводим числа");

Console.Write("Введите первое число (А) - ");
double A = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число (В) - ");
double B = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число (C) - ");
double C = Convert.ToDouble(Console.ReadLine());

double max = A;

if (B > max)
    max = B;

if (C > max)
{
    max = C;
    Console.WriteLine($"Наибольшее число = {max}");
}

else
    Console.WriteLine($"Наибольшее число = {max}");

// Вариант 2 Через массив
Console.Write("Вариант 2 Через массив");

int[] Numbers = { 54, 65, 3 };

for (int i = 0; i < 3; i++)
{
    int max2 = Numbers[0];
    
    if (Numbers[i] > max2)
    {
        max2 = Numbers[i];
        System.Console.WriteLine();
        System.Console.WriteLine($"Максимальное число {max}");
    }
}
System.Console.WriteLine();
