int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

void ReplacementMatrix(int[,] matrixMassIn)
{
    int temp;
    for (int i = 0; i < matrixMassIn.GetLength(1); i++)
    {
        temp = matrixMassIn[0, i];
        matrixMassIn[0, i] = matrixMassIn[matrixMassIn.GetLength(0)-1, i];
        matrixMassIn[matrixMassIn.GetLength(0)-1, i] = temp;
    }
}

int[,] matrix = CreateMatrix(4, 5, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
ReplacementMatrix(matrix);
PrintMatrix(matrix);