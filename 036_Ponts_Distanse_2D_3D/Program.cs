// Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве (+2D) (ДЗ №21)
// Теория: https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/

Console.WriteLine();
Console.WriteLine("2Находим расстояние между точками в 2D и 3D");
Console.WriteLine();
Console.Write("Выберите размерность пространства:");
Console.Write(" 2D - введите '2'/ ");
Console.WriteLine("3D - введите '3'.");
Console.Write("Ваш выбор: ");
byte Space = Convert.ToByte(Console.ReadLine());
Console.WriteLine("");

if (Space == 2)
{
    Console.WriteLine("Введите координаты первой точки: ");
    Console.Write("X1 = ");
    double X1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y1 = ");
    double Y1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите координаты второй точки: ");
    Console.Write("X2 = ");
    double X2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y2 = ");
    double Y2 = Convert.ToDouble(Console.ReadLine());
    
    double Distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
    Console.Write("Расстояние м/у указанными точками в 2D = " + Distance);
}

if (Space == 3)
{
    Console.WriteLine("Введите координаты первой точки: ");
    Console.Write("X1 = ");
    double X1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y1 = ");
    double Y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Z1 = ");
    double Z1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите координаты второй точки: ");
    Console.Write("X2 = ");
    double X2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y2 = ");
    double Y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Z2 = ");
    double Z2 = Convert.ToDouble(Console.ReadLine());

    double Distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
    Console.WriteLine("Расстояние м/у указанными точками в 3D = " + Distance);
}

  Console.WriteLine();