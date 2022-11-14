// Определить сколько чисел больше 0 введено с клавиатуры (№42)

// Методы

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write(array[i]); // чтобы скобка в конце ряда ставилась сразу, без пробела
        else Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',') count++; // считаем кол-во введенных пользователем запятых
    }

    int[] Numbers = new int[count]; // создаем пустой массив длиной в кол-во введенных чисел (узнали через подсчет , в строке выше)

    int index = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string temp = string.Empty;

        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                temp += input[i].ToString(); // записываем в строку числа без запятых
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        Numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return Numbers;
}

int CountPositive(int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            Sum++;
        }
    }
    return Sum;
}

// Решение

Console.Write("Введите числа через запятую = ");
int[] Numbers = StringToNum(Console.ReadLine());
Console.WriteLine();

PrintArray(Numbers);
Console.WriteLine();
Console.WriteLine();

int Result = CountPositive(Numbers);
Console.WriteLine($"Кол-во значений больше 0 = {Result}");
Console.WriteLine();
