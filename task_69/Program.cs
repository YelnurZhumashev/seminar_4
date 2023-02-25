/*Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/
Console.WriteLine("Введите число А ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В ");
int num2 = Convert.ToInt32(Console.ReadLine());
int power = PowerNumbers(num1, num2);

Console.WriteLine($"{num1} в степени {num2} равно {power}");


int PowerNumbers(int number1, int number2)
{
if (number2 == 0) return 1;
else return number1 * PowerNumbers(number1, number2 - 1);
}