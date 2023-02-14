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

int[,] ReplacementMatrix(int[,] matrix)
{
    int[,] tempMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempMatrix[j, i] = matrix[i, j];
        }
    }
    return tempMatrix;
}

bool IsSquareMatrix(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}


int[,] matrix = CreateMatrix(5, 4, 0, 255);
PrintMatrix(matrix);
Console.WriteLine();
if(IsSquareMatrix(matrix))
{
    PrintMatrix(ReplacementMatrix(matrix)); 
}
else
{
    Console.WriteLine("Не возможно обработать массив!");
}

