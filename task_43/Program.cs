// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine("Введите три стороны треугольника:");
Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

double ResultX(double b1, double k1, double b2, double k2)
{
    return (b2-b1)/(k1-k2);
}
double ResultY(double b1, double k1, double b2, double k2)
{
    return (k2 * b1 - k1 * b2)/(k2 - k1);
}

double x = ResultX(b1,k1,b2,k2);
double y = ResultY(b1,k1,b2,k2);
x = Math.Round(x, 3);
y = Math.Round(y, 3);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");

