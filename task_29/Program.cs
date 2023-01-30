// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] CreateArray(int size)
{
    int[] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0,99);
    }
    return array;
}

void PrintArray(int[] array){
  int count = array.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(array[index]);
    index = index + 1;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

int[] arr = CreateArray(8);
PrintArray(arr);