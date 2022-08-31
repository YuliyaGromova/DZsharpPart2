// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Создание матрицы-улитки
int[,] SnailMatrix(int row)
{
    int[,] snail = new int[row, row];
 
    int count = 1;
    int x = row-1;   
    int y = 0;       
    while (count <= row * row)
    {
        for (int j = y; j < x+1; j++)
        {
            snail[y,j]=count;
            count++;
        }
        for (int i = y+1; i < x+1; i++)
        {
            snail[i,x]=count;
            count++;
        }
        for (int j = x-1; j >= y; j--)
        {
            snail[x,j]=count;
            count+=1;
        }
        for (int i = x-1; i >=y+1; i--)
        {
            snail[i,y]=count;
            count++;
        }
        x-=1;
        y+=1;
    }

    return snail;
}
// печать двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк (столбцов) квадратного двумерного массива: ");
int row1 = Convert.ToInt32(Console.ReadLine());
int[,] snail1 = SnailMatrix(row1);
PrintMatrix(snail1);