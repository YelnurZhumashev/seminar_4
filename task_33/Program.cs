// Задача 33. Задайте массив. Напишите программу, которая определяет, прсутсвует ли заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] -> нет 
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool CheckArray(int number, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == number) return true;
    }
    return false;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int[] array = CreateArrayRndInt(10, -20, 20);
PrintArray(array);
bool mass = CheckArray(number, array);
Console.WriteLine(mass ? $" -> Да": $" -> Нет");