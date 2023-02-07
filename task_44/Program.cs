// Задача 44. Не используя рекурсию, введите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3  
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
 

int[] NumberFibonachi(int number)
{
    int[] array = new int [number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i-2] + array[i-1];
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = NumberFibonachi(number);
PrintArray(arr);


// Fibonacci(number);
// void Fibonacci(int num)
// {
//     int first = 0, second = 1;
//     Console.Write($"Если N = {number} -> {first} {second} ");
//     for (int i = 3; i <= number; i++)
//     {
//         int newNumber = first + second;
//         Console.Write($"{newNumber} ");
//         first = second;
//         second = newNumber;
//     }
// }

// Console.Write("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());