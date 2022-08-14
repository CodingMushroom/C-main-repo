// Задание: поиск числа в массиве по индексу

int[] array = {1,12,31,4,18,15,16,17,18};
int n = array.Length;

Console.Write("Введите число, индекс которого ищете - ");
int find = Convert.ToInt32(Console.ReadLine());

int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // прерываем выполнение (на случай есть в массиве одинаковые значения)
    }
    index++; // index = index+1
}
