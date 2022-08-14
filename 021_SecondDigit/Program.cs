Console.WriteLine("Эта прога показывает 2-ую цифру из 3-ех значного числа");

int SecondDigit(int Number) // вводим метод вычисления 2-го числа
{
    return (Number / 10) % 10;
}

Console.Write("Введите целое 3-ех значное число - ");
int A = Convert.ToInt32(Console.ReadLine());

if (A / 1000 > 1)
    Console.WriteLine("Введено не 3-ех значное число. Повторите ввод.");
else
    Console.WriteLine($"{A} = {SecondDigit(A)}");
