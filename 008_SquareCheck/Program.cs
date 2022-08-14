// Задание: По двум введённым числам проверять является ли первое квадратом второго 

Console.WriteLine("Эта прога выявляет является ли одно число квадратом другого");

Console.Write("Введите число a - ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b - ");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b * b)
    Console.WriteLine("ДА");
else
    Console.WriteLine("НЕТ");
