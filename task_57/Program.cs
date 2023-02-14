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

int[] CreateArray (int[,] matrix)
{
    int size = matrix.GetLength(0) * matrix.GetLength(1);
    int[] array = new int[size];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) // for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }
        
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1)
            Console.Write($"{array[i]}; ");
        else Console.WriteLine($"{array[i]}.");
    }
}

void FrequencyDictionary(int[] array)
{
    int count = 0;
    int num = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] == num)
        count++;
        else 
        {
            Console.WriteLine($"Число {num} встречается {count} раз(а)");
            num = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {num} встречается {count} раз(а)");
}

int[,] matrix = CreateMatrix(3, 5, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] createArray = CreateArray(matrix);
Array.Sort(createArray);
PrintArray(createArray);
FrequencyDictionary(createArray);
