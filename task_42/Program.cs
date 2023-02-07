// Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int NumberBinary(int number)
{
    int result = 0;
    int count = 1;
    while (number > 0)
    {
        result = result + (number % 2 * count);
        number = number / 2;
        count = count * 10;
    }
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = NumberBinary(number);
Console.WriteLine($"Двоичное число -> {res}");