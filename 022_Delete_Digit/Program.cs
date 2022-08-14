// Задание: Удалить вторую цифру 3-ех значного числа

Console.Clear();
Console.WriteLine("Задание: Удалить вторую цифру 3-ех значного (и не только) числа");


int F(int A) // метод рассчета нового числа
{
    return A / 100 * 10 + A % 10;
}

Console.Write("Введите целое 3-ех значное число - ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Если из числа {number} удалить вторую цифру, получится число {F(number)}");
