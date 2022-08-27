// 37. Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

double Method4 (double count)
{
    int Cube = 0;

    for(int i = 0; i < count; i++)   //  1 = счетчик, 2 = условие, 3 = инкримент
    {
        Cube = Math.Pow(count,3);
        Console.Write(Cube);
    }
     return    

}


Console.WriteLine();
Console.WriteLine("Таблица кубов от 1 до заданного значения N");
Console.WriteLine("Введите число N: ");
double N = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine();


int[] GetSqrtTable(int N) // задаю массив
{
    int[] SqrtArray = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        SqrtArray[i] = number * number;
        number++;
    }
    return SqrtArray;
}

void PrintTable(int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"{number} ^ 2 = ");
        System.Console.WriteLine(Array[i]);
        number++;
    }
}

int[] SqrtTable = GetSqrtTable(N);
PrintTable(SqrtTable);