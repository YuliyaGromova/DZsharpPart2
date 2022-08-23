//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string LineIntersection(int a1, int b1, int a2, int b2)
{
    double x = default;
    double y = default;
    if (a1 != a2)
    {
        x = (double)(b2 - b1) / (a1 - a2);     //оказывается, если int делить на int, то получится int, а не double
        y = a1 * x + b1;
        return ($"Прямые заданные уравнениями y={a1}*x+({b1}) и y={a2}*x+({b2}) пересекаются в точке ({Math.Round(x, 1, MidpointRounding.ToZero)};{Math.Round(y, 1, MidpointRounding.ToZero)})");
    }

    else if (a1 == a2 && b1 != b2) return ($"Прямые заданные уравнениями y={a1}*x+({b1}) и y={a2}*x+({b2}) не пересекаются");
    else return ($"Прямые заданные уравнениями y={a1}*x+({b1}) и y={a2}*x+({b2}) совпадают");
}

Console.WriteLine("Введите коэффициэнты k и b, чтобы задать уравнение первой прямой");
Console.Write("Коэффициэнт b: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Коэффициэнт k: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коэффициэнты k и b, чтобы задать уравнение второй прямой");
Console.Write("Коэффициэнт b: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Коэффициэнт k: ");
int k2 = Convert.ToInt32(Console.ReadLine());

string res = LineIntersection(k1, b1, k2, b2);
Console.WriteLine(res);