// Задание: сравнить два числа

Console.WriteLine("Эта прога сравнивает 2 числа");

Console.Write("Введите первое число (А) - ");
double A = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число (В) - ");
double B = Convert.ToDouble(Console.ReadLine());

if (A > B)
    Console.WriteLine("А - большее число");
else if (A < B)
    Console.WriteLine("B - большее число");

else
    Console.WriteLine("Числа равны");
