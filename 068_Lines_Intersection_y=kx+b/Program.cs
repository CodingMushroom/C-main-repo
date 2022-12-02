// Найти точку пересечения двух прямых заданных ур-ем y = k1 * x + b1, b1 k1 и b2 k2 - заданы

// приравниваем правые части ур-ий (y=y). выражаем x. подставляем в исходное
// k1*x+b1=k2*x+b2
// x=(b2-b1)/(k1-k2)
// y=k1(b2-b1)/(k1-k2)+b1
// ответ: x=(b2-b1)/(k1-k2), y=k1(b2-b1)/(k1-k2)+b1 

Console.WriteLine();
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

if (k1 == k2 && b1 == b2)
    Console.Write("Прямые совпадают во всех своих точках");
else if (k1 == k2)
    Console.Write("Точки пересечения нет, прямые параллельны");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 2);
    y = Math.Round(y, 2);
    Console.Write("Точка пересечения прямых имеет координаты: (" + x + "; " + y + ") ");
}
Console.WriteLine();
Console.WriteLine();
