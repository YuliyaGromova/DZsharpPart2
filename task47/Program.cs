// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

// метод создающий двумерный массив, заполненый случайными вещественными числами
double[,] CreateMatrixRnd(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    double[,] matrixDob = new double[row, col];
    double[,] bigDob = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   //col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
            matrixDob[i, j] = rnd.NextDouble();
            bigDob[i, j] = Math.Round(matrix[i, j] + matrixDob[i, j], 1, MidpointRounding.ToZero); //округляем до одного знака после запятой, как в тестовом примере
        }
    }
    return bigDob;
}

// метод, который выводит на печать двумерный массив, заполненый вещественными числами
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");   // если есть отступ, то разделитель не нужен
        }
        Console.Write("|");
        Console.WriteLine();
    }
}

// код
Console.Write("Введите количество строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cl = Convert.ToInt32(Console.ReadLine());
if (r < 1 || cl < 1) Console.WriteLine("Введено некорректное значение");
else
{
    double[,] mat = CreateMatrixRnd(r, cl, 0, 10);
    PrintMatrix(mat);
    Console.WriteLine();
}
