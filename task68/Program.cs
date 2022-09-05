// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

// метод: Функция Аккермана
int FunctionAkkerman(int m, int n)
{
    int a = 1;
    if (m == 0)
    {
        a = n + 1;
        return a;
    }
    else if (m > 0 && n == 0)
    {
        a = FunctionAkkerman(m - 1, 1);
        return a;
    }
    else if (n > 0 && m > 0)
    {
        int b = FunctionAkkerman(m, n - 1);
        a = FunctionAkkerman(m - 1, b);
    }
    return a;
}

// код
Console.Write("Введите первое целое положительное число:");
int mu = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое положительное число:");
int nu = Convert.ToInt32(Console.ReadLine());

if (mu < 0 || nu < 0) Console.WriteLine("Введено некорректное значение");
else
{
    int res = FunctionAkkerman(mu, nu);
    Console.WriteLine($"A({mu},{nu}) = {res}");
}