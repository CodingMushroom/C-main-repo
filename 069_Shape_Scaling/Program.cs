// Написать программу масштабирования фигуры (четырехугольник) (№45)
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

Console.WriteLine();
Console.WriteLine("Программа масштабирования 4-ехугольника с вершинами a, b, c, d");

void FillArray(string[] Inserted_Text, double[] Array)
{
    for (int i = 0; i < Inserted_Text.Length; i++)
    {
        for (int k = 0; k < Inserted_Text.Length; k++)
        {
            if (Inserted_Text[i] == '(' || ')' || ' ' || ',') i++;
            Array[k] = Inserted_Text[i];
        }       
    }
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"|{Array[i]}|");
    }
}

Console.WriteLine();
Console.Write("Введите координаты вершин в формате (a1,a2) (b1,b2) (c1,c2) (d1,d2) = ");
string Inserted_Text = Convert.ToString(Console.ReadLine());
double[] Array = new double[Inserted_Text.Length];
Console.ReadLine();

FillArray(Inserted_Text, Array);
PrintArray(Array);








