// Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве (+2D) (ДЗ №21)
// Теория: https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/

Console.WriteLine();
Console.WriteLine("Находим расстояние между точками в 2D и 3D");
Console.WriteLine();
Console.Write("Выберите размерность пространства:");
Console.Write(" 2D - введите '2'/ ");
Console.WriteLine("3D - введите '3'.");
Console.Write("Ваш выбор: ");
byte Space = Convert.ToByte(Console.ReadLine());
Console.WriteLine("");

double Method4_1(double a, double b, double c, double d) // метод расчет для 2D
{
    double Distance = 0;
    Distance = Math.Sqrt(Math.Pow(b - a, 2) + Math.Pow(d - c, 2)); // Math.Sqrt - квадратный корень, Math.Pow(x, "степень") - возведение в степень
    return Distance;
}


double Method4_2(double a1, double b1, double c1, double d1, double e1, double f1) // метод расчет для 3D
{
    double Distance = 0;
    Distance = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(d1 - c1, 2) + Math.Pow(f1 - e1, 2));
    return Distance;
}

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
    
    double resultSpace2 = Method4_1(X1, X2, Y1, Y2);
    Console.Write("Расстояние м/у указанными точками в 2D = " + resultSpace2);
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

    double resultSpace3 = Method4_2(X1, X2, Y1, Y2, Z1, Z2);
    Console.WriteLine("Расстояние м/у указанными точками в 3D = " + resultSpace3);
}

  Console.WriteLine();