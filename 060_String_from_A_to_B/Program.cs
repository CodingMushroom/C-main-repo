// Упражнение из урока 7 Сборка строки чисел от меньшего к большему и наоборот

// Вариант 1 Итеративный подход (от меньшего к большему)

string NumbersFor1(int A, int B)
{
    string Result = string.Empty;
    for (int i = A; i <= B; i++)
    {
        Result += $"{i} "; // Result = Result + i, тк это string, происходит запись строки
    }
    return Result;
}
Console.WriteLine(NumbersFor1(5,15));

// Вариант 2 - рекурсия (от меньшего к большему)

string NumbersRec1(int A, int B)
{
    if (A <= B) return $"{A} " + NumbersRec1(A+1, B);
    else return String.Empty; // условие окончания процесса, чтобы издежать зацикливания
}
Console.WriteLine(NumbersRec1(5,15));

// Вариант 3 Сборка строки (от большего к меньшему)

string NumbersFor2(int A, int B)
{
    string Result = string.Empty;
    for (int i = A; i >= B; i--)
    {
        Result += $"{i} ";
    }
    return Result;
}
Console.WriteLine(NumbersFor2(10,1));

// Вариант 4 Сборка строки - рекурсия (от большего к меньшему)

string NumbersRec2(int A, int B)
{
    if (A >= B) return $"{A} " + NumbersRec2(A - 1, B);
    else return String.Empty; // условие окончания процесса, чтобы издежать зацикливания
}
Console.WriteLine(NumbersRec2(10,1));