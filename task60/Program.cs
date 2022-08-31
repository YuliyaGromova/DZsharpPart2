// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// метод, который создает трехмерный массив, заполняет его случайными двузначными числами и выводит элементы массива
void CreateMatrix3D(int x, int y, int z)
{
    int[,,] kubik = new int[x, y, z];
    int[] array = new int[90];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 10;
    }
    Random rnd = new Random();
    for (int i = 0; i < kubik.GetLength(0); i++)   //ряды
    {
        for (int j = 0; j < kubik.GetLength(1); j++)   //колонки
        {
            for (int k = 0; k < kubik.GetLength(2); k++)    //уровни
            {
                int index = rnd.Next(0, 90);
                while (array[index] == 0) index = rnd.Next(0, 90);

                kubik[i, j, k] = array[index];
                Array.Clear(array, index, 1);

                Console.WriteLine($"{kubik[i, j, k]} ({i},{j},{k})");
            }
        }
    }
}

// код
Console.WriteLine("Укажите три параметра для создания трехмерного массива: ");
Console.Write("Первый параметр: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второй параметр: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Третий параметр: ");
int z1 = Convert.ToInt32(Console.ReadLine());
if (x1 * y1 * z1 < 90) CreateMatrix3D(x1, y1, z1);
else Console.WriteLine("Введены некорректные значения, невозможно заполнить массив неповторяющимися двузначными числами");

