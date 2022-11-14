// Программа по определению присутствия в заданном массиве некоторого числа (№35)

// Часть 1 Методы

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);  // "array[i] = Random.Shared.Next(min, max)" так тоже можно
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}|");
    }
}

void SearchInArray(int[] array, int number)
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine($"Bingo. Искомое значение {number} находится в {i + 1}-ом элементе массива");
            Count = 1;
        }
    }
    if (Count == 0) Console.WriteLine("Искомое значение в массиве не найдено");
}

// Часть 2 Обработка ввода пользователя

Console.Write("Введите желаемую длину массива = ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[N];

Console.Write("Введите границы диапазона значений для наполнения массива (через запятую) = ");
string T = Convert.ToString(Console.ReadLine());
string[] Text;
Text = T.Split(',');
int.TryParse(Text[0], out int min);
int.TryParse(Text[1], out int max);

// Часть 3 Поиск значения

Console.Write("Введите желаемое число для поиска в массиве значений = ");
int Search = Convert.ToInt32(Console.ReadLine());

FillArray(Array, min, max);

Console.Write("Сгенерирован массив: ");
PrintArray(Array);
Console.WriteLine();

SearchInArray(Array, Search);
Console.WriteLine();


// Вариант решения с методом, выдающим в return

// bool FindNumber(int[] array, int Number)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] == Number) return true;
//    }
//    return false;
// }