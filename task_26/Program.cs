// 26. Напишите программу, которая на вход число и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int countNumbers = CountNumbers(number);
Console.WriteLine($"{number} -> {countNumbers}");


int CountNumbers(int num)
{
    if(num < 0) num = num * -1;
    int count = 0;
    while(num > 0)
    {
        num = num / 10;
        count++;
    }   
    return count;
}