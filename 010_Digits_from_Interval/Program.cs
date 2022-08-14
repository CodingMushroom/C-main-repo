// Задание: вывести числа в помежутке (-N;N)

Console.WriteLine("Эта прога выдает числа в промежутке (-N;N)");

Console.Write("Введите число для промежутка (-N;N) - ");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;

while (i <= N)
{
    Console.Write(i.ToString() + " ");
    i++;
}

Console.ReadLine();
