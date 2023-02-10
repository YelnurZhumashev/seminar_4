/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет*/
int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}

int[,] matrix = CreateMatrix(4, 5, 1, 100);
Console.WriteLine("Введите индексы искомого элемента:");
Console.Write("Индекс строки: ");
int indexRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Индекс столбца: ");
int indexColumns = Convert.ToInt32(Console.ReadLine());
if (indexRows < 0 || indexColumns < 0)
{
Console.WriteLine("Число должно быть больше нуля.");
return;
}
if (indexRows > matrix.GetLength(0) || indexColumns > matrix.GetLength(1))
{
Console.WriteLine("Элемента с таким индексом не существует.");
return;
}
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Искомый элемент индексов {indexRows} и {indexColumns} равен {matrix[indexRows, indexColumns]}");