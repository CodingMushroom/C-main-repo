// Задание: Поиск индекса по числу в массиве (пример методов)

void FillArray(int[] collection1) // метод (функция) наполняет массив. Colection1 - название аргумента
// void - метод который не требует вывода / возврата какого-то результата (поэтому в коде нет return)
{
    int length1 = collection1.Length; // получаем длину массива
    int index1 = 0;

    while (index1 < length1)
    {
        collection1[index1] = new Random().Next(1,10); // в массив collection1 на позицю index кладем случайное число от 1 до 10
        index1++; // index1 = index1 + 1
    }
}

void PrintArray(int[] collection2) // метод печатает массив
{
    int length2 = collection2.Length;
    int index2 = 0;

    while (index2 < length2)
    {
        Console.Write(collection2[index2].ToString() + " "); // печать результатов в строку через пробел
        index2++;
    }
}

int IndexOf(int[] collection3, int Find) // метод
{
    int length3 = collection3.Length;
    int index3 = 0;
    int position = 0;

    while (index3 < length3)
    {
        if(collection3[index3] == Find)
        {
            position = index3;
        }
        index3++;
    }
    return position;
}

int[] array = new int[10]; // создаем массив с 10 элем-и (по умолч = 0)

FillArray(array); // данный метод наполняет массив
PrintArray(array); // данный метод печатает массив
Console.WriteLine();

Console.Write("Введите число чей № индекса ищем - ");
int N = Convert.ToInt32(Console.ReadLine());
int Pos = IndexOf(array, N);
Console.WriteLine(Pos);

Console.WriteLine();
