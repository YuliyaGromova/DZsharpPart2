// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого элемента в массиве нет

// метод, который создает двумерный массив
int[,] CreateMatrixRnd(int min, int max)
{
    Random rnd = new Random();
    int row = rnd.Next(2, 10);                // пусть и размеры матрицы заранее не известны, так интереснее
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

//метод, который выводит значение элемента массива
string ValueMatrixElement(int[,] matrix, int row, int col)
{
    if (row > matrix.GetLength(0) || col > matrix.GetLength(1) || row < 1 || col < 1)
        return $"[{row},{col}] -> такого элемента в массиве нет";
    else return $"Значение элемента массива [{row},{col}] -> {matrix[row - 1, col - 1]}";   // -1, для того чтобы пользователь не догадался, что нумерация элементов с 0
}

//код
Console.Write("Введите номер строки: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер стобца: ");
int cl = Convert.ToInt32(Console.ReadLine());

// не проверяем ввел ли пользователь корректное значение, т. к. при использовании метода получим нормальный ответ, что такого элемента нет в массиве
int[,] mat = CreateMatrixRnd(0, 10);
PrintMatrix(mat);
Console.WriteLine();

Console.WriteLine(ValueMatrixElement(mat, r, cl));
