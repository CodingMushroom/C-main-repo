// Определить сколько чисел больше 0 введено с клавиатуры (№42)

System.Console.Write("Введите набор чисел через пробел или запятую: ");
string Text = Convert.ToString(Console.ReadLine());

Text = T.Split(',');
Text = T.Split(' ');

// Методы



int CountPositiveNumbers(int[] array)
{
    int Counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) Counter = Counter + 1;
    }
    return Counter;
}
