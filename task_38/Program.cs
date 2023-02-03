// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// int[] CreateArrayRndInt (int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++) // for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

double[] CreateArrayRndDouble (int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) // for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
        
    }
    Console.Write("]");
}

double ElementsCount(double[] arr)
{
    int imin = 0, imax = 0;
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > arr[imax]) imax = i;
        if(arr[i] < arr[imin]) imin = i;
        sum = arr[imax] - arr[imin];
        sum = Math.Round(sum, 1);
    }
    return sum;
}

double[] array = CreateArrayRndDouble(6, 0, 100);
PrintArrayDouble(array);
double answer = ElementsCount(array);
Console.WriteLine($" -> {answer}");