// // Урок 7 Пример: Игра "Ханойские башни"
// https://www.cyberforum.ru/csharp-beginners/thread1552590.html

Console.Write("Введите сколько колец в игре - ");
int N = Convert.ToInt32(Console.ReadLine());

void Towers (string Start1, string Temp2, string End3, int Count) // With - откуда берем кольцо, On - куда кладем, Some - промежуточный шпиль
{
    if (Count > 1) 
        Towers (Start1, End3, Temp2, Count - 1); // перекладываем n-1 дисков с Start на End
        Console.WriteLine ($"{Start1} >> {End3}"); // перекладываем 1 диск c Start на y
    if (Count > 1) 
        Towers (Temp2, Start1, End3, Count - 1); 
}

Towers("1", "2", "3", N);

