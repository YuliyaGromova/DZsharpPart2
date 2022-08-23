// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] CreateMasRuchkami(int m)
{
    int[] arr = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1}-e число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountPlus(int[] array)
{
    int counteven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counteven++;
    }
    return counteven;
}
Console.Write("Сколько чисел Вы хотите ввести?: ");
int M = Convert.ToInt32(Console.ReadLine());
if (M < 1) Console.WriteLine("Некорректное значение. Количество чисел должно быть больше 0");
else
{
    int[] res = CreateMasRuchkami(M);
    int result = CountPlus(res);
    Console.WriteLine($"Количество чисел больше нуля => {result}");
}
