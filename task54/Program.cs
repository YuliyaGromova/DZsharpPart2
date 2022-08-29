// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// метод, который создает двумерный массив
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

// метод, сортирующий элементы в пределах строки
void SortRowMatrix(int[,] matrix)
{
    for (int l = 0; l <matrix.GetLength(0); l++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            int col=matrix.GetLength(1)-1-j;
            int minimum=matrix[l,matrix.GetLength(1)-1-j];
            for (int i = 0; i < matrix.GetLength(1)-j-1; i++)
            {
                if (matrix[l,i]<minimum)
                {
                    col=i;
                    minimum=matrix[l,i];
                } 
            }
            matrix[l,col]=matrix[l,matrix.GetLength(1)-1-j];
            matrix[l,matrix.GetLength(1)-1-j]=minimum;
        }
    }
    
}


// код
int[,] mat = CreateMatrixRnd(0, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(mat);
Console.WriteLine();
SortRowMatrix(mat);
Console.WriteLine("Массив, в котором элементы каждой строки упорядочены по убыванию: ");
PrintMatrix(mat);
