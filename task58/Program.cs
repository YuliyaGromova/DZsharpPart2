// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4  3 4
// 3 2  3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// создаем двумерные массивы, заполненые случайными числами
int[,] CreateMatrixRnd(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)   //row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   //col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

// печать двумерного массива
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

// перемножение двух двумерных массивов
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multi = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int l = 0; l < multi.GetLength(0); l++)  //1
    {
        for (int k = 0; k < multi.GetLength(0); k++)  //1 
        {

            for (int j = 0; j < multi.GetLength(1); j++)   //2
            {
                int mul = 0;
                for (int i = 0; i < matrix1.GetLength(1); i++)    //3
                {
                    mul += matrix1[l, i] * matrix2[i, j];

                }
                multi[l, j] = mul;
            }

        }
    }
    return multi;
}

// код
Console.WriteLine("Операция умножения выполнима только в том случае, если число столбцов в первом массиве равно числу строк во втором");
Console.Write("Введите количество строк первого массива: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второго массива: ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второго массива: ");
int c2 = Convert.ToInt32(Console.ReadLine());

if (r1 > 0 && c1 > 0 && r2 > 0 && c2 > 0)
{
    int[,] mat1 = CreateMatrixRnd(r1, c1, 0, 10);
    PrintMatrix(mat1);
    Console.WriteLine();
    int[,] mat2 = CreateMatrixRnd(r2, c2, 0, 10);
    PrintMatrix(mat2);
    Console.WriteLine();
    if (mat1.GetLength(1) == mat2.GetLength(0))
    {
        int[,] mat3 = MultiplicationMatrix(mat1, mat2);
        PrintMatrix(mat3);
    }
    else Console.WriteLine("Умножение невозможно, измените размеры массивов");
}
else Console.WriteLine("Умножение невозможно, введены некорректные значения");