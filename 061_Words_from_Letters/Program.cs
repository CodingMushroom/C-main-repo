// Пример задачи из Урока 7. Собираем из букв слова

// Вариант 1 Итериативный
char[] s = {'а', 'и', 'с', 'т'};
int Count = s.Length;
int N = 1;

for (int i = 0; i < Count; i++)
{
    for (int j = 0; j < Count; j++)
    {
        for (int k = 0; k < Count; k++)
        {
            for (int l = 0; l < Count; l++)
            {
                Console.WriteLine($"{N++, -4} {s[i]}{s[j]}{s[k]}{s[l]}");
            }
        }
    }

}

// Вариант 2 Рекурсия с неизв кол-ом букв в алфавите

int M = 1;

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
    Console.WriteLine($"{M++} {new String(word)}");
    return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
    word[length] = alphabet[i];
    FindWords(alphabet, word, length + 1);
    }
}

Console.Write("Вариант2 - Рекурсия. Введите какой длины слова составлять: ");
int V = Convert.ToInt32(Console.ReadLine());
FindWords("аист", new char[V]);

