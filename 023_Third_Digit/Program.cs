// 23. Найти 3-ю цифру числа или сообщить, что её нет

//Вариант1. Случайное число
Console.Clear();
Console.WriteLine("Вариант1. Прога сообщает 3-ю цифру случайного числа");

int Number = new Random().Next(1, 5000);
Console.WriteLine($"Дано число: {Number}");

if (Number / 100 > 0) 
    Console.WriteLine($"3-я цифра числа {Number} - это {Number / 100 % 10}");
else 
    Console.WriteLine($"У числа {Number} нет третьей цифры");

Console.WriteLine();

//Вариант2. Заданное число
Console.WriteLine("Вариант2. Прога сообщает 3-ю цифру заданного числа");

Console.Write("Введите число - ");
int A = Convert.ToInt32(Console.ReadLine());

if (A / 100 > 0) 
    Console.WriteLine($"3-я цифра числа {A} - это {A / 100 % 10}");
else 
    Console.WriteLine($"У числа {A} нет третьей цифры");

Console.WriteLine();