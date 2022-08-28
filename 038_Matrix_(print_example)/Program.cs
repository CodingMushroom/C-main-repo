// string[,] table = new string[2,5];  - матрица 2 строки, 5 колонок. Данные - текст
// table[1,2] = "слово";  -  в первой строке, 2-м столбце указано "слово"
// вид матрицы:
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

// Пример

void FillMatrix(int[,] matrix) // метод наполнения матрицы случайными числами
{
    for (int line = 0; line < matrix.GetLength(0); line++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            matrix[line,column] = new Random().Next(0,10); // интервал [0, 10)
        }
       
    }

}

void PrintMatrix(int[,] matrix) // метод печати матрицы
{
    for (int line = 0; line < matrix.GetLength(0); line++) // Array.GetLength получает 32-разрядное целое число, представляющее количество элементов в заданном измерении массива Array
    {                                                      // GetLength(0) -  возвращает число элементов в первом измерении Array (число строк).
        for (int column = 0; column < matrix.GetLength(1); column++) // GetLength(1) - возвращает число столбцов (второе измерение матрицы)
        {
            Console.Write($" {matrix[line,column]} ");
        }
    Console.WriteLine();
    }

}


int[,] matrix = new int[3,4]; // создаем массив 3 строки, 4 столбца
PrintMatrix(matrix); // печатаем пустую матрицу (с 0-и)
Console.WriteLine();
FillMatrix(matrix); // наполняем матрицу цифрами
PrintMatrix(matrix); // выводим матрицу на печать