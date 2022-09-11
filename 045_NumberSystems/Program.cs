// 1. Написать метод, который генерирует массив 0 и 1 заданного количества N
// 2. Написать метод перевода из 2-ичной в 10-ичную систему
// 3. Написать метод переводящий 10-ичное число в заданную систему

//_______________________________________________________________________________________________________________________________________________
// Часть 1 Описание методов

internal class Program
{
    private static void Main(string[] args)
    {
        void FillArray(int[] array)                                         // создание случайного двоичного числа (в виде массива)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 2);
            }
            if (array[0] == 0) array[0] = 1;
            else array[0] = array[0];
        }

        void PrintArray(int[] array)                                        // вывод в консоль двоичного числа (массив)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
            }
        }

        int NumberConvertation(int[] array)                                 // перевод из 2-ичной в 10-ичную систему
        {
            int Degree = array.Length - 1;
            int Sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Sum = Sum + array[i] * (int)Math.Pow(2, Degree);
                Degree = Degree - 1;
            }
            return Sum;
        }

        void NumberBackConvertation(int number, int system)                // перевод 10-го числа в указанную через "," систему
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

        //________________________________________________________________________________________________________________________________________________
        // Часть 2 Перевод из 2-ичной в 10-ичную систему
        // теория - https://programforyou.ru/calculators/number-systems

        Console.WriteLine();
        Console.Write("Укажите сколько цифр хотите в 2-ичном числе - ");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] ARR = new int[N];
        FillArray(ARR);

        Console.Write($"Сгенерировано 2-ичное число = ");
        PrintArray(ARR);

        Console.WriteLine();
        Console.WriteLine($"Которое соответсвует в 10-ичной системе числу = {NumberConvertation(ARR)}");
        Console.WriteLine();

        //_________________________________________________________________________________________________________________________________________________
        // Часть 3 Перевод из 10-ичной в заданную систему

        Console.Write("Введите число и его СС после запятой, для перевода в 10-ичную СС - ");
        string Text = Console.ReadLine();

        string[] number;                                                // вводим массив для записи в [0] - целой части, в [1] - вещественной (после ,)
        if (Text.Contains(",")) number = Text.Split(',');                     // условие разделения заданного пользователем числа и СС
        else number = Text.Split('.');                                     // если не будет , или . разбиения не произойдет и array[0] = заполнится заданным числом

        int.TryParse(number[0], out int DecimalNumber);                     // перевод строкового текста в int  и записть ( через out) в переменную
        int.TryParse(number[1], out int System);

        Console.Write($"Число {DecimalNumber} 10-чной системы в {System}-чной будет = ");
        NumberBackConvertation(DecimalNumber, System);
        Console.WriteLine();
    }
}