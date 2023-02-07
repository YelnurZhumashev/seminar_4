// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) // for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
        
    }
    Console.Write("]");
}

int PositiveCount(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        result = result + 1;
    }
    return result;
}

Console.Write("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(number, -200, 200);
PrintArray(array);
int result = PositiveCount(array);
Console.WriteLine($" -> {result}");

// Второй вариант с ввод данных от пользователя
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


// void PrintArray (int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
        
//     }
//     Console.Write("]");
// }

// int PositiveCount(int[] arr)
// {
//     int result = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0)
//         result = result + 1;
//     }
//     return result;
// }

// PrintArray(arr);
// int result = PositiveCount(arr);
// Console.WriteLine($" -> {result}");