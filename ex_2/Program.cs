// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNumber()
{

    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}
void Cross(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"({x}, {y})");
}
Console.WriteLine("Программа по расчету точки пересечения двух линий: ");
Console.Write("Введите значениe k1: ");
double k1 = InputNumber();
Console.Write("Введите значениe b1: ");
double b1 = InputNumber();
Console.Write("Введите значениe k2: ");
double k2 = InputNumber();
Console.Write("Введите значениe b2: ");
double b2 = InputNumber();
Cross(b1, k1, b2, k2);
