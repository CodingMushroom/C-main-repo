﻿// Разбиение числа и запись цифр в массив - пример метода

int value = 123456;
value = Math.Abs(value);  // берем модуль числа, тк "-" тоже определиться в ячейку массива

int size = value.ToString().Length;  // конвертация значения в строку
int[] numbers_array = new int[size];

while (value != 0)
{
    numbers_array[size-1] = value % 10;
    value = value / 10;
    size --;
}

Console.WriteLine($"value: {string.Join(' ', numbers_array)}");