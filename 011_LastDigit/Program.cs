// Задание: Показать последнюю цифру трёхзначного числа 

// Вариант 1

Console.WriteLine("Эта прога показывает последнюю цифру введенного целого числа");
Console.WriteLine();

Console.Write("Варинт1. Введите целое число - ");
double A = Convert.ToDouble(Console.ReadLine());
double result = 0;

if (A % 1 == 0)
{
    result = A % 10;
    Console.WriteLine($"{A} = {result}");
}

else 
    Console.WriteLine("Введено не целое число. Повторите ввод.");
Console.WriteLine();


// Вариант 2

Console.WriteLine("Варинт2. Используем рандомное число");

int number = new Random().Next(100, 1000);

Console.Write($"Последней цифрой числа {number} является цифра {number%10}");
Console.WriteLine();
