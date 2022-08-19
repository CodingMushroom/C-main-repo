// Метод 1 (ничего не принимает и ничего не возвращает)
Console.WriteLine("Метод 1");
void Method1()
{
    Console.WriteLine("автор - ВБ");  // метод который что-то выводит на экран 
}
Method1(); // вызов метода. скобки - обязательно
Console.WriteLine();


// Метод 2 (принимают аргументы, ничего не возвращают)
Console.WriteLine("Метод 2");
void Method2(string text)
{
    Console.WriteLine(text); // выводим текст, который указываем в аргумент
}
Method2("Hello_Baby"); // вызов метода "" - обязательно
Console.WriteLine();

Console.WriteLine("Метод 2_1");
void Method2_1(string text, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(text);
        i++; // инкртимент (плюсуем калькулятор), тэгкримент (минусуем)
    }
}
Method2_1("Йоу", 4); // можно именовать аргументы так: Method2_1(text: "Йоу", сount: 4);
Console.WriteLine();


// Метод 3 (не принимает аргументы, что-то выдает)
Console.WriteLine("Метод 3");
int Method3()
{
    return DateTime.Now.Year; // выводит на экран текущий год
}
int year = Method3();
Console.WriteLine(year);

// Метод 4 (принимает аргументы, что-то выдает. тут нужен result)
Console.WriteLine("Метод 4");
string Method4(int count, string text) // возвращаем строку, передаем int
{
    int i = 0;
    string result = String.Empty; // задаем пустку строку в переменную

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string FINAL = Method4(5, "easy "); // создаем переменную в которую выводим метод
Console.WriteLine(FINAL);
Console.WriteLine();
