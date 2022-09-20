// Задать массив из N элементов, заполненный 0 и 1 и вывести их на экран (№31)

Console.WriteLine();
Console.WriteLine("Прога задает массив из 0 и 1 и выводит его на экран");

// описание методов

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}|");
    }
}

Console.Write("Введите желаемое количество элементов массива - ");
int N = Convert.ToInt32(Console.ReadLine());

int[] ARR = new int[N];
FillArray(ARR);
Console.Write("Сгенерирован массив: ");
PrintArray(ARR);
Console.WriteLine();
Console.WriteLine();
