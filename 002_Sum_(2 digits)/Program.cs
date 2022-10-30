// Задание: Вывести сумму 2-ух чисел

int numberA = new Random().Next(1,10); // 0 1 2 3 4 ... 9
Console.WriteLine($"число A = {numberA}");

int numberB = new Random().Next(1,10);
Console.WriteLine($"число B = {numberB}");

int result = numberA + numberB;
Console.WriteLine($"A + B = {numberA + numberB}");

// Вариант 2 - метод суммирования с рекурсией

int SumRec(int N)
{
    if (N==0) return 0;
    else return N + SumRec(N - 1);
}
Console.WriteLine($"Пример 2. Сумма чисел от 1 до 10 методом рекурсии = {SumRec(10)}");
