// Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран. (ДЗ)

Console.WriteLine();
Console.WriteLine("Прога задает массив из 8 элементов и выводит его на экран");

void FillArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
    }
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}|");
    }
}

int[] ARR = new int[8];
FillArray(ARR);
PrintArray(ARR);
Console.WriteLine();
Console.WriteLine();