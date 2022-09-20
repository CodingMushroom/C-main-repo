// Написать программу по замене элементов массива на противополжные (№33)

Console.WriteLine();
Console.WriteLine("Прога генерирует массив случайных чисел и конвертирует их в противоположные значения (выдает новый массив)");

// описание методов

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}|");
    }
}

void ConvertArray(int[] array)
{
    int converter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        converter = - array[i];
        array[i] = converter;
    }
}

Console.Write("Введите желаемое количество элементов массива - ");
int N = Convert.ToInt32(Console.ReadLine());

int[] ARR = new int[N];
FillArray(ARR);

Console.Write("Сгенерирован массив: ");
PrintArray(ARR);

ConvertArray(ARR);
Console.WriteLine();
Console.Write("Конвертация массива: ");
PrintArray(ARR);

Console.WriteLine();
Console.WriteLine();