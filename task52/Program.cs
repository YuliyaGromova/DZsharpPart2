// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// метод, который создает двумерный массив
int[,] CreateMatrixRnd(int min, int max)
{
    Random rnd = new Random();
    int row = rnd.Next(2, 10);                //пусть и размеры матрицы заранее не известны, так интереснее
    int col = rnd.Next(1, 10);                // + двумерный, значит минимум 2 строки
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
void PrintMatrix2D(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
            if (j != matrix.GetLength(1) - 1) Console.Write(",");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}

//метод, печатающий одномерный массив
void PrintMatrix(double[] matrix)
{

    Console.Write("[");
    for (int j = 0; j < matrix.Length; j++)
    {
        Console.Write($"{matrix[j]}");
        if (j != matrix.Length - 1) Console.Write("; ");
    }
    Console.Write("]");
    Console.WriteLine();
}

//метод, создающий одномерный массив, кот. заполняется средним арифметическим значением по столбцам двумерного массива
double[] ArifmeticMeanCol(int[,] matrix)
{
    double[] arif = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        arif[i] = Math.Round((double)sum / matrix.GetLength(0), 1, MidpointRounding.AwayFromZero);
    }
    return arif;
}

// код
Console.WriteLine("Исходный массив:");
int[,] mat = CreateMatrixRnd(0, 10);
PrintMatrix2D(mat);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое по каждому столбцу исходного массива:");
double[] sr = ArifmeticMeanCol(mat);
PrintMatrix(sr);