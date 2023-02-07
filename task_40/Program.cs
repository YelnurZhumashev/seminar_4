// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. 

bool CheckTriangle(int a, int b, int c)
{
    return a < (b + c) && b < (a + c) && c < (a + b);
}


Console.WriteLine("Введите три стороны треугольника:");
Console.Write("A = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("C = ");
int c = Convert.ToInt32(Console.ReadLine());
bool result = CheckTriangle(a, b, c);
Console.WriteLine(result ? $"Да": $"Нет");