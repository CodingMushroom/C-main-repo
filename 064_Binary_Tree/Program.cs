// Обход структуры. Бинарное дерево. Решаем уравнение: ((4-2)*(1+3)) / 10

string Empty = string.Empty;
string[] tree = { Empty, "/", "*", "10", "-", "+", Empty, Empty, "4", "2", "1", "3"};
//                  0     1    2    3     4    5     6     7     8    9    10   11

void InOrderTraversal (int pos = 1)  // метод горизонтального обхода pos - позиция с которой начинаем
{
    if (pos < tree.Length) // если позиция выйдет за кол-во элементов, рекурсия закончится
    {
        int left = 2*pos;
        int right = 2*pos+1;
        if (left < tree.Length && !string.IsNullOrEmpty(tree[left])) InOrderTraversal(left); // если левая позиция (узел) имеется и поз-я не является пустой, то рекурсивно запускаем обход дерева с текущей позиции
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !string.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}

InOrderTraversal();
