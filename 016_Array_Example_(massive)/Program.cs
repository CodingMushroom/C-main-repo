// Задание: найти макс аргумент в массиве

int MAX(int arg1, int arg2, int arg3) //ввели метод поиска max
{
    int max_f = arg1;
    if(arg2 > max_f) max_f = arg2;
    if(arg3 > max_f) max_f = arg3;
    return max_f;
}

//              0  1  2  3  4  5  6  7  8 
int[] array = {11,21,31,41,15,61,17,18,19}; //ввели массив
array[0] = 12;

int max = MAX
(
    MAX(array[0],array[1],array[2]),
    MAX(array[3],array[4],array[5]),
    MAX(array[6],array[7],array[8])
);
Console.WriteLine(max);
