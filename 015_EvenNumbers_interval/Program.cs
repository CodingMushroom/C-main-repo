// Задание: Показать четные числа в промедутке (1;N)

Console.WriteLine("Эта прога выдает четные числа в промежутке (1;N)");

Console.Write("Введите число для поиска четных чисел в промежутке (1;N) - ");
double N = Convert.ToDouble(Console.ReadLine());
double i = 1;

while (i <= N)
{
    if (i % 2 == 0)
        Console.Write(i.ToString() + " ");
    i++;
}

Console.WriteLine();
