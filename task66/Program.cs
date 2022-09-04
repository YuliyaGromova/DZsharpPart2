// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// метод с рекурсией
int SumNumbers(int num, int num2)
{
    if (num < num2)
    {
        int temp = num;
        num = num2;
        num2 = temp;
    }
    int summ = num;
    if (num == num2) return summ;
    {
        summ += SumNumbers(num - 1, num2);
    }
    return summ;
}
//код
Console.Write("Введите первое целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое положительное число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number2 < 1) Console.WriteLine($"Введено некорректное значение. В диапазоне ({number} - {number2}) есть числа, которые не являются натуральными");
else
{
    int res = SumNumbers(number, number2);
    Console.WriteLine(res);
}