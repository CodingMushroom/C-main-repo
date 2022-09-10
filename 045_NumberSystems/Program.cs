// 1. Написать метод, который генерирует массив 0 и 1 заданного количества N
// 2. Написать метод перевода из 2-ичной в 10-ичную систему
// 3. Написать метод переводящий 10-ичное число в заданную систему

// Часть 1

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    if (array[0] == 0) array[0] = 1;
    else array[0] = array[0];
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}

int NumberTranslation(int[] array)
{
    int Degree = array.Length - 1;
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Sum = Sum + array[i] * (int)Math.Pow(2, Degree);
        Degree = Degree - 1;
    }
    return Sum;
}

// Часть 2
// теория - https://programforyou.ru/calculators/number-systems

Console.WriteLine();
Console.Write("Укажите сколько цофр хотите в 2-ичном числе - ");
int N = Convert.ToInt32(Console.ReadLine());
int[] ARR = new int[N];
FillArray(ARR);

Console.Write($"Сгенерировано 2-ичное число = ");
PrintArray(ARR);

Console.WriteLine();
Console.WriteLine($"Которое соответсвует в 10-ичной системе числу = {NumberTranslation(ARR)}");
Console.WriteLine();




