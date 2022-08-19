// Задание: использование FOR вместо WHILE

string Method(int count, string text) 
{
        string result = String.Empty;
    for(int i = 0; i < count; i++)   //  1 = счетчик, 2 = условие, 3 = инкримент
    {
        result = result + text;
    }
    return result;
}
string FINAL = Method(5, "easy "); // создаем переменную в которую выводим метод
Console.WriteLine(FINAL);
Console.WriteLine();