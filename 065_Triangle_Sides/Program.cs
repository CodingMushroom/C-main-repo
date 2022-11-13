// Выяснить являются ли числа сторонами треугольника (№41)

// Правило сотношения сторон треугольника:
// длина любой стороны треугольника не может быть больше или равна сумме длин двух других сторон

Console.Write("Введите первую сторону = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону = ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону = ");
int C = Convert.ToInt32(Console.ReadLine());

if ((A <= 0 || B <= 0 || C <= 0) || (A + B <= C || A + C <= B || C + B <= A)) // проверяем основное правило и наличие длины = 0
    Console.WriteLine("Треугольник не существует");
else Console.Write("Треугольник существует");

if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2) || 
    Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2) ||
    Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2))
    Console.WriteLine(" и он является прямоугольным");
else if (A == B && B != C)
    Console.WriteLine(" и он является равнобедренным");
else if (A == C && B != C)
    Console.WriteLine(" и он является равнобедренным");
else if (B == C && A != C)
    Console.WriteLine(" и он является равнобедренным");
else if (A == B && B == C)
    Console.WriteLine(" и он является равносторонним");
else Console.WriteLine(" и он обычный");

Console.WriteLine();
