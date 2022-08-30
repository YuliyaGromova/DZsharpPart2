//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRnd(int min, int max)
{
    Random rnd = new Random();
    int row = rnd.Next(2, 10);
    int col = rnd.Next(2, 10);
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)   //row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   //col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}
// метод, печатающий двумерный массив
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
            if (j != matrix.GetLength(1) - 1) Console.Write(",");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

string RowMinSum(int[,] matrix)
{
    int row = default;
    int minSum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return ($"Строка,в которой сумма элементов минимальна: {row + 1} строка");
}

// код
int[,] mat = CreateMatrixRnd(0, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(mat);
Console.WriteLine();

Console.WriteLine(RowMinSum(mat));