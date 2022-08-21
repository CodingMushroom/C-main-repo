// Задание: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


//Вариант1. Случайное число
Console.Clear();
Console.WriteLine("Вариант1. Случайное число");

int dayNumber = new Random().Next(1, 8);
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" }; // массив
string txtResult = "";

if (dayNumber > 5) 
    txtResult = $", Выходной!!!";
else 
    txtResult = $", рабочий день.";

Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");
Console.WriteLine();

//Вариант12 Заданное число
Console.WriteLine("Вариант2. Заданное число");

Console.Write("Введите № дня недели - ");
int A = Convert.ToInt32(Console.ReadLine());
string[] WeekDays = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult2 = "";

if (A > 5)
    txtResult2 = $", Выходной!!!"; 
else 
    txtResult = $", рабочий день.";

Console.WriteLine();

if (A > 7)
    Console.WriteLine($"Введен не существующий номер");
else
    Console.WriteLine($"{A}-й день недели - это {WeekDays[A - 1]}{txtResult2}");

Console.WriteLine();