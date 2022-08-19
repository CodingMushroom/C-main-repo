// Задание: отсортировать массив
// 1. Найти позицию мин элемента в неотсорт части массива
// 2. Произвести обмен этого значения со значением первой неотсорт позиции
// 3. Повторять пока есть не отсортированные элементы

void FillArray(int[] array) // метод наполняет массив // void - метод который не требует вывода / возврата какого-то результата (поэтому в коде нет return)
{
    int length = array.Length;
    int index = 0;

    while (index < length)
    {
        array[index] = new Random().Next(1,10); // в массив collection1 на позицю index кладем случайное число от 1 до 10
        index++; // index = index + 1
    }
}

void PrintArray(int[] array) // метод печатает массив
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort (int[] array) // методо сортирует от мин к макс
{
    for (int i = 0; i < array.Length - 1; i++) // тут i-1 тк в след for мы начинаем цикл с i+1. уравниваем.
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++ )
        {
            if (array[j] < array[minPosition]) minPosition =j;
        }
    int temp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temp;
    }
    
}

int[] ARR = new int[10]; // создаем массив с 10 элем-и (по умолч все = 0)
FillArray(ARR);
PrintArray(ARR);
Console.WriteLine();

SelectionSort(ARR); // сортируем
PrintArray(ARR); // печатаем отсортир массив
Console.WriteLine();

