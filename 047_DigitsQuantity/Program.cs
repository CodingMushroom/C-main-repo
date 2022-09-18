// Определить количество цифр в заданном числе (№27)
Console.WriteLine("27. Определить количество цифр в числе");
Console.WriteLine();

// Метод

int DigitsQuantity (int X)
{
    int counter = 0;
    for (int i = X; i > 0; counter++)
    {
        i = i / 10;
    }
    return counter;
}

// Расчет

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int Result = 0;
Result = DigitsQuantity(N);

Console.WriteLine($"Количество цифр в числе {N} = {Result}");
Console.WriteLine();