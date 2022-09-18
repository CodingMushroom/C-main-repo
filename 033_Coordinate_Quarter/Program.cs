// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine();
Console.WriteLine("__________________________________________________________________________________________________________");
Console.WriteLine("Задание 19. Опред-ть номер четверти плоск-и, в которой находится точка с коорд Х и У, причем X ≠ 0 и Y ≠ 0");
Console.WriteLine("__________________________________________________________________________________________________________");
Console.WriteLine();

int QuarterNumber = 0;
int x = new Random().Next(-100, 101);
int y = new Random().Next(-100, 101);
Console.WriteLine($"Координаты точки: ({x}, {y})");

if (x > 0 && y > 0) QuarterNumber = 1;
else if (x < 0 && y > 0) QuarterNumber = 2;
else if (x < 0 && y < 0) QuarterNumber = 3;
else if (x > 0 && y < 0) QuarterNumber = 4;
else if (x == 0) QuarterNumber = 5;
else if (y == 0) QuarterNumber = 6;

Console.Write($"Точка с координатами ({x}, {y}) находится ");

if (QuarterNumber == 5) Console.WriteLine("на оси Oy");
else if (QuarterNumber == 6) Console.WriteLine("на оси Ox");
else Console.WriteLine($"в {QuarterNumber}-й четверти");

Console.WriteLine();

