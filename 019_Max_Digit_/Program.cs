// Задание: Дано число из отрезка (10,99) (вкл оба). Показать наибольшую цифру числа.

Console.WriteLine("Эта прога показывает наибольшую цифру случайного числа из промежутка [10,99]");

int MaxDigit(int number)
{
    int x = number / 10;
    int y = number % 10;
    int max = 0;
            
    if (x > y)
        return max = x;
    else if (x < y)
        return max = y;
    else
        return max = 0;
}   

int A = new Random().Next(9,100);
Console.WriteLine(A);

if (MaxDigit(A) == 0)
    Console.WriteLine("Число состоит из одинаковых цифр");
else 
    Console.WriteLine(MaxDigit(A));
