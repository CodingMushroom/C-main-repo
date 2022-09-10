// Напишите метод, который принимает на вход шестизначное число и проверяет, является ли оно палиндромом (ДЗ №21)

int n = 0;
while (n < 100000 || n > 999999)
{
    Console.Write("Введите 6-значное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();

// выведем сравнение цифр на экран

int x1 = (n / 100000); // 1 число слева
int y1 = (n % 10); // 1 число справа
Console.WriteLine($"крайние числа слева и справа - это {x1} и {y1}");
int x2 = (n / 10000) % 10; // 2 число слева
int y2 = (n % 100) / 10; // 2 число справа
Console.WriteLine($"вторые числа слева и справа - это {x2} и {y2}");
int x3 = (n / 1000) % 10; // 3 число слева
int y3 = (n % 1000) / 100; // 3 число справа
Console.WriteLine($"третьи числа слева и справа - это {x3} и {y3}");
Console.WriteLine();

// создаем метод проверки палиндромности
void Method2(int a1, int a2, int a3, int b1, int b2, int b3)
{
    string result = String.Empty;
    if ((a1 == b1) & (a2 == b2) & (a3 == b3))
        result = ("Это палиндром");
    else
        result = ("Это не палиндром. ");
    Console.WriteLine(result);
}

Method2(x1, x2, x3, y1, y2, y3);
Console.WriteLine();
