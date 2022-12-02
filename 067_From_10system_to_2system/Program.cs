// Программа преобразования 10-ичного числа в 2-ичное (№43)
// теория - https://programforyou.ru/calculators/number-systems

// Часть 1 Метод - перевода из 10-ичной в заданную систему 

void NumberBackConvertation(int number, int system) // перевод 10-го числа в указанную через "," систему
{
    if (system <= 10)
    {
        if (number <= 0) return;
        NumberBackConvertation(number / system, system);
        Console.Write(number % system);
    }
    else
    {
        if (number <= 0) return;
        NumberBackConvertation(number / system, system);

        if (number % system >= 10 && number % system <= 15)
        {
            switch (number % system)
            {
                case 10:
                    Console.Write("A");
                    break;

                case 11:
                    Console.Write("B");
                    break;

                case 12:
                    Console.Write("C");
                    break;

                case 13:
                    Console.Write("D");
                    break;

                case 14:
                    Console.Write("E");
                    break;

                case 15:
                    Console.Write("F");
                    break;
            }
        }
        else
        {
            Console.Write(number % system);
        }
    }
}

// Часть 2 Перевод из 10-ичной в заданную систему

Console.Write("Введите число в 10-й системе и, через запятую, введите число СС, в которую надо перевести 10-ичное число - ");
string Text = Console.ReadLine();

string[] number;                                                    // вводим массив для записи в [0] - целой части, в [1] - вещественной (после ,)
if (Text.Contains(",")) number = Text.Split(',');                   // условие разделения заданного пользователем числа и СС
else number = Text.Split('.');                                      // если не будет , или . разбиения не произойдет и array[0] = заполнится заданным числом

int.TryParse(number[0], out int DecimalNumber);                     // перевод строкового текста в int  и записть ( через out) в переменную
int.TryParse(number[1], out int System);

Console.Write($"Число {DecimalNumber} в 10-чной системе в {System}-чной будет = ");
NumberBackConvertation(DecimalNumber, System);
Console.WriteLine();
Console.WriteLine();


// пример решения без рекурсии

// метод

//static string convertingToBin(int num, string snum)
//{   
//    if (num % 2 == 0) snum = "0" + snum;
//    else snum = "1" + snum;
//   
//    if ((num/2) != 0) return convertingToBin(num/2, snum); 
//    else return snum;
//}

// решение

// Console.Write("Введите десятичное число: "); 
//int numberDec = Convert.ToInt32(Console.ReadLine());

//string numberBin = "";
//numberBin = convertingToBin(numberDec, numberBin); Console.WriteLine();
//Console.Write("Двоичное число: " + numberBin); 
