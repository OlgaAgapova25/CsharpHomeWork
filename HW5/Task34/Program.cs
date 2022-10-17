// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int numberOfElements = 10;
int minValue = 100;
int maxValue = 999;

int[] array = FillArray(numberOfElements, minValue, maxValue);
PrintArray(array);
Console.WriteLine($" -> {Main(array)}");

int[] FillArray (int number, int min, int max)
{
    int[] arr = new int[number];
    int length = number;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(min,max+1);
        index++;
    }
    return arr;
}

void PrintArray(int[] array)
{
    int index = 0;
    int length = array.Length;
    while (index < length)
    {
        if (index == 0) Console.Write($"[{array[index]}, ");
        else if (index == length - 1) Console.Write($"{array[index]}]");
        else Console.Write($"{array[index]}, ");
        index++;
    }
}

int Main(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) 
        {
            count ++;
        }
    }
    return count;
}