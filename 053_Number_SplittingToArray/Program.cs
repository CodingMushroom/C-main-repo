// Разбиение числа и запись цифр в массив - пример метода

Console.Write("Введите число - ");
int value = Convert.ToInt32(Console.ReadLine());

value = Math.Abs(value);  // берем модуль числа, тк "-" тоже определиться в ячейку массива

int size = value.ToString().Length;  // конвертация значения в строку
int[] numbers_array = new int[size];

while (value != 0)
{
    numbers_array[size-1] = value % 10;
    value = value / 10;
    size --;
}

Console.WriteLine($"Цифры из числа: {string.Join(' ', numbers_array)}");
