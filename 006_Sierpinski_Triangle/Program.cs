// Задание: рисуем трегольник при помощи деления отрезков

Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");

int xa = 30, ya = 1,
    xb = 1, yb = 30,
    xc = 60, yc = 30;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa, y = xb; //задаем произвольную точку
int count = 0; //сколько раз выполнять операцию деления отрезков пополам

while(count < 10000)
{
   int what = new Random().Next(0,3); // [0;3) выдаются числа 0,1,2
   if(what == 0)
   {
    x = (x + xa) / 2;
    y = (y + ya) / 2;
   }

    if(what == 1)
   {
    x = (x + xb) / 2;
    y = (y + yb) / 2;
   }
   if(what == 2)
   {
    x = (x + xc) / 2;
    y = (y + yc) / 2;
   }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count = count + 1; // count++ (для краткости введено)
}

Console.WriteLine();