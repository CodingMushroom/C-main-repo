// Задание: Дан текст. В тексте нужно все пробелы заменить на черточки, маленькие "к" на большие "К", а большие "С" на маленткие "с"


string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"   - можно обращаться к символам заданной строки
//             012345
// s[3] = r

string Replace(string text, char oldValue, char newValue)  // Char хранит одиночный символ в кодировке Unicode и занимает 2 байта
{
    string result = String.Empty; // инициализация пустой строки
    
    int length = text.Length;
    for (int i = 0; i < length; i++) // пробегаем по тексту и делаем:
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();