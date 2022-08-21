// Задание: 30. Провека кратно ли число заданному. Если "нет" - вывести остаток

Console.WriteLine("Эта прога проверяет кратно ли одно число другому");
Console.Write("Введите проверяемое на кратность число A - ");
double NumberA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите какому числу B проверим на кратность A - ");
double NumberB = Convert.ToDouble(Console.ReadLine());

if (NumberB == 0)
    Console.WriteLine("На ноль делить нельзя");

else if (NumberA % NumberB == 0)
    Console.WriteLine($"A кратно В. Результат = {NumberA / NumberB}");

else
    Console.WriteLine($"A не кратно В. Остаток от деления = {NumberA % NumberB}");
