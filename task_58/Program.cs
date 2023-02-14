// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3} | ");
            else Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}



int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int rowsInA = firstMatrix.GetLength(0);
    int columnsInA = firstMatrix.GetLength(1); 
    int columnsInB = secondMatrix.GetLength(1); 

    int[,] matrix = new int[rowsInA, columnsInB];

    for (int i = 0; i < rowsInA; i++)
    {
        for (int j = 0; j < columnsInB; j++)
        {
            for (int k = 0; k < columnsInA; k++) 
            {
                matrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }

    return matrix; 
}

Console.WriteLine("Первый массив:");
int[,] arrayOne = CreateMatrix(2, 2, 1, 10);
WriteArray(arrayOne);
Console.WriteLine("Второй массив:");
int[,] arrayTwo = CreateMatrix(2, 2, 1, 10);
WriteArray(arrayTwo);
Console.WriteLine();
int[,] matrixThree = MultiplyMatrix(arrayOne, arrayTwo);
Console.WriteLine("Произведение двух матриц:");
WriteArray(matrixThree);