// Найти сумму чисел от 1 до A (№25)

int MethodSum(int A, int B)
{
    int Sum = 0;
    for (int i = A; i <= B; i++)
    {
        Sum = Sum + i;
    }
    return Sum;
}

Console.Write($"Введите желаемый диапазон чисел для суммирования (через ,) = ");
string Text = Convert.ToString(Console.ReadLine());

string[] TextArray;
TextArray = Text.Split(',');
int.TryParse(TextArray[0], out int min);
int.TryParse(TextArray[1], out int max);

int Result = MethodSum(min, max);

Console.WriteLine(Result);
