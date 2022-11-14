// Определить сколько чисел больше 0 введено с клавиатуры (№42)

System.Console.Write("Введите набор отрицательных или положительных чисел разделений (без пробелов, запятых, точек итд) =  ");
string Numbers = Convert.ToString(Console.ReadLine());

string[] Numbers_to_Text = new string[Numbers.Length]; // создаем строковый массив длиной в значение длины введенных чисел

void ClearText(string A, string[] X)
{
    for (int i = 0; i < X.Length; i++)
        int k = 0;
    {
        if (A[i] == ',') k++;
        else if (A[i] == ' ') k++;
        else if (A[i] == '.') k++;
        else if (A[i] == '/') k++;
        else X[k] = X[k] + $"{A[i]}"; // записываем значения (кроме " " "," "/" и ".") в строчку
    }
    k++;
}

void Converter
{
    
}

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
