// Задание: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine();

// Вариант0. Простое решение без массива.
Console.WriteLine("Вариант0");
Console.Write("Введите число - ");
int N = Convert.ToInt32(Console.ReadLine());

if (N == 6 || N == 7)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Будний день");
Console.WriteLine();

//Вариант1. Случайное число
Console.WriteLine("Вариант1. Случайное число");

int dayNumber = new Random().Next(1, 8); // [1,8)
Console.WriteLine($"Сгенерировано число - {dayNumber}");

string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" }; // массив
string Result = String.Empty;

if (dayNumber > 5)
    Result = $", Выходной!!!";
else 
    Result = $", рабочий день.";

Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{Result}");
Console.WriteLine();

//Вариант12 Заданное число
Console.WriteLine("Вариант2. Заданное число");

Console.Write("Введите № дня недели - ");
int A = Convert.ToInt32(Console.ReadLine());
string[] WeekDays = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string Result2 = "";

if (A > 5)
    Result2 = $", Выходной!!!"; 
else 
    Result2 = $", рабочий день.";

Console.WriteLine();

if (A > 7)
    Console.WriteLine($"Введен не существующий номер");
else
    Console.WriteLine($"{A}-й день недели - это {WeekDays[A - 1]}{Result2}");

Console.WriteLine();