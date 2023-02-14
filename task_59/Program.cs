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

int[] MinElementIndex(int[,] matrix)
{
    int[] result = new int[2];
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < min)
            {
                min = matrix[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1)
            Console.Write($"[{array[i]}; ");
        else Console.WriteLine($"{array[i]}]");
    }
}

int[,] DeleteMin(int[,] matrix, int[] array)
{
    int rowsSize = matrix.GetLength(0) - 1;
    int columnsSize = matrix.GetLength(1) - 1;
    int[,] resultMatrix = new int[rowsSize, columnsSize];
    int m = 0;
   
    for (int i = 0; i < rowsSize; i++)
    {
        if(m == array[0]) m++;
        int n = 0;
        for (int j = 0; j < columnsSize; j++)
        {
            if(n == array[1]) n++;
            resultMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
    }
    return resultMatrix;
}


int[,] matrix = CreateMatrix(5, 5, 0, 25);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write("Индекс минимального элемента: ");
int[] minElementIndex = MinElementIndex(matrix);
PrintArray(minElementIndex);
Console.WriteLine("Результат:");
int[,] answer = DeleteMin(matrix, minElementIndex);
PrintMatrix(answer);