// // Урок 7 Пример: Игра "Ханойские башни"

void Towers (string With = "1", string On = "3", string Some = "2",)
{
    if (Count > 1) Towers (With, Some, On, Count - 1);
    Console.WriteLine($"{With}" >> {On}");
    if (Count > 1) Towers (Some, On, With, Count - 1);
}

Towers();