// 24. Напишите программу, которая принимает на вход число (А) и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int FactorialNumber(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        sum = sum * i;
    }
    return sum;
}

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorialNumber = FactorialNumber(number);
if (number > 0)
{
    Console.WriteLine($"Произведение чисел от 1 до {number} -> {factorialNumber}");
}
else
{
    Console.WriteLine("Введите натуральное число");
}




